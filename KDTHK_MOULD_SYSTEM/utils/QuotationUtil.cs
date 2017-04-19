using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KDTHK_MOULD_SYSTEM.utils
{
    public class QuotationUtil
    {
        public static bool IsLengthValid(string partNo)
        {
            if (partNo.Length != 8 && partNo.Length != 10 && partNo.Length != 12 && partNo.Length != 15)
                return false;

            return true;
        }
    }
}
