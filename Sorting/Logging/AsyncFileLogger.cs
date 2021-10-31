using Sorting.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Sorting.Logging
{
    public class AsyncFileLogger : ILogger<int[]>
    {
        private readonly string _path;
        private readonly List<string> _stringBuffer;
        private readonly object _lockObject;
        private readonly Timer _bufferCheckTimer;

        public AsyncFileLogger(string path)
        {
            _path = path;
            _stringBuffer = new List<string>();
            _lockObject = new object();
            _bufferCheckTimer = new Timer(100);
            _bufferCheckTimer.Elapsed += (sender, e) => LogFromBuffer();
        }

        public void Log(int[] data)
        {
            Task.Run(() =>
            {
                var outputString = data.ConvertToString();
                AddToBuffer(outputString);
            });
        }

        public void Log(string text)
        {
            Task.Run(() =>
            {
                AddToBuffer(text);
            });
        }

        private void AddToBuffer(string value)
        {
            lock(_lockObject)
            {
                _stringBuffer.Add(value);

                if (!_bufferCheckTimer.Enabled)
                    _bufferCheckTimer.Start();
            }
        }

        private IEnumerable<string> ReadFromBuffer()
        {
            lock(_lockObject)
            {
                _bufferCheckTimer.Stop();
                var stringList = new List<string>(_stringBuffer);
                _stringBuffer.Clear();
                return stringList;
            }
        }

        private void LogFromBuffer()
        {
            Task.Run(() =>
            {
                var stringList = ReadFromBuffer();
                File.AppendAllLines(_path, stringList);
            });
        }
    }
}
