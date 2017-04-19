using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KDTHK_MOULD_SYSTEM.services;

namespace KDTHK_MOULD_SYSTEM.data
{
    public class Oem
    {
        public static bool IsOemValid(string oem)
        {
            string query = string.Format("select count(*) from TB_MASTER_OEM where mo_code = '{0}'", oem);
            object result = DataService.GetInstance().ExecuteScalar(query);

            if (result is DBNull || (int)result == 0)
                return false;

            return true;
        }

        public static string GetAccountCode(string oem)
        {
            string query = string.Format("select mo_accountCode from TB_MASTER_OEM where mo_code = '{0}'", oem);
            string accountCode = DataService.GetInstance().ExecuteScalar(query).ToString();

            return accountCode;
        }

        public static string GetCostCentre(string oem)
        {
            string query = string.Format("select mo_costCentre from TB_MASTER_OEM where mo_code = '{0}'", oem);
            string costCentre = DataService.GetInstance().ExecuteScalar(query).ToString();

            return costCentre;
        }

        public static string getOemContent(string oem)
        {
            string query = string.Format("select top1 oem_content from tb_oem where oem_code = '{0}'", oem);
            string content = DataService.GetInstance().ExecuteScalar(query).ToString();

            return content;
        }
    }
}
