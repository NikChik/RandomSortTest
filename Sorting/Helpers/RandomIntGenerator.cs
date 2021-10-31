using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting.Helpers
{
    public static class RandomIntGenerator
    {
        private static Random _random;

        static RandomIntGenerator()
        {
            _random = new Random(DateTime.Now.Millisecond);
        }

        public static int Get()
        {
            return _random.Next();
        }

        public static int Get(int maxValue)
        {
            return _random.Next(maxValue);
        }

        public static int Get(int minValue, int maxValue)
        {
            return _random.Next(minValue, maxValue);
        }

        public static int[] GetArray(int length)
        {
            return GenerateArray(length, () => _random.Next());
        }

        public static int[] GetArray(int length, int maxValue)
        {
            return GenerateArray(length, () => _random.Next(maxValue));
        }

        public static int[] GetArray(int length, int minValue, int maxValue)
        {
            return GenerateArray(length, () => _random.Next(minValue, maxValue));
        }

        private static int[] GenerateArray(int length, Func<int> itemGenerator)
        {
            var newArray = new int[length];

            return newArray
                .Select(value => itemGenerator())
                .ToArray();
        }
    }
}
