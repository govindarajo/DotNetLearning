using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal static class StringExtensionMethod
    {
        public static string ChangeFirstChar(this string name)
        {
            char[] chars = name.ToCharArray();
            chars[0] = char.IsUpper(chars[0]) ? chars[0] : char.ToUpper(chars[0]);
            return new string(chars);
        }
    }
}
