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
                        voucher.FiscalYear = voucher.TransYear = Convert.ToInt32(reader["fiscal_year"]);
                        voucher.Period = reader["period"].ToString();
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

        public bool IsVoucherNoUnique(Voucher voucher)
        {
            bool isUnique = false;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {

                try
                {
                    connection.Open();
                    string queryString = string.Format("select COUNT(*) from acrtrans " +
                    "where client = '{0}' and voucher_no = '{1}';", voucher.Client, voucher.Voucher_no);
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

        public void InsertTransactions(List<Transaction> transactions, string table)
        {
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
                        command.CommandText = t.GetInsertSQL(table);
                        command.ExecuteNonQuery();
                    }
                    sqlTransaction.Commit();
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


        }
    }
}
