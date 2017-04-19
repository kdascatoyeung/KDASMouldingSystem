using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KDTHK_MOULD_SYSTEM.services;

namespace KDTHK_MOULD_SYSTEM.data
{
    public class Vendor
    {
        public static bool IsVendorValid(string vendorCode)
        {
            string query = string.Format("select count(*) from TB_MASTER_VENDOR where mv_code = '{0}'", vendorCode);
            object result = DataService.GetInstance().ExecuteScalar(query);

            if (result is DBNull || (int)result == 0)
                return false;

            return true;
        }

        public static string GetVendorName(string vendorCode)
        {
            string query = string.Format("select mv_name from TB_MASTER_VENDOR where mv_code = '{0}'", vendorCode);
            return DataService.GetInstance().ExecuteScalar(query).ToString();
        }

        public static string GetVendorGroup(string vendorCode)
        {
            string query = string.Format("select mv_group from TB_MASTER_VENDOR where mv_code = '{0}'", vendorCode);
            return DataService.GetInstance().ExecuteScalar(query).ToString();
        }

        public static string GetVendorCurrency(string vendorCode)
        {
            string query = string.Format("select mv_currency from TB_MASTER_VENDOR where mv_code = '{0}'", vendorCode);
            return DataService.GetInstance().ExecuteScalar(query).ToString();
        }

        public static string GetVendorPayTerm(string vendorCode)
        {
            string query = string.Format("select mv_payterm from TB_MASTER_VENDOR where mv_code = '{0}'", vendorCode);
            return DataService.GetInstance().ExecuteScalar(query).ToString();
        }

        public static string GetVendorRegion(string vendorCode)
        {
            string query = string.Format("select mv_detail from TB_MASTER_VENDOR where mv_code = '{0}'", vendorCode);
            return DataService.GetInstance().ExecuteScalar(query).ToString();
        }

        public static string[] SplitGroup(string group)
        {
            return group.Split(new string[] { " or " }, StringSplitOptions.None);
        }

        public static List<string> GroupList(string vendorCode)
        {
            List<string> list = new List<string>();

            string purchaseGroup = GetVendorGroup(vendorCode);

            string query = string.Format("select mv_remarks from TB_MASTER_VENDOR where mv_code = '{0}'", vendorCode);

            string remarks = DataService.GetInstance().ExecuteScalar(query).ToString();

            if (remarks != "")
            {
                string[] groups = SplitGroup(remarks);

                foreach (string group in groups)
                    list.Add(group);
            }
            else
                list.Add(purchaseGroup);

            return list;
        }
    }
}
