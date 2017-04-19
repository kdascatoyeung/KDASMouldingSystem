using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KDTHK_MOULD_SYSTEM.services;

namespace KDTHK_MOULD_SYSTEM.data
{
    public class Criteria
    {
        public static List<string> CriteriaList()
        {
            List<string> list = new List<string>();

            string query = "select distinct c_criteria from TB_CRITERIA";
            using (GlobalService.Reader = DataService.GetInstance().ExecuteReader(query))
            {
                while (GlobalService.Reader.Read())
                    list.Add(GlobalService.Reader.GetString(0));
            }

            return list;
        }
    }
}
