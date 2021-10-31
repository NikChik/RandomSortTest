using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting.Helpers
{
    public static class ArrayToStringConverter
    {
        public static string ConvertToString(this int[] value)
        {
            if (value is null || value.Length <= 0)
                return "";

            var result = value[0].ToString();

            for (int i = 1; i < value.Length; i++)
                result += ", " + value[i];

            return result;
        }
    }
}
