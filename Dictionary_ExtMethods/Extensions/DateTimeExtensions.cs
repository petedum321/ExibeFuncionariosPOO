using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_ExtMethods.Extensions
{
    static class DateTimeExtensions
    {
        public static string MesExtenso(this DateTime dateTime)
        {
            return dateTime.ToString("MMMM");
        }

    }
}
