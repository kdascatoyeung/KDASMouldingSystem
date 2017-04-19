using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KDTHK_MOULD_SYSTEM.services;

namespace KDTHK_MOULD_SYSTEM.data
{
    public class Ringi
    {
        public static bool IsRingiValid(string ringi)
        {
            string query = string.Format("select count(*) from TB_MASTER_RINGI where mr_no = '{0}'", ringi);
            object result = DataService.GetInstance().ExecuteScalar(query);

            if (result is DBNull || (int)result == 0)
                return false;

            return true;
        }

        public static decimal GetRingiBalance(string ringi)
        {
            string query = string.Format("select mr_amounthkd from TB_MASTER_RINGI where mr_no = '{0}'", ringi);

            return Convert.ToDecimal(DataService.GetInstance().ExecuteScalar(query));
        }
    }
}
