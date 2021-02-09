using System;
using System.Collections.Generic;
using System.Text;

namespace TransGenerator
{
    public class VoucherGenerator
    {
        private readonly Generator_config Config;
        private int _voucher_no_curr;
        private int PopVoucherNo()
        {
            if (_voucher_no_curr > Config.Voucher_no_max) return -1;
            int curr = _voucher_no_curr;
            _voucher_no_curr++;
            return curr;
        }

        private int GetRandomAmountInRange()
        {
            Random rand = new Random();
            return rand.Next(Decimal.ToInt32(Config.MinAmountAbs), Decimal.ToInt32(Config.MaxAmountAbs));
        }

        private Supplier GetRandomSupplier()
        {
            //TODO
            return new Supplier
            {
                apar_id = 1000,
                apar_name = "Max Pescatori1000",
                apar_type = "P",
                Vat_reg_no = 123456789
            };
        }
        public int GetYearPart(string period)
        {
            string yearStr = period.Substring(0, 4);
            return Convert.ToInt32(yearStr);
        }
        public int GetMonthPart(string period)
        {
            string monthStr = period.Substring(4, 2);
            return Convert.ToInt32(monthStr);
        }
        /*private List<string> GetValidPeriods()
        {
            var validPeriods = new List<string>();
            string curr = Config.Period_min;
            validPeriods.Add(curr);
            while (!curr.Equals(Config.Period_max))
            {
                int yearPart = Convert.ToInt32(curr.Substring(0, 4));
                int monthPart = Convert.ToInt32(curr.Substring(4, 2));
                if (monthPart < 12) monthPart++;
                else
                {
                    yearPart++;
                    monthPart = 1;
                }
                string monthPartStr = monthPart < 10 ? String.Concat("0", monthPart) : monthPart.ToString();
                curr = String.Concat(yearPart, monthPartStr);
                validPeriods.Add(curr);
            }
            return validPeriods;
        }*/ //deprecated

        public Voucher GetNextVoucher<T>() where T : Voucher
        {
            var voucher = Activator.CreateInstance(typeof(T)) as Voucher;
            voucher.Client = Config.Client;
            voucher.Voucher_no = PopVoucherNo();
            if (voucher.Voucher_no == -1) return null;
            voucher.Supplier = GetRandomSupplier();
            voucher.Currency = Config.Currency; 
            voucher.ImportType = Config.ImportType;
            voucher.Treat_code = Config.Treatment_code;
            voucher.Ext_inv_ref = "Invoice " + voucher.Voucher_no;
            voucher.Amount = GetRandomAmountInRange();
            return voucher;
        }

        public VoucherGenerator(Generator_config config)
        {
            Config = config;
            _voucher_no_curr = Config.Voucher_no_min;
        }



    }
    public class Generator_config
    {
        public int Voucher_no_min { get; set; }
        public int Voucher_no_max { get; set; }
        public decimal MinAmountAbs { get; set; }
        public decimal MaxAmountAbs { get; set; }
        public string Currency { get; set; }
        public string Client { get; set; }
        /// <summary>
        /// REG / POS
        /// </summary>
        public string ImportType { get; set; }
        public string ConnectionString { get; set; }
        public string Treatment_code { get; set; }

    }
}
