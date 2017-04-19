using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using KDTHK_MOULD_SYSTEM.ipo.lists;
using KDTHK_MOULD_SYSTEM.lists;

namespace KDTHK_MOULD_SYSTEM.services
{
    class GlobalService
    {
        public static SqlDataAdapter Adapter { get; set; }

        public static SqlDataReader Reader { get; set; }

        public static String Owner { get; set; }

        public static String IPO1st { get; set; }

        public static String IPO2nd { get; set; }

        public static String CM1st { get; set; }

        public static String CM1stOther { get; set; }

        public static String CM2nd { get; set; }

        public static String CM3rd { get; set; }

        public static String CM4th { get; set; }

        public static String FixedAssetCode { get; set; }

        public static List<QuotationEditList> EditList { get; set; }

        public static List<String> RepeatFaList { get; set; }

        public static List<String> AccountStaffList { get; set; }

        public static List<MouldDataList> MouldDataList { get; set; }
    }
}
