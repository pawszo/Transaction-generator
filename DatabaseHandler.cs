using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace TransGenerator
{
    public class DatabaseHandler
    {
        public string ConnectionString { get; private set; }

        public DatabaseHandler(string connectionString)
        {
            ConnectionString = connectionString;
        }
        public int GetYearPart(string period)
        {
            string yearSr = period.Substring(0, 4);
            return Convert.ToInt32(yearSr);
        }

        public int GetAndIncreaseBankStatCounter(Generator_config config)
        {
            int counter = 0;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {

                try
                {
                    connection.Open();
                    string queryString = string.Format("select counter from acrcounter where client='{0}' and column_name = 'BANK_STMT';", config.Client);
                    SqlCommand command = new SqlCommand(queryString, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        counter = Int32.Parse(reader[0].ToString());
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                }
                finally
                {
                    connection.Close();
                }
                try
                {
                    connection.Open();
                    string queryString = string.Format("UPDATE acrcounter SET counter = {1} " +
                    "where client = '{0}' and column_name = 'BANK_STMT';", config.Client, counter + 1);
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.ExecuteNonQuery();

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                }
                finally
                {
                    connection.Close();
                }
                return counter;

            }
        }


        public string GetBankStatAccount(Generator_config config)
        {
            string account = string.Empty;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {

                try
                {
                    connection.Open();
                    string queryString = string.Format("select account from ACRBANKACC where client='{0}' and bank_short='{1}' and currency = '{2}';", config.Client, config.BankName, config.Currency);
                    SqlCommand command = new SqlCommand(queryString, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        account = reader[0].ToString();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                }
                finally
                {
                    connection.Close();
                }
                return account;

            }
        }

        public void AdjustCounterOnPostingCycle(Voucher voucher)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {

                try
                {
                    connection.Open();
                    bool counterHigher = false;
                    string queryString = string.Format("select counter from acrtransgr " +
                    "where client = '{0}' and voucher_high >= {1} AND voucher_low <= {1};", voucher.Client, voucher.Voucher_no);
                    SqlCommand command = new SqlCommand(queryString, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        counterHigher = long.Parse(reader["counter"].ToString()) > voucher.Voucher_no;
                    }
                    if(!counterHigher)
                    {
                        long counter = voucher.Voucher_no + 1;
                        queryString = string.Format("UPDATE acrtransgr SET counter = {2} " +
                    "where client = '{0}' and voucher_high >= {1} AND voucher_low <= {1};", voucher.Client, voucher.Voucher_no, counter);
                        command = new SqlCommand(queryString, connection);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                }
                finally
                {
                    connection.Close();
                }

            }
        }


        public bool SetPostingCycleData(Voucher voucher)
        {
            bool isValidVoucherNo = false;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                
                try
                {
                    connection.Open();
                    string queryString = string.Format("select fiscal_year, period, trans_id from acrtransgr " +
                    "where client = '{0}' and voucher_high >= {1} AND voucher_low <= {1};", voucher.Client, voucher.Voucher_no);
                    SqlCommand command = new SqlCommand(queryString, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        voucher.Period = reader["period"].ToString();
                        voucher.FiscalYear = voucher.TransYear = GetYearPart(voucher.Period);                   
                        voucher.Trans_id = long.Parse(reader["trans_id"].ToString());
                        isValidVoucherNo = true;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                }
                finally
                {
                    connection.Close();
                }

            }
            return isValidVoucherNo;
        }

        public bool IsVoucherNoUnique(Voucher voucher, string table)
        {
            bool isUnique = false;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {

                try
                {
                    connection.Open();
                    string queryString = string.Format("select COUNT(*) from {2} " +
                    "where client = '{0}' and voucher_no = '{1}';", voucher.Client, voucher.Voucher_no, table);
                    SqlCommand command = new SqlCommand(queryString, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        isUnique = Convert.ToInt32(reader[0]) == 0;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                }
                finally
                {
                    connection.Close();
                }
                return isUnique;
            }
        }

        public static bool CheckConnection(string connectionString)
        {
            bool connectionSuccess = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                try
                {
                    connection.Open();
                    string queryString = string.Format("select COUNT(*) from acrclient");
                    SqlCommand command = new SqlCommand(queryString, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        connectionSuccess = true;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                }
                finally
                {
                    connection.Close();
                }
                return connectionSuccess;
            }
        }

        public bool InsertTransactions(List<Transaction> transactions, string table)
        {
            bool result = false;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                
                try
                {
                    connection.Open();
                    SqlCommand command = connection.CreateCommand();
                    SqlTransaction sqlTransaction = connection.BeginTransaction();
                    command.Connection = connection;
                    command.Transaction = sqlTransaction;
                    foreach (Transaction t in transactions)
                    {
                        if (t.Reconciliation)
                        {
                            command.CommandText = t.GetReconciliationSQL();
                            command.ExecuteNonQuery();
                        }
                        else
                        {
                            command.CommandText = t.GetInsertSQL(table);
                            command.ExecuteNonQuery();
                        }
                    }
                    sqlTransaction.Commit();
                    result = true;
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.StackTrace);
                }
                finally
                {
                    connection.Close();
                }
            }
            return result;


        }
    }
}
