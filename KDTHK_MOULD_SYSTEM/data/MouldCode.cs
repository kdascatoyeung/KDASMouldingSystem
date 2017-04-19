using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KDTHK_MOULD_SYSTEM.services;

namespace KDTHK_MOULD_SYSTEM.data
{
    public class MouldCode
    {
        public static bool IsMouldCodeValid(string mouldCode)
        {
            string query = string.Format("select count(*) from TB_MASTER_MOULDCODE where mc_code = '{0}'", mouldCode);
            object result = DataService.GetInstance().ExecuteScalar(query);

            if (result is DBNull || (int)result == 0)
                return false;

            return true;
        }

        public static string GetMouldType(string mouldcode)
        {
            string query = string.Format("select mc_type from TB_MASTER_MOULDCODE where mc_code = '{0}'", mouldcode);

            return DataService.GetInstance().ExecuteScalar(query).ToString();
        }

        public static string GetMouldContent(string mouldcode)
        {
            string query = string.Format("select mc_contentjp, mc_contenteng, mc_contentchin from TB_MASTER_MOULDCODE where mc_code = '{0}'", mouldcode);

            string content = "";

            using (GlobalService.Reader = DataService.GetInstance().ExecuteReader(query))
            {
                while (GlobalService.Reader.Read())
                {
                    string contentJp = GlobalService.Reader.GetString(0);
                    string contentEng = GlobalService.Reader.GetString(1);
                    string contentChin = GlobalService.Reader.GetString(2);

                    content = contentJp + "\n" + contentEng + "\n" + contentChin;
                }
            }

            return content;
        }
    }
}
