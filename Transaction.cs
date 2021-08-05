using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace TransGenerator
{
    public class Transaction
    {
        #region members
        public string Description { get; set; }
        public string Ext_ref { get; set; }

        public bool Reconciliation { get; set; }
        public string Bank_curr { get; set; }
        public decimal Bank_curr_amt { get; set; }
        public string Bank_short { get; set; }
        public int Match_id { get; set; }
        public int Reconcile_id { get; set; }
        public string Type { get; set; }

        public string Accept_status { get; set; }
        public string Account { get; set; }
        public string Account2 { get; set; }
        public string Address { get; set; }
        public int Allocation_key { get; set; }
        public decimal Amount { get; set; }
        public Supplier Supplier { get; set; }
        public DateTime Arrival_date { get; set; }
        public long Arrive_id { get; set; }
        public string Att_1_id { get; set; }
        public string Att_2_id { get; set; }
        public string Att_3_id { get; set; }
        public string Att_4_id { get; set; }
        public string Att_5_id { get; set; }
        public string Att_6_id { get; set; }
        public string Att_7_id { get; set; }
        public long Bank_Account { get; set; }
        public decimal Base_amount { get; set; }
        public decimal Base_curr { get; set; }
        public decimal Base_value_2 { get; set; }
        public decimal Base_value_3 { get; set; }
        public string Client { get; set; }
        public decimal Cur_amount { get; set; }
        public string Currency { get; set; }
        public int Dc_flag { get; set; }
        public string Dim_1 { get; set; }
        public string Dim_2 { get; set; }
        public string Dim_3 { get; set; }
        public string Dim_4 { get; set; }
        public string Dim_5 { get; set; }
        public string Dim_6 { get; set; }
        public string Dim_7 { get; set; }
        public decimal Disc_percent { get; set; }
        public decimal Discount { get; set; }
        public DateTime Due_date { get; set; }
        public decimal Exch_rate { get; set; }
        public decimal Exch_rate2 { get; set; }
        public decimal Exch_rate3 { get; set; }
        public string Ext_inv_ref { get; set; }
        public int Fiscal_year { get; set; }
        public int Inv_arr_seq { get; set; }
        public int Is_open_post { get; set; }
        public int Line_no { get; set; }
        public int Number_1 { get; set; }
        public int Order_id { get; set; }
        public string Pay_currency { get; set; }
        public string Pay_method { get; set; }
        public string Period { get; set; }
        public int Period_no { get; set; }
        public int Po_flag { get; set; }
        public decimal Reduction { get; set; }
        public decimal Reduction_taxcode { get; set; }
        public decimal Reduction_taxsystem { get; set; }
        public decimal Reg_amount { get; set; }
        public int Rev_period { get; set; }
        public int Sequence_no { get; set; }
        public int Sequence_ref { get; set; }
        public int Sequence_ref2 { get; set; }
        public String Status { get; set; }
        public string Tax_code { get; set; }
        public int Tax_id { get; set; }
        public int Tax_seq_ref { get; set; }
        public string Tax_system { get; set; }
        public int Template_id { get; set; }
        public DateTime Trans_date { get; set; }
        public long Trans_id { get; set; }
        public string Trans_type { get; set; }
        public string Treat_code { get; set; }
        public decimal Unro_amount { get; set; }

        public decimal Unro_cur_amount { get; set; }
        public string User_id { get; set; }
        public decimal Value_1 { get; set; }
        public decimal Value_2 { get; set; }
        public decimal Value_3 { get; set; }
        public decimal Vat_amount { get; set; }
        public int Vat_non_recoverable_flag { get; set; }
        public decimal Vat_pct { get; set; }
        public decimal Vat_rev_charge_amount { get; set; }
        public decimal Vat_rev_charge_curr_amt { get; set; }
        public int Vat_rev_charge_flag { get; set; }
        public decimal Vat_rev_charge_value_2 { get; set; }
        public decimal Vat_rev_charge_value_3 { get; set; }
        public DateTime Voucher_date { get; set; }
        public long Voucher_no { get; set; }
        public int Voucher_ref { get; set; }
        public int Voucher_ref2 { get; set; }
        public string Voucher_type { get; set; }
        public string Wf_state { get; set; }
        public DateTime Tax_point_date { get; set; }
        public decimal Reduction_reductioncode { get; set; }
        public decimal Orig_amount { get; set; }
        public decimal Orig_base_amount { get; set; }
        public decimal Orig_base_curr { get; set; }
        public decimal Orig_cur_amount { get; set; }
        public decimal Orig_base_value_2 { get; set; }
        public decimal Orig_base_value_3 { get; set; }
        public decimal Orig_value_2 { get; set; }
        public decimal Orig_value_3 { get; set; }

        #endregion

        #region methods
        private string GetStringFormat(decimal member)
        {
            if (member != 0)
            {
                string specifier = "F";
                CultureInfo culture = CultureInfo.CreateSpecificCulture("en-CA");               
                return Math.Round(member, 4).ToString(specifier, culture);
            }
            else return "0";
        }
        #endregion

        public string GetInsertSQL(string table)
        {
            if (table.Equals("acrtrans"))
            {
                var sb = new StringBuilder(String.Format("INSERT INTO {0} (", table));
                try
                {
                    sb.Append("account, account2, allocation_key, amount, apar_id, apar_name, apar_type, arrival_date, arrive_id, ");
                    sb.Append("att_1_id, att_2_id, att_3_id, att_4_id, att_5_id, att_6_id, att_7_id, bank_account, ");
                    sb.Append("base_amount, base_curr, base_value_2, base_value_3, client, collection, ");
                    sb.Append("compress_flag, cur_amount, currency, dc_flag, ");
                    sb.Append("dim_1, dim_2, dim_3, dim_4, dim_5, dim_6, dim_7, ");
                    sb.Append("disc_percent, discount, due_date, exch_rate, exch_rate2, exch_rate3, ext_inv_ref, ");
                    sb.Append("final_invoice, fiscal_year, header_flag, inv_arr_seq, is_open_post, line_no, number_1, order_id, ");
                    sb.Append("orig_amount, orig_base_amount, orig_base_curr, orig_base_value_2, orig_base_value_3, orig_cur_amount, ");
                    sb.Append("orig_reference, orig_value_2, orig_value_3, part_pay_flag, pay_currency, pay_flag, pay_method, ");
                    sb.Append("pay_plan_id, pay_plan_id_ref, period, period_no,po_flag, reduction, reduction_taxcode, reduction_taxsystem, ");
                    sb.Append("reg_amount, rev_period, sequence_no, sequence_ref, sequence_ref2, status, ");
                    sb.Append("stop_trig, tax_amend_flag, tax_code, tax_id, tax_seq_ref, tax_system, ");
                    sb.Append("template_id, trans_date, trans_id, trans_type, treat_code, unro_amount, unro_cur_amount, ");
                    sb.Append("user_id, value_1, value_2, value_3, vat_amount, vat_non_recoverable_flag, vat_pct, vat_reg_no, ");
                    sb.Append("vat_rev_charge_amount, vat_rev_charge_curr_amt, vat_rev_charge_flag, vat_rev_charge_value_2, vat_rev_charge_value_3, ");
                    sb.Append("voucher_date, voucher_no, voucher_ref, voucher_ref2, voucher_type, wf_state, tax_point_date, reduction_reductioncode) ");
                    sb.Append("VALUES (");
                    sb.Append(string.Format("'{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}',",
                        Account, Account2, Allocation_key, GetStringFormat(Amount), Supplier.apar_id, Supplier.apar_name, Supplier.apar_type, Arrival_date.ToString("yyyy/MM/dd"), Arrive_id));
                    sb.Append(string.Format("'{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}',",
                        Att_1_id, Att_2_id, Att_3_id, Att_4_id, Att_5_id, Att_6_id, Att_7_id, Bank_Account));
                    sb.Append(string.Format("'{0}', '{1}', '{2}', '{3}', '{4}', '{5}',",
                        GetStringFormat(Base_amount), GetStringFormat(Base_curr), GetStringFormat(Base_value_2), GetStringFormat(Base_value_3), Client, 0));
                    sb.Append(string.Format("'{0}', '{1}', '{2}', '{3}',",
                        0, GetStringFormat(Cur_amount), Currency, Dc_flag));
                    sb.Append(string.Format("'{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}',",
                        Dim_1, Dim_2, Dim_3, Dim_4, Dim_5, Dim_6, Dim_7));
                    sb.Append(string.Format("'{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}',",
                        GetStringFormat(Disc_percent), GetStringFormat(Discount), Due_date.ToString("yyyy/MM/dd"), GetStringFormat(Exch_rate), GetStringFormat(Exch_rate2), GetStringFormat(Exch_rate3), Ext_inv_ref));
                    sb.Append(string.Format("'{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}',",
                        0, Fiscal_year, 0, Inv_arr_seq, Is_open_post, Line_no, Number_1, Order_id));
                    sb.Append(string.Format("'{0}', '{1}', '{2}', '{3}', '{4}', '{5}',",
                        GetStringFormat(Orig_amount), GetStringFormat(Orig_base_amount), GetStringFormat(Orig_base_curr), GetStringFormat(Orig_base_value_2), GetStringFormat(Orig_base_value_3), GetStringFormat(Orig_cur_amount)));
                    sb.Append(string.Format("'{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}',",
                        0, GetStringFormat(Orig_value_2), GetStringFormat(Orig_value_3), 0, Pay_currency, 0, Pay_method));
                    sb.Append(string.Format("'{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}',",
                        0, 0, Period, Period_no, Po_flag, GetStringFormat(Reduction), GetStringFormat(Reduction_taxcode), GetStringFormat(Reduction_taxsystem)));
                    sb.Append(string.Format("'{0}', '{1}', '{2}', '{3}', '{4}', '{5}',",
                        GetStringFormat(Reg_amount), Rev_period, Sequence_no, Sequence_ref, Sequence_ref2, Status));
                    sb.Append(string.Format("'{0}', '{1}', '{2}', '{3}', '{4}', '{5}',",
                        0, 0, Tax_code, Tax_id, Tax_seq_ref, Tax_system));
                    sb.Append(string.Format("'{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', ",
                        Template_id, Trans_date.ToString("yyyy/MM/dd"), Trans_id, Trans_type, Treat_code, GetStringFormat(Unro_amount), GetStringFormat(Unro_cur_amount)));
                    sb.Append(string.Format("'{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}',",
                        User_id, GetStringFormat(Value_1), GetStringFormat(Value_2), GetStringFormat(Value_3), GetStringFormat(Vat_amount), Vat_non_recoverable_flag, GetStringFormat(Vat_pct), Supplier.Vat_reg_no));
                    sb.Append(string.Format("'{0}', '{1}', '{2}', '{3}', '{4}', ",
                        GetStringFormat(Vat_rev_charge_amount), GetStringFormat(Vat_rev_charge_curr_amt), Vat_rev_charge_flag, GetStringFormat(Vat_rev_charge_value_2), GetStringFormat(Vat_rev_charge_value_3)));
                    sb.Append(string.Format("'{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}');",
                        Voucher_date.ToString("yyyy/MM/dd"), Voucher_no, Voucher_ref, Voucher_ref2, Voucher_type, Wf_state, Tax_point_date.ToString("yyyy/MM/dd"), GetStringFormat(Reduction_reductioncode)));
                    return sb.ToString();
                }
                catch (FormatException e)
                {
                    return "ERROR\n" + e.ToString();
                }
            }
            else
            {
                var sb = new StringBuilder(String.Format("INSERT INTO {0} (", table));
                try
                {
                    sb.Append("account, amount, apar_id, apar_type, ");
                    sb.Append("att_1_id, client, cur_amount, currency, dc_flag, ");
                    sb.Append("description, dim_1, ext_ref, fiscal_year, last_update, ");
                    sb.Append("line_no, number_1, order_id, period, sequence_no, ");
                    sb.Append("status, tax_code, trans_date, trans_id, unro_amount, ");
                    sb.Append("unro_cur_amount, update_flag, user_id, value_1, value_2, ");
                    sb.Append("value_3, voucher_date, voucher_no, voucher_type, reduction_code)");
                    sb.Append("VALUES (");
                    sb.Append(string.Format("'{0}', '{1}', '{2}', '{3}',",
                        Account, GetStringFormat(Amount), Supplier.apar_id, Supplier.apar_type));
                    sb.Append(string.Format("'{0}', '{1}', '{2}', '{3}', '{4}',",
                        Att_1_id, Client, GetStringFormat(Cur_amount), Currency, Dc_flag));
                    sb.Append(string.Format("'{0}', '{1}', '{2}', '{3}', '{4}',",
                        Description, Dim_1, Ext_ref, Fiscal_year, Voucher_date.ToString("yyyy/MM/dd")));
                    sb.Append(string.Format("'{0}', '{1}', '{2}', '{3}', '{4}',",
                        0, 0, 0, Period, Sequence_no));
                    sb.Append(string.Format("'{0}', '{1}', '{2}', '{3}', '{4}',",
                        "N", Tax_code, Voucher_date.ToString("yyyy/MM/dd"), Trans_id, GetStringFormat(Unro_amount)));
                    sb.Append(string.Format("'{0}', '{1}', '{2}', '{3}', '{4}',",
                        GetStringFormat(Unro_cur_amount), 0, "SYSEN", GetStringFormat(Value_1), GetStringFormat(Value_2)));
                    sb.Append(string.Format("'{0}', '{1}', '{2}', '{3}', '{4}');",
                        GetStringFormat(Value_3), Voucher_date.ToString("yyyy/MM/dd"), Voucher_no, Voucher_type, 0));
                    return sb.ToString();
                }
                catch (FormatException e)
                {
                    return "ERROR\n" + e.ToString();
                }
            }
        }

        public string GetInsertASQ(string table)
        {
            if (table.Equals("acrtrans"))
            {
                var sb = new StringBuilder();
                try
                {
                    sb.AppendLine(String.Format("INSERT INTO {0}", table));
                    sb.Append("(account, account2, allocation_key, amount, apar_id, apar_name, apar_type, arrival_date, arrive_id, ");
                    sb.Append("att_1_id, att_2_id, att_3_id, att_4_id, att_5_id, att_6_id, att_7_id, bank_account, ");
                    sb.Append("base_amount, base_curr, base_value_2, base_value_3, client, collection, ");
                    sb.Append("compress_flag, cur_amount, currency, dc_flag, ");
                    sb.Append("dim_1, dim_2, dim_3, dim_4, dim_5, dim_6, dim_7, ");
                    sb.Append("disc_percent, discount, due_date, exch_rate, exch_rate2, exch_rate3, ext_inv_ref, ");
                    sb.Append("final_invoice, fiscal_year, header_flag, inv_arr_seq, is_open_post, line_no, number_1, order_id, ");
                    sb.Append("orig_amount, orig_base_amount, orig_base_curr, orig_base_value_2, orig_base_value_3, orig_cur_amount, ");
                    sb.Append("orig_reference, orig_value_2, orig_value_3, part_pay_flag, pay_currency, pay_flag, pay_method, ");
                    sb.Append("pay_plan_id, pay_plan_id_ref, period, period_no, po_flag, reduction, reduction_taxcode, reduction_taxsystem, ");
                    sb.Append("reg_amount, rev_period, sequence_no, sequence_ref, sequence_ref2, status, ");
                    sb.Append("stop_trig, tax_amend_flag, tax_code, tax_id, tax_seq_ref, tax_system, ");
                    sb.Append("template_id, trans_date, trans_id, trans_type, treat_code, unro_amount, unro_cur_amount, ");
                    sb.Append("user_id, value_1, value_2, value_3, vat_amount, vat_non_recoverable_flag, vat_pct, vat_reg_no, ");
                    sb.Append("vat_rev_charge_amount, vat_rev_charge_curr_amt, vat_rev_charge_flag, vat_rev_charge_value_2, vat_rev_charge_value_3, ");
                    sb.AppendLine("voucher_date, voucher_no, voucher_ref, voucher_ref2, voucher_type, wf_state, tax_point_date, reduction_reductioncode) ");
                    sb.AppendLine("VALUES");
                    sb.Append(string.Format("('{0}', '{1}', '{2}', {3}, '{4}', '{5}', '{6}', {7}, '{8}',",
                        Account, Account2, Allocation_key, GetStringFormat(Amount), Supplier.apar_id, Supplier.apar_name, Supplier.apar_type, string.Format("CTS2DAY('{0}')", Arrival_date.ToString("yyyyMMdd")), Arrive_id));
                    sb.Append(string.Format("'{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}',",
                        Att_1_id, Att_2_id, Att_3_id, Att_4_id, Att_5_id, Att_6_id, Att_7_id, Bank_Account));
                    sb.Append(string.Format("{0}, {1}, {2}, {3}, '{4}', '{5}',",
                        GetStringFormat(Base_amount), GetStringFormat(Base_curr), GetStringFormat(Base_value_2), GetStringFormat(Base_value_3), Client, 0));
                    sb.Append(string.Format("{0}, {1}, '{2}', '{3}',",
                        0, GetStringFormat(Cur_amount), Currency, Dc_flag));
                    sb.Append(string.Format("'{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}',",
                        Dim_1, Dim_2, Dim_3, Dim_4, Dim_5, Dim_6, Dim_7));
                    sb.Append(string.Format("{0}, {1}, {2}, {3}, {4}, {5}, '{6}',",
                        GetStringFormat(Disc_percent), GetStringFormat(Discount), string.Format("CTS2DAY('{0}')", Due_date.ToString("yyyyMMdd")), GetStringFormat(Exch_rate), GetStringFormat(Exch_rate2), GetStringFormat(Exch_rate3), Ext_inv_ref));
                    sb.Append(string.Format("{0}, '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}',",
                        0, Fiscal_year, 0, Inv_arr_seq, Is_open_post, Line_no, Number_1, Order_id));
                    sb.Append(string.Format("{0}, {1}, {2}, {3}, {4}, {5},",
                        GetStringFormat(Orig_amount), GetStringFormat(Orig_base_amount), GetStringFormat(Orig_base_curr), GetStringFormat(Orig_base_value_2), GetStringFormat(Orig_base_value_3), GetStringFormat(Orig_cur_amount)));
                    sb.Append(string.Format("{0}, {1}, {2}, {3}, '{4}', {5}, '{6}',",
                        0, GetStringFormat(Orig_value_2), GetStringFormat(Orig_value_3), 0, Pay_currency, 0, Pay_method));
                    sb.Append(string.Format("{0}, {1}, '{2}', {3}, {4}, {5}, {6}, {7},",
                        0, 0, Period, Period_no, Po_flag, GetStringFormat(Reduction), GetStringFormat(Reduction_taxcode), GetStringFormat(Reduction_taxsystem)));
                    sb.Append(string.Format("{0}, '{1}', {2}, '{3}', '{4}', '{5}',",
                        GetStringFormat(Reg_amount), Rev_period, Sequence_no, Sequence_ref, Sequence_ref2, Status));
                    sb.Append(string.Format("{0}, {1}, '{2}', '{3}', '{4}', '{5}',",
                        0, 0, Tax_code, Tax_id, Tax_seq_ref, Tax_system));
                    sb.Append(string.Format("'{0}', {1}, '{2}', '{3}', '{4}', {5}, {6}, ",
                        Template_id, string.Format("CTS2DAY('{0}')", Trans_date.ToString("yyyyMMdd")), Trans_id, Trans_type, Treat_code, GetStringFormat(Unro_amount), GetStringFormat(Unro_cur_amount)));
                    sb.Append(string.Format("'{0}', {1}, {2}, {3}, {4}, '{5}', {6}, '{7}',",
                        User_id, GetStringFormat(Value_1), GetStringFormat(Value_2), GetStringFormat(Value_3), GetStringFormat(Vat_amount), Vat_non_recoverable_flag, GetStringFormat(Vat_pct), Supplier.Vat_reg_no));
                    sb.Append(string.Format("{0}, {1}, {2}, {3}, {4}, ",
                        GetStringFormat(Vat_rev_charge_amount), GetStringFormat(Vat_rev_charge_curr_amt), Vat_rev_charge_flag, GetStringFormat(Vat_rev_charge_value_2), GetStringFormat(Vat_rev_charge_value_3)));
                    sb.Append(string.Format("{0}, '{1}', '{2}', '{3}', '{4}', '{5}', {6}, {7})",
                        string.Format("CTS2DAY('{0}')", Voucher_date.ToString("yyyyMMdd")), Voucher_no, Voucher_ref, Voucher_ref2, Voucher_type, Wf_state, string.Format("CTS2DAY('{0}')", Tax_point_date.ToString("yyyyMMdd")), GetStringFormat(Reduction_reductioncode)));
                    return sb.ToString();
                }
                catch (FormatException e)
                {
                    return "ERROR\n" + e.ToString();
                }
            }
            else
            {
                var sb = new StringBuilder(String.Format("INSERT INTO {0} (", table));
                try
                {
                    sb.Append("account, amount, apar_id, apar_type, ");
                    sb.Append("att_1_id, client, cur_amount, currency, dc_flag, ");
                    sb.Append("description, dim_1, ext_ref, fiscal_year, last_update, ");
                    sb.Append("line_no, number_1, order_id, period, sequence_no, ");
                    sb.Append("status, tax_code, trans_date, trans_id, unro_amount, ");
                    sb.Append("unro_cur_amount, update_flag, user_id, value_1, value_2, ");
                    sb.Append("value_3, voucher_date, voucher_no, voucher_type, reduction_code)");
                    sb.Append("VALUES (");
                    sb.Append(string.Format("'{0}', '{1}', '{2}', '{3}',",
                        Account, GetStringFormat(Amount), Supplier.apar_id, Supplier.apar_type));
                    sb.Append(string.Format("'{0}', '{1}', '{2}', '{3}', '{4}',",
                        Att_1_id, Client, GetStringFormat(Cur_amount), Currency, Dc_flag));
                    sb.Append(string.Format("'{0}', '{1}', '{2}', '{3}', {4},",
                        Description, Dim_1, Ext_ref, Fiscal_year, string.Format("CTS2DAY('{0}')", Voucher_date.ToString("yyyyMMdd"))));
                    sb.Append(string.Format("'{0}', '{1}', '{2}', '{3}', '{4}',",
                        0, 0, 0, Period, Sequence_no));
                    sb.Append(string.Format("'{0}', '{1}', {2}, '{3}', '{4}',",
                        "N", Tax_code, string.Format("CTS2DAY('{0}')", Voucher_date.ToString("yyyyMMdd")), Trans_id, GetStringFormat(Unro_amount)));
                    sb.Append(string.Format("'{0}', '{1}', '{2}', '{3}', '{4}',",
                        GetStringFormat(Unro_cur_amount), 0, "SYSEN", GetStringFormat(Value_1), GetStringFormat(Value_2)));
                    sb.Append(string.Format("'{0}', {1}, '{2}', '{3}', '{4}')",
                        GetStringFormat(Value_3), string.Format("CTS2DAY('{0}')", Voucher_date.ToString("yyyyMMdd")), Voucher_no, Voucher_type, 0));
                    return sb.ToString();
                }
                catch (FormatException e)
                {
                    return "ERROR\n" + e.ToString();
                }
            }
        }

        public string GetReconciliationASQ()
        {
            var sb = new StringBuilder(String.Format("INSERT INTO {0} (", "acbbankrec"));
            try
            {
                sb.Append("accept_flag, account, amount, att_1_id, bank_curr, ");
                sb.Append("Bank_curr_amt, Bank_short, Client, Cur_amount, Currency, ");
                sb.Append("Dc_flag, Description, Exch_rate, Ext_inv_ref, fiscal_year, ");
                sb.Append("fix_id, last_update, match_id, pay_method, period, ");
                sb.Append("reconcile_id, returned_chq, sequence_no, status, tax_code, ");
                sb.Append("trans_date, type, user_id, voucher_date, voucher_no, ");
                sb.Append("voucher_type, dim_1)");
                sb.Append("VALUES (");
                sb.Append(string.Format("'{0}', '{1}', '{2}', '{3}', '{4}', ",
                    0, Account, GetStringFormat(Amount), Att_1_id, Bank_curr));
                sb.Append(string.Format("'{0}', '{1}', '{2}', '{3}', '{4}',",
                    GetStringFormat(Bank_curr_amt), Bank_short, Client, GetStringFormat(Cur_amount), Currency));
                sb.Append(string.Format("'{0}', '{1}', '{2}', '{3}', '{4}',",
                    Dc_flag, Description, GetStringFormat(Exch_rate), Ext_inv_ref, Fiscal_year));
                sb.Append(string.Format("'{0}', {1}, '{2}', '{3}', '{4}',",
                    0, string.Format("CTS2DAY('{0}')", Voucher_date.ToString("yyyyMMdd")), Match_id, Pay_method, Period));
                sb.Append(string.Format("'{0}', '{1}', '{2}', '{3}', '{4}',",
                    Reconcile_id, 0, Sequence_no, "N", Tax_code));
                sb.Append(string.Format("{0}, '{1}', '{2}', {3}, '{4}',",
                    string.Format("CTS2DAY('{0}')", Trans_date.ToString("yyyyMMdd")), Type, User_id, string.Format("CTS2DAY('{0}')", Voucher_date.ToString("yyyyMMdd")), Voucher_no));
                sb.Append(string.Format("'{0}', '{1}')",
                    Voucher_type, Dim_1));

                return sb.ToString();
            }
            catch (FormatException e)
            {
                return "ERROR\n" + e.ToString();
            }
        }

        public string GetReconciliationSQL()
        {
            var sb = new StringBuilder(String.Format("INSERT INTO {0} (", "acbbankrec"));
            try
            {
                sb.Append("accept_flag, account, amount, att_1_id, bank_curr, ");
                sb.Append("Bank_curr_amt, Bank_short, Client, Cur_amount, Currency, ");
                sb.Append("Dc_flag, Description, Exch_rate, Ext_inv_ref, fiscal_year, ");
                sb.Append("fix_id, last_update, match_id, pay_method, period, ");
                sb.Append("reconcile_id, returned_chq, sequence_no, status, tax_code, ");
                sb.Append("trans_date, type, user_id, voucher_date, voucher_no, ");
                sb.Append("voucher_type, dim_1)");
                sb.Append("VALUES (");
                sb.Append(string.Format("'{0}', '{1}', '{2}', '{3}', '{4}', ",
                    0, Account, GetStringFormat(Amount), Att_1_id, Bank_curr));
                sb.Append(string.Format("'{0}', '{1}', '{2}', '{3}', '{4}',",
                    GetStringFormat(Bank_curr_amt), Bank_short, Client, GetStringFormat(Cur_amount), Currency));
                sb.Append(string.Format("'{0}', '{1}', '{2}', '{3}', '{4}',",
                    Dc_flag, Description, GetStringFormat(Exch_rate), Ext_inv_ref, Fiscal_year));
                sb.Append(string.Format("'{0}', '{1}', '{2}', '{3}', '{4}',",
                    0, Voucher_date.ToString("yyyy/MM/dd"), Match_id, Pay_method, Period));
                sb.Append(string.Format("'{0}', '{1}', '{2}', '{3}', '{4}',",
                    Reconcile_id, 0, Sequence_no, "N", Tax_code));
                sb.Append(string.Format("'{0}', '{1}', '{2}', '{3}', '{4}',",
                    Trans_date.ToString("yyyy/MM/dd"), Type, User_id, Voucher_date.ToString("yyyy/MM/dd"), Voucher_no));
                sb.Append(string.Format("'{0}', '{1}')",
                    Voucher_type, Dim_1));

                return sb.ToString();
            }
            catch (FormatException e)
            {
                return "ERROR\n" + e.ToString();
            }
        }


    }
}
