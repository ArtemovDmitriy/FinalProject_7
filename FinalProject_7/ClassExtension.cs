using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore
{
    internal static class DateExtension
    {
        public static string GetDateString(this DateTime source)
        {
            return source.ToString(DateTime.Now.ToString("yyMMdd"));
        }
    }
}
