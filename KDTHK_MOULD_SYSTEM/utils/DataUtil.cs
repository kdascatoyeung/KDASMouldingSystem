using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KDTHK_MOULD_SYSTEM.services;
using System.Data;
using System.Diagnostics;

namespace KDTHK_MOULD_SYSTEM.utils
{
    public class DataUtil
    {
        public static string GetLatestChaseNo()
        {
            string query = "select top 1 m_chaseno from TB_MOULD_MAIN where m_chaseno like 'MS%' order by m_chaseno desc";
            int no = Convert.ToInt32(DataService.GetInstance().ExecuteScalar(query).ToString().Substring(3)) + 1;

            return "MS-" + no.ToString("D7");
        }

        public static string GetMouldNo(string chaseNo)
        {
            string query = string.Format("select m_mouldno from TB_MOULD_MAIN where m_chaseno = '{0}'", chaseNo);
            return DataService.GetInstance().ExecuteScalar(query).ToString();
        }

        public static string GetVendor(string chaseNo)
        {
            string query = string.Format("select m_vendor from TB_MOULD_MAIN where m_chaseno = '{0}'", chaseNo);
            return DataService.GetInstance().ExecuteScalar(query).ToString();
        }

        public static string GetProductionBase(string chaseNo)
        {
            string query = string.Format("select m_productBase from TB_MOULD_MAIN where m_chaseno = '{0}'", chaseNo);
            return DataService.GetInstance().ExecuteScalar(query).ToString();
        }

        public static string GetMpa(string chaseNo)
        {
            string query = string.Format("select m_mpa from TB_MOULD_MAIN where m_chaseno = '{0}'", chaseNo);
            return DataService.GetInstance().ExecuteScalar(query).ToString();
        }

        public static string GetInStockDate(string chaseNo)
        {
            string query = string.Format("select m_instock from TB_MOULD_MAIN where m_chaseno = '{0}'", chaseNo);
            return DataService.GetInstance().ExecuteScalar(query).ToString();
        }

        public static string GetIsModify(string chaseNo)
        {
            string query = string.Format("select m_modify from TB_MOULD_MAIN where m_chaseno = '{0}'", chaseNo);
            return DataService.GetInstance().ExecuteScalar(query).ToString();
        }

        public static List<string> GetPurGroup(string vendor)
        {
            List<string> list = new List<string>();

            string query = string.Format("select mv_group, mv_remarks from TB_MASTER_VENDOR where mv_code = '{0}'", vendor);

            using (GlobalService.Reader = DataService.GetInstance().ExecuteReader(query))
            {
                while (GlobalService.Reader.Read())
                {
                    string gp = GlobalService.Reader.GetString(0);
                    string remarks = GlobalService.Reader.GetString(1);

                    if (remarks != "")
                    {
                        string[] gps = SystemUtil.PurGroupSplit(remarks);
                        foreach (string g in gps)
                            list.Add(g);
                    }
                    else
                        list.Add(gp);
                }
            }
            return list;
        }

        public static string GetVendorName(string vendor)
        {
            string query = string.Format("select mv_name from TB_MASTER_VENDOR where mv_code = '{0}'", vendor);
            return DataService.GetInstance().ExecuteScalar(query).ToString();
        }

        public static string GetPurchaser(string group)
        {
            string query = string.Format("select mp_name from TB_MASTER_PURCHASER where mp_group = '{0}'", group);
            return DataService.GetInstance().ExecuteScalar(query).ToString();
        }

        public static string GetMouldCodeType(string mouldCode)
        {
            string query = string.Format("select mc_type from TB_MASTER_MOULDCODE where mc_code = '{0}'", mouldCode);
            return DataService.GetInstance().ExecuteScalar(query).ToString();
        }

        public static string GetMouldCodeItemGroup(string mouldCode)
        {
            string query = string.Format("select mc_itemgroup from TB_MASTER_MOULDCODE where mc_code = '{0}'", mouldCode);
            return DataService.GetInstance().ExecuteScalar(query).ToString();
        }

        public static string GetMouldCodeContent(string mouldCode)
        {
            string query = string.Format("select mc_contenteng from TB_MASTER_MOULDCODE where mc_code = '{0}'", mouldCode);
            return DataService.GetInstance().ExecuteScalar(query).ToString();
        }

        public static bool IsFixedAssetCodeExists(string fixedAssetCode)
        {
            GlobalService.RepeatFaList = new List<string>();

            string query = string.Format("select f_fixedasset from TB_FA_APPROVAL where f_fixedasset = '{0}'", fixedAssetCode);
            using (GlobalService.Reader = DataService.GetInstance().ExecuteReader(query))
            {
                if (GlobalService.Reader.HasRows)
                {
                    while (GlobalService.Reader.Read())
                    {
                        string fa = GlobalService.Reader.GetString(0);
                        GlobalService.RepeatFaList.Add(fa);
                    }
                    return true;
                }
            }

            return false;
        }

        public static string StatusCode(string chaseno)
        {
            string query = string.Format("select tm_st_code from tb_betamould where tm_chaseno = '{0}'", chaseno);
            return DataServiceMould.GetInstance().ExecuteScalar(query).ToString();
        }

        public static string CollectDate(string chaseno)
        {
            string query = string.Format("select tm_collectdate from tb_betamould where tm_chaseno = '{0}'", chaseno);
            return DataServiceMould.GetInstance().ExecuteScalar(query).ToString();
        }

        public static string GetRefFixedAsset(string chaseno, string fa)
        {
            string query = string.Format("select f_fixedasset from TB_FA_APPROVAL where f_mould = '{0}'", chaseno);
            string condition = fa.StartsWith("16") ? " and f_fixedasset like '4%'" : " and f_fixedasset like '16%'";

            query = query + condition;

            string result = "";

            using (IDataReader reader = DataService.GetInstance().ExecuteReader(query))
            {
                while (reader.Read())
                    result = reader.GetString(0).Trim();
            }
            return result;
        }
    }
}
