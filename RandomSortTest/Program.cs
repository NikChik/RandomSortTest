﻿using Sorting;
using Sorting.Algorithms;
using Sorting.Helpers;
using Sorting.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomSortTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array length:");
            var inputString = Console.ReadLine();

            if (!int.TryParse(inputString, out var arrayLength))
            {
                Console.WriteLine("Wrong input");
                return;
            }

            var maxValue = 30;
            var array = RandomIntGenerator.GetArray(arrayLength, maxValue);

            Console.WriteLine($"Source array:");
            Console.WriteLine(array.ConvertToString());

            var loggerPath = "log.txt";
            var logger = new FileLogger(loggerPath);
            var sortingAlgorithm = new RandomSorttingAlgorithm(logger);
            var sorter = new Sorter<int[]>(sortingAlgorithm);
            var sortingResult = sorter.Sort(array);

            Console.WriteLine($"Result array:");
            Console.WriteLine(sortingResult.Result.ConvertToString());
            Console.WriteLine($"Elapsed time: {sortingResult.ElapsedTime}");
            Console.WriteLine($"Iterations: {sortingResult.Iterations}");
            Console.ReadLine();
        }
    }
}
