using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace KDTHK_MOULD_SYSTEM.utils
{
    public class StartupUtil
    {
        public static bool IsProcessRunning(string name)
        {
            if (Process.GetProcessesByName(name).Length > 1)
                return false;

            return true;
        }

        
    }
}
