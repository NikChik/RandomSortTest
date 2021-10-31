using Sorting.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting.Algorithms
{
    public interface ISortingAlgorithm<T>
    {
        T Sort(T data);
        T Sort(T data, Counter iterationsCounter);
    }
}
