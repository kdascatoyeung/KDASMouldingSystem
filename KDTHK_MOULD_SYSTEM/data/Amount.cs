using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KDTHK_MOULD_SYSTEM.services;

namespace KDTHK_MOULD_SYSTEM.data
{
    public class Amount
    {
        public static decimal AmountWithRate(string currency, string amount)
        {
            int year;
            int month = Convert.ToInt32(DateTime.Today.Month);

            if (month >= 4)
                year = Convert.ToInt32(DateTime.Today.AddYears(1).Year);
            else
                year = Convert.ToInt32(DateTime.Today.Year);

            double usdRate = 0, jpyRate = 0, rmbRate = 0;

            string query = string.Format("select r_usd, r_jpy, r_rmb from TB_RATE where r_year = '{0}'", year);

            using (GlobalService.Reader = DataService.GetInstance().ExecuteReader(query))
            {
                while (GlobalService.Reader.Read())
                {
                    usdRate = Convert.ToDouble(GlobalService.Reader.GetString(0));
                    jpyRate = Convert.ToDouble(GlobalService.Reader.GetString(1));
                    rmbRate = Convert.ToDouble(GlobalService.Reader.GetString(2));
                }
            }

            decimal tmpAmount = 0;

            try
            {
                tmpAmount = Convert.ToDecimal(amount);
            }
            catch
            {
                tmpAmount = 0;
            }

            decimal calAmount = 0;

            if (currency == "HKD")
                calAmount = tmpAmount;
            if (currency == "USD")
                calAmount = tmpAmount * (decimal)usdRate;
            if (currency == "JPY")
                calAmount = tmpAmount * (decimal)jpyRate;
            if (currency == "RMB")
                calAmount = tmpAmount * (decimal)rmbRate;

            return calAmount;
        }

        public static decimal GetMpUsdRate(int financialYear)
        {
            string query = string.Format("select r_usd from TB_RATE where r_year = '{0}'", financialYear);
            decimal result = Convert.ToDecimal(DataService.GetInstance().ExecuteScalar(query));

            return result;
        }

        public static decimal GetMpJpyRate(int financialYear)
        {
            string query = string.Format("select r_jpy from TB_RATE where r_year = '{0}'", financialYear);
            decimal result = Convert.ToDecimal(DataService.GetInstance().ExecuteScalar(query));

            return result;
        }

        public static decimal GetMpRmbRate(int financialYear)
        {
            string query = string.Format("select r_rmb from TB_RATE where r_year = '{0}'", financialYear);
            decimal result = Convert.ToDecimal(DataService.GetInstance().ExecuteScalar(query));

            return result;
        }

        public static decimal GetMonthlyJpyRate(string year, string month)
        {
            string query = string.Format("select rm_rate from TB_RATE_MONTHLY where rm_year = '{0}' and rm_month = '{1}'", year, month);
            decimal result = Convert.ToDecimal(DataService.GetInstance().ExecuteScalar(query));

            return result;
        }
    }
}
