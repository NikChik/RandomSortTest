using Sorting.Helpers;
using Sorting.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomSortTest
{
    public class ConsoleLogger : ILogger<int[]>
    {
        public void Log(int[] data)
        {
            var outString = data.ConvertToString();
            Console.WriteLine(outString);
        }

        public void Log(string text)
        {
            Console.WriteLine(text);
        }
    }
}
