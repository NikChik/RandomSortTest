using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting.Logging
{
    public interface ILogger<T>
    {
        void Log(T data);
        void Log(string text);
    }
}
