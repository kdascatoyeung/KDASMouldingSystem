using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using KDTHK_MOULD_SYSTEM.account;
using KDTHK_MOULD_SYSTEM.services;
using CustomUtil.utils.authentication;
using KDTHK_MOULD_SYSTEM.utils;
using System.Diagnostics;
using System.Data;
using KDTHK_MOULD_SYSTEM.lists;

namespace KDTHK_MOULD_SYSTEM
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            /*if (StartupUtil.IsProcessRunning("KDTHK_MOULD_SYSTEM"))
            {
                MessageBox.Show("System is already opened.");
                Process.GetCurrentProcess().Kill();
            }*/
            //GlobalService.Owner = "Cato Yeung Pui Kwan (楊沛昆)";
            GlobalService.Owner = CustomUtil.utils.authentication.AdUtil.getUsername("kmhk.local");

            GlobalService.IPO1st = "Poon Nga Wai(潘雅慧,Anna)";
            GlobalService.IPO2nd = "Cheng Chong Wah(鄭創華)";

            GlobalService.CM1st = "Chow Chi To(周志滔,Sammy)";
            GlobalService.CM1stOther = "Lai King Ho(黎景豪,Ken)";

            GlobalService.CM2nd = "Lee Suk Ha(李淑霞,Zoe)";
            GlobalService.CM3rd = "Li Yuen Yan(李婉茵,Sharon)";
            GlobalService.CM4th = "Leung Wai Yip(梁偉業,Philip)";

            GlobalService.AccountStaffList = new List<string>();
            GlobalService.AccountStaffList.AddRange(new string[] { "Leung Wai Yip(梁偉業,Philip)", "Ho Chui Lai(何翠麗,Joanne)", "Lee Suk Ha(李淑霞,Zoe)", "Li Yuen Yan(李婉茵,Sharon)", "Ng Wai Kwan(吳蕙君,Wendy)", "Ogata Shuka (尾形秋香)" });
            GlobalService.AccountStaffList.Sort();

            /*GlobalService.MouldDataList = new List<MouldDataList>();

            string query = "select tm_chaseno, tm_st_code, tm_collectdate from tb_betamould";
            using (IDataReader reader = DataServiceMould.GetInstance().ExecuteReader(query))
            {
                while (reader.Read())
                    GlobalService.MouldDataList.Add(new lists.MouldDataList { ChaseNo = reader.GetString(0).Trim(), Status = reader.GetString(1).Trim(), CollectDate = reader.GetString(2).Trim() });
            }

            foreach (MouldDataList item in GlobalService.MouldDataList)
            {
                string chaseno = item.ChaseNo;
                string status = item.Status;
                string collectdate = item.CollectDate;

                string data = status == "S" ? "已入庫"
                    : status == "L" ? "已廢棄"
                    : status == "C" ? "已取消" : collectdate;

                string text = string.Format("update TB_FA_APPROVAL set f_remarks = N'{0}' where f_mould = '{1}'", data, chaseno);
                DataService.GetInstance().ExecuteNonQuery(text);
            }*/

            //Application.Run(new KDTHK_MOULD_SYSTEM.ipo.Main());
            //Application.Run(new Main());
            Application.Run(new MainAccount());
        }
    }
}
