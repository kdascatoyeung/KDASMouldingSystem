using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KDTHK_MOULD_SYSTEM.services;

namespace KDTHK_MOULD_SYSTEM.utils
{
    public class LogUtils
    {
        public static void SaveLog(string module, string chaseNo, string user, string message)
        {
            string now = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");

            string query = string.Format("insert into TB_LOG (log_module, log_chaseno, log_createdby, log_created, log_message)" +
                " values ('{0}', '{1}', N'{2}', '{3}', N'{4}')", module, chaseNo, user, now, message);

            DataService.GetInstance().ExecuteNonQuery(query);
        }
    }
}
