using System;
using System.Collections.Generic;
using System.Text;

namespace TransGenerator
{
    public abstract class Voucher
    {
        /// <summary>
        /// REG or POS
        /// </summary>
        public string ImportType { get; set; }
        public long Voucher_no { get; set; }
        public Supplier Supplier { get; set; }
        public string Treat_code { get; set; }
        public string Client { get; set; }
        public int TransYear { get; set; }
        public int FiscalYear { get; set; }
        public string Currency { get; set; }
        public decimal Amount { get; set; }
        public string Period { get; set; }
        public long Trans_id { get; set; }
        public DateTime Transaction_date { get; set; }
        public string Ext_inv_ref { get; set; }

        public abstract List<Transaction> GetTransactions();

        public Transaction GetTemplate()
        {
            Transaction t = new Transaction();
            t.Supplier = Supplier;
            t.Amount = 0;
            t.Account = "";
            t.Account2 = "";
            t.Arrive_id = Voucher_no;
            t.Voucher_no = Voucher_no;
            t.Accept_status = "";
            t.Address = "";
            t.Allocation_key = 0;
            t.Arrival_date = new DateTime(TransYear, 01, 01);
            t.Att_1_id = "C1";
            t.Base_amount = 0;
            t.Base_curr = 0;
            t.Base_value_2 = 0;
            t.Base_value_3 = 0;
            t.Client = Client;
            t.Currency = Currency;
            t.Disc_percent = 0;
            t.Discount = 0;
            t.Due_date = new DateTime(TransYear, 12, 31);
            t.Exch_rate = 1;
            t.Exch_rate2 = 0;
            t.Exch_rate3 = 0;
            t.Ext_inv_ref = Ext_inv_ref;
            t.Fiscal_year = FiscalYear;
            t.Is_open_post = 0;
            t.Line_no = 0;
            t.Number_1 = 0;
            t.Order_id = 0;
            t.Orig_amount = 0;
            t.Orig_base_amount = 0;
            t.Orig_base_curr = 0;
            t.Orig_cur_amount = 0;
            t.Period = Period;
            t.Period_no = 0;
            t.Reduction = 0;
            t.Reduction_taxcode = 0;
            t.Reduction_taxsystem = 0;
            t.Rev_period = 0;
            t.Sequence_ref = 0;
            t.Sequence_ref2 = 0;
            t.Status = "N";
            t.Tax_id = 0;
            t.Tax_seq_ref = -1;
            t.Template_id = 0;
            t.Trans_id = Trans_id;
            t.Trans_date = Transaction_date;
            t.Treat_code = Treat_code;
            t.Unro_amount = 0;
            t.Unro_cur_amount = 0;
            t.User_id = "SYSEN";
            t.Value_1 = 0;
            t.Value_2 = 0;
            t.Value_3 = 0;
            t.Vat_rev_charge_amount = 0;
            t.Vat_rev_charge_curr_amt = 0;
            t.Vat_rev_charge_flag = 0;
            t.Vat_rev_charge_value_2 = 0;
            t.Vat_rev_charge_value_3 = 0;
            t.Voucher_date = Transaction_date;
            t.Voucher_ref = 0;
            t.Voucher_ref2 = 0;
            t.Tax_point_date = new DateTime(1901, 01, 01);
            t.Reduction_reductioncode = 0;

            return t;
        }

    }

    public class TaxOnlyVoucher : Voucher
    {

        public override List<Transaction> GetTransactions()
        {
            Transaction t1 = GetTemplate();
            t1.Account = "3010";
            t1.Amount = 0;
            t1.Att_1_id = "C1";
            t1.Att_2_id = "B0";
            t1.Att_4_id = "BF";
            t1.Att_5_id = "B1";
            t1.Dc_flag = 1;
            t1.Dim_1 = "100";
            t1.Dim_2 = "ABW1";
            t1.Sequence_no = 1;
            t1.Tax_code = "3N";
            t1.Tax_system = "MA";
            t1.Trans_type = "GL";
            t1.Vat_amount = Amount * -1;
            t1.Vat_pct = 100;
            t1.Voucher_type = "BI";

            Transaction t2 = GetTemplate();
            t2.Account = "1010";
            t2.Amount = Amount;
            t2.Att_1_id = "C1";
            t2.Cur_amount = Amount;
            t2.Dc_flag = 1;
            t2.Sequence_no = 2;
            t2.Tax_code = "0";
            t2.Tax_system = "";
            t2.Trans_type = "GL";
            t2.Voucher_type = "BI";
            Transaction t3 = GetTemplate();
            t3.Account = "1310";
            t3.Account2 = "3010";
            t3.Amount = Amount * -1;
            t3.Att_1_id = "C1";
            t3.Base_amount = Amount * -1;
            t3.Base_curr = Amount * -1;
            t3.Cur_amount = Amount * -1;
            t3.Dc_flag = -1;
            t3.Dim_1 = "100";
            t3.Orig_amount = Amount * -1;
            t3.Orig_base_amount = Amount * -1;
            t3.Orig_cur_amount = Amount * -1;
            t3.Reduction = 100;
            t3.Reduction_taxcode = 100;
            t3.Reduction_taxsystem = 100;
            t3.Sequence_no = 3;
            t3.Tax_code = "3N";
            t3.Tax_seq_ref = 1;
            t3.Tax_system = "MA";
            t3.Trans_type = "TX";
            t3.Vat_pct = 100;
            t3.Voucher_type = "BI";
            t3.Reduction_reductioncode = 100;

            //set proper transaction details
            var lines = new List<Transaction> { t1, t2, t3 };

            return lines;
        }




    }
}
