using Sorting.Helpers;
using Sorting.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting.Algorithms
{
    public class RandomSorttingAlgorithm : ISortingAlgorithm<int[]>
    {
        private ILogger<int[]> _logger;

        public RandomSorttingAlgorithm()
        {

        }

        public RandomSorttingAlgorithm(ILogger<int[]> logger)
        {
            _logger = logger;
        }

        public int[] Sort(int[] data)
        {
            return Sort(data, null);
        }

        public int[] Sort(int[] data, Counter iterationsCounter)
        {
            _logger.Log("Sorting started");
            _logger.Log(data);

            while (!CheckIfSorted(data))
            {
                data = TrySort(data);
                iterationsCounter.Count();
                _logger.Log(data);
            }

            _logger.Log("Sorting ended");

            return data;
        }
       
        private bool CheckIfSorted(int[] data)
        {
            for (int i = 0; i < data.Length - 1; i++)
                if (!Compare(data[i], data[i + 1]))
                    return false;

            return true;
        }

        private bool Compare(int value, int nextValue)
        {
            return value <= nextValue;
        }

        private int[] TrySort(int[] data)
        {
            var ununusedItems = new List<int>(data);

            return data
                .Select(_ => UseItem(ununusedItems))
                .ToArray();
        }

        private int UseItem(List<int> items)
        {
            var length = items.Count();
            var index = RandomIntGenerator.Get(length);
            var item = items[index];
            items.RemoveAt(index);
            return item;
        }
    }
}
