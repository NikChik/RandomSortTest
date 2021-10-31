using Sorting.Algorithms;
using Sorting.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class Sorter<T>
    {
        private ISortingAlgorithm<T> _sortingAlgorithm;

        public Sorter(ISortingAlgorithm<T> sortingAlgorithm)
        {
            _sortingAlgorithm = sortingAlgorithm;
        }
        
        public SortingResultInfo<T> Sort(T data)
        {
            var iterationsCounter = new Counter();
            var startTime = DateTime.Now;
            var result = _sortingAlgorithm.Sort(data, iterationsCounter);
            var endTime = DateTime.Now;
            var elapsedTime = endTime - startTime;
            return new SortingResultInfo<T>(result, elapsedTime, iterationsCounter.Value);
        }
    }
}
