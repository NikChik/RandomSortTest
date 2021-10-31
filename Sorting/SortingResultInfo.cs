using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class SortingResultInfo<T>
    {
        public TimeSpan ElapsedTime { get; }
        public int Iterations { get; }
        public T Result { get; }

        public SortingResultInfo(T result, TimeSpan elapsedTime, int iterations)
        {
            ElapsedTime = elapsedTime;
            Iterations = iterations;
            Result = result;
        }
    }
}
