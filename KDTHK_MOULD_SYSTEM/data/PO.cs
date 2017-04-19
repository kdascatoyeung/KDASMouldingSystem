using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KDTHK_MOULD_SYSTEM.services;

namespace KDTHK_MOULD_SYSTEM.data
{
    public class PO
    {
        public static bool IsPOValid(string po)
        {
            bool isValid = false;

            string query = string.Format("select mm_po from TB_MOULD_MAIN where mm_po = '{0}'", po);
            using (GlobalService.Reader = DataService.GetInstance().ExecuteReader(query))
            {
                if (GlobalService.Reader.HasRows)
                    isValid = true;
                else
                    isValid = false;
            }
            return isValid;
        }

        public static bool IsPOMpa(string po)
        {
            bool isMpa = false;

            string query = string.Format("select mm_mpa from TB_MOULD_MAIN where mm_po = '{0}'", po);
            using (GlobalService.Reader = DataService.GetInstance().ExecuteReader(query))
            {
                while (GlobalService.Reader.Read())
                {
                    string mpa = GlobalService.Reader.GetString(0);
                    isMpa = mpa == "True" ? true : false;
                }
            }

            return isMpa;
        }

        public static string GetInStock50ByPo(string po)
        {
            string query = string.Format("select mm_instockdate50 from TB_MOULD_MAIN where mm_po = '{0}'", po);
            return DataService.GetInstance().ExecuteScalar(query).ToString();
        }

        public static string GetDivByPo(string po)
        {
            string query = string.Format("select mm_div from TB_MOULD_MAIN where mm_po = '{0}'", po);
            return DataService.GetInstance().ExecuteScalar(query).ToString();
        }

        public static string GetVendorCodeByPo(string po)
        {
            string query = string.Format("select mm_vendorcode from TB_MOULD_MAIN where mm_po = '{0}'", po);
            return DataService.GetInstance().ExecuteScalar(query).ToString();
        }
    }
}
