using Sorting.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting.Logging
{
    public class FileLogger : ILogger<int[]>
    {
        private string _path;

        public FileLogger(string path)
        {
            _path = path;
        }

        public void Log(int[] data)
        {
            var outputString = data.ConvertToString();
            File.AppendAllText(_path, outputString + "\r\n");
        }

        public void Log(string text)
        {
            File.AppendAllText(_path, text + "\r\n");
        }
    }
}
