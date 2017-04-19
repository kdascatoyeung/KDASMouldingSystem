using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace KDTHK_MOULD_SYSTEM.data
{
    public class General
    {
        public static bool IsValidPrice(string source)
        {
            if (source.Length == 0)
                return false;

            string expression = @"^[0-9]*(\.[0-9]{1,2})?$";
            Regex regex = new Regex(expression);

            if (regex.IsMatch(source))
                return true;

            return false;
        }

    }
}
