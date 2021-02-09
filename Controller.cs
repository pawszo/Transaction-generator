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
        public Window Window { get; private set; }
        public DatabaseHandler DBHandler { get; private set; }
        public int InsertedTransactionsCount = 0;
        public int InsertedRowsCount = 0;
        public async Task<bool> Run(Generator_config config, Window window)
        {
            Generator = new VoucherGenerator(config);
            Window = window;
            DBHandler = new DatabaseHandler(config.ConnectionString);
            while (true)
            {
                var curr = Generator.GetNextVoucher<TaxOnlyVoucher>();
                if (curr == null) break;
                var isValidVoucherNo = DBHandler.SetPostingCycleData(curr);
                if(!isValidVoucherNo)
                {
                    Console.WriteLine(String.Format("Voucher_no {0} does not belong to a valid posting cycle.", curr.Voucher_no));
                    continue;
                }
                curr.Transaction_date = new DateTime(Generator.GetYearPart(curr.Period), Generator.GetMonthPart(curr.Period), 1);
                var voucherRows = curr.GetTransactions();
                bool isVoucherNoUnique = DBHandler.IsVoucherNoUnique(curr);
                if (isVoucherNoUnique)
                {
                    DBHandler.InsertTransactions(voucherRows, "acrtrans");
                    InsertedTransactionsCount++;
                    InsertedRowsCount += voucherRows.Count;
                    Window.SetStatus(Tuple.Create(InsertedTransactionsCount, InsertedRowsCount));
                }
            }

            return true;
        }
    }
}
