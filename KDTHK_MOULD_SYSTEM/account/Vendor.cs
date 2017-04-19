using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using KDTHK_MOULD_SYSTEM.services;

namespace KDTHK_MOULD_SYSTEM.account
{
    public class Vendor
    {
        public static string GetVendorName(string vendor)
        {
            string query = string.Format("select mv_name from TB_MASTER_VENDOR where mv_code = '{0}'", vendor);

            string result = "Vendor has been removed from Vendor Master List";

            using (IDataReader reader = DataService.GetInstance().ExecuteReader(query))
            {
                while (reader.Read())
                {
                    result = reader.GetString(0).Trim();
                }
            }

            return result;
        }

    }
}
