using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace KDTHK_MOULD_SYSTEM.utils
{
    public class SystemUtil
    {
        public static void DoubleBuffered(DataGridView dgv, bool setting)
        {
            System.Type dgvType = dgv.GetType();
            System.Reflection.PropertyInfo info = dgvType.GetProperty("DoubleBuffered",
                System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            info.SetValue(dgv, setting, null);
        }

        public static bool IsDateFormat(string source)
        {
            string format = "yyyy/MM/dd";

            DateTime datetime;
            if (DateTime.TryParseExact(source, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out datetime))
                return true;
            else
                return false;
        }

        public static string[] PurGroupSplit(string groups)
        {
            return groups.Split(new string[] { " or " }, StringSplitOptions.None);
        }
    }
}
