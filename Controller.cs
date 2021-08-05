using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransGenerator
{
    public class Controller
    {
        public VoucherGenerator Generator { get; private set; }
        public FileWriter FileWriter { get; private set; }
        public Window Window { get; private set; }
        public DatabaseHandler DBHandler { get; private set; }
        public int InsertedTransactionsCount = 0;
        public int InsertedRowsCount = 0;
        private decimal totalAmount = 0;
        private Voucher CurrentVoucherNotNull;
        public async Task<bool> Run(Generator_config config, Window window)
        {
            InsertedRowsCount = 0;
            InsertedTransactionsCount = 0;
            Generator = new VoucherGenerator(config);
            Window = window;
            DBHandler = new DatabaseHandler(config.ConnectionString);
            FileWriter = new FileWriter(Window.fileTextBox.Text);
            var table = config.Table;
            while (true)
            {
                var curr = Generator.GetNextVoucher(config.VoucherType);
                if (curr == null) break;
                CurrentVoucherNotNull = curr;
                var isValidVoucherNo = DBHandler.SetPostingCycleData(curr);
                if(!isValidVoucherNo)
                {
                    Console.WriteLine(String.Format("Voucher_no {0} does not belong to a valid posting cycle.", curr.Voucher_no));
                    continue;
                }
                CurrentVoucherNotNull = curr;
                curr.Transaction_date = new DateTime(Generator.GetYearPart(curr.Period), Generator.GetMonthPart(curr.Period), 1);
                var voucherRows = curr.GetTransactions();
                if (config.CashBook)
                {
                    string account = DBHandler.GetBankStatAccount(config);
                    voucherRows.Add(curr.GetCashbookTransaction(account, config));
                }
                if (config.BankStatement) totalAmount += curr.Amount;
                bool isVoucherNoUnique = DBHandler.IsVoucherNoUnique(curr, table);
                if (isVoucherNoUnique && !config.FileMode)
                {
                    if(DBHandler.InsertTransactions(voucherRows, table))
                    {
                        InsertedTransactionsCount++;
                        InsertedRowsCount += voucherRows.Count;
                    }
                    
                }
                else if(config.FileMode)
                {
                    FileWriter.AddInsertStatements(voucherRows, table);
                    InsertedTransactionsCount++;
                    InsertedRowsCount += voucherRows.Count;
                }

                Window.SetStatus(Tuple.Create(InsertedTransactionsCount, InsertedRowsCount));
                
            }
            if (!config.FileMode)
            {
                DBHandler.AdjustCounterOnPostingCycle(CurrentVoucherNotNull);
                if(config.BankStatement)
                {
                    var statements = GetBankStatements(config);
                    DBHandler.InsertTransactions(statements, "acbbankrec");
                }
            }
            if (config.FileMode)
            {
                if (config.BankStatement)
                {
                    var statements = GetBankStatements(config);
                    FileWriter.AddInsertStatements(statements, "acbbankrec");
                }
                FileWriter.SaveFile();
            }

            return true;
        }

        private List<Transaction> GetBankStatements(Generator_config config)
        {
            var results = new List<Transaction>();
            decimal approxStatementValue = totalAmount / config.BankStatementLines;
            string account = DBHandler.GetBankStatAccount(config);
            int i = 1;
            while(i <= config.BankStatementLines)
            {
                totalAmount -= approxStatementValue;
                Transaction statement = new Transaction();
                statement.Reconciliation = true;
                statement.Account = account;
                statement.Amount = approxStatementValue;
                statement.Att_1_id = "C1";
                statement.Bank_curr = config.Currency;
                statement.Bank_curr_amt = approxStatementValue;
                statement.Bank_short = config.BankName;
                statement.Client = config.Client;
                statement.Cur_amount = approxStatementValue;
                statement.Currency = config.Currency;
                statement.Dc_flag = -1;
                statement.Description = "Bank statement " + i;
                statement.Dim_1 = "";
                statement.Exch_rate = 0;
                statement.Fiscal_year = 0;
                statement.Match_id = 0;
                statement.Pay_method = "CH";
                statement.Period = "0";
                statement.Reconcile_id = 0;
                statement.Sequence_no = DBHandler.GetAndIncreaseBankStatCounter(config);
                statement.Status = "N";
                statement.Tax_code = "";
                statement.Trans_date = new DateTime(CurrentVoucherNotNull.Transaction_date.Year, CurrentVoucherNotNull.Transaction_date.Month, 28);
                statement.Type = "S";
                statement.User_id = "SYSEN";
                statement.Voucher_date = statement.Trans_date;
                statement.Voucher_no = 0;
                statement.Voucher_type = "";
                results.Add(statement);
                i++;
            }

            return results;
        }
    }
}
