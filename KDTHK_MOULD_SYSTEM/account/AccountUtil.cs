using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KDTHK_MOULD_SYSTEM.services;
using System.Data;

namespace KDTHK_MOULD_SYSTEM.account
{
    public class AccountUtil
    {
        public static void DeleteRecord(string chaseno)
        {
            string ringi = "";
            string amount = "";

            string text = string.Format("select tm_ringi_code, tm_amounthkd from tb_betamould where tm_chaseno = '{0}'", chaseno);
            using (IDataReader reader = DataServiceMould.GetInstance().ExecuteReader(text))
            {
                while (reader.Read())
                {
                    ringi = reader.GetString(0);
                    amount = reader.GetString(1);
                }
            }

            RestoreRingi(ringi, Convert.ToDecimal(amount));

            string query = string.Format("delete from TB_FA_APPROVAL where f_chaseno = '{0}'", chaseno);
            DataService.GetInstance().ExecuteNonQuery(query);

            UpdateMainTable(chaseno);
        }

        public static void RestoreRingi(string ringi, decimal amount)
        {
            string query = string.Format("update tb_ringi set rg_balance = cast(rg_balance as decimal(10, 2)) + {0} where rg_no = '{1}'", amount, ringi);
            DataServiceMould.GetInstance().ExecuteNonQuery(query);
        }

        public static void UpdateMainTable(string chaseno)
        {
            string query = string.Format("update tb_betamould set tm_ringi_code = '', tm_st_code = 'F', tm_pdfid = '' where tm_chaseno = '{0}'", chaseno);
            DataServiceMould.GetInstance().ExecuteNonQuery(query);
        }
    }
}
