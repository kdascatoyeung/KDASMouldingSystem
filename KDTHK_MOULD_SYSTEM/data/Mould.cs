using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KDTHK_MOULD_SYSTEM.services;

namespace KDTHK_MOULD_SYSTEM.data
{
    public class Mould
    {
        public static bool IsPartNoValidExact(string partNo)
        {
            string query = string.Format("select count(*) from TB_MOULD_MAIN where m_itemcode = '{0}'", partNo);
            object result = DataService.GetInstance().ExecuteScalar(query);

            if (result is DBNull || (int)result == 0)
                return false;

            return true;
        }

        public static bool IsPartNoExist(string partNo)
        {
            partNo = partNo.Remove(partNo.Length - 1);

            string query = string.Format("select m_itemcode from TB_MOULD_MAIN where left(m_itemcode, len(m_itemcode) -1 ) = '{0}'", partNo);
            using (GlobalService.Reader = DataService.GetInstance().ExecuteReader(query))
            {
                if (GlobalService.Reader.HasRows)
                    return true;
            }
            return false;
        }

        public static string GetLatestChaseNo()
        {
            string query = "select top 1 m_chaseno from TB_MOULD_MAIN where m_chaseno like 'MS%' order by m_chaseno desc";

            string result = "";

            string chaseno = "";
            try
            {
                result = DataService.GetInstance().ExecuteScalar(query).ToString();

                result = result.Substring(3);

                int number = Convert.ToInt32(result) + 1;

                chaseno = "MS-" + number.ToString("D7");
            }
            catch
            {
                chaseno = "MS-0000001";
            }
            

            return chaseno;
        }

        public static string GetLatestMouldNo(string itemcode)
        {
            string rs = "";
            string result = "";

            itemcode = itemcode.Remove(itemcode.Length - 1);

            string query = string.Format("select top 1 m_mouldno from TB_MOULD_MAIN where m_type != 'Set' and" +
                " left(m_itemcode, len(m_itemcode) - 1) = '{0}' order by m_mouldno desc", itemcode);

            using (GlobalService.Reader = DataService.GetInstance().ExecuteReader(query))
            {
                if (GlobalService.Reader.HasRows)
                {
                    while (GlobalService.Reader.Read())
                        result = GlobalService.Reader.GetString(0);

                    string tmp = (string)result;
                    int lastId = Convert.ToInt32(tmp.Substring(tmp.Length - 2)) + 1;
                    rs = lastId.ToString("00");
                }
                else
                    rs = "01";
            }
            return rs;
        }

        public static string GetFixedAssetCode(string chaseNo)
        {
            string query = string.Format("select m_fixedasset from TB_MOULD_MAIN where m_chaseno = '{0}'", chaseNo);
            return DataService.GetInstance().ExecuteScalar(query).ToString();
        }

        public static string GetMouldCode(string chaseNo)
        {
            string query = string.Format("select m_mouldcode from TB_MOULD_MAIN where m_chaseno = '{0}'", chaseNo);
            return DataService.GetInstance().ExecuteScalar(query).ToString();
        }

        public static string GetVendor(string chaseNo)
        {
            string query = string.Format("select m_vendor from TB_MOULD_MAIN where m_chaseno = '{0}'", chaseNo);

            return DataService.GetInstance().ExecuteScalar(query).ToString();
        }

        public static string GetDiv(string chaseNo)
        {
            string query = string.Format("select m_div from TB_MOULD_MAIN where m_chaseno = '{0}'", chaseNo);
            return DataService.GetInstance().ExecuteScalar(query).ToString();
        }

        public static string GetMouldType(string chaseNo)
        {
            string query = string.Format("select m_type from TB_MOULD_MAIN where m_chaseno = '{0}'", chaseNo);
            return DataService.GetInstance().ExecuteScalar(query).ToString();
        }

        public static string GetItemText(string chaseNo)
        {
            string query = string.Format("select m_itemtext from TB_MOULD_MAIN where m_chaseno = '{0}'", chaseNo);

            return DataService.GetInstance().ExecuteScalar(query).ToString();
        }

        public static string GetMpa(string chaseNo)
        {
            string query = string.Format("select m_mpa from TB_MOULD_MAIN where m_chaseno = '{0}'", chaseNo);

            return DataService.GetInstance().ExecuteScalar(query).ToString();
        }

        public static string GetModel(string chaseNo)
        {
            string query = string.Format("select m_model from TB_MOULD_MAIN where m_chaseno = '{0}'", chaseNo);
            return DataService.GetInstance().ExecuteScalar(query).ToString();
        }

        public static string GetAmount(string chaseNo)
        {
            string query = string.Format("select m_amounthkd from TB_MOULD_MAIN where m_chaseno = '{0}'", chaseNo);
            return DataService.GetInstance().ExecuteScalar(query).ToString();
        }

        public static string GetRemarks(string chaseNo)
        {
            string query = string.Format("select m_remarks from TB_MOULD_MAIN where m_chaseno = '{0}'", chaseNo);
            return DataService.GetInstance().ExecuteScalar(query).ToString();
        }

        public static string GetPcs(string chaseNo)
        {
            string query = string.Format("select m_pcs from TB_MOULD_MAIN where m_chaseno = '{0}'", chaseNo);
            return DataService.GetInstance().ExecuteScalar(query).ToString();
        }
    }
}
