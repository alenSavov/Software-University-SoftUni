﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.CountOccurrencesOfLargerNum
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split().Select(double.Parse).ToArray();
            double p = double.Parse(Console.ReadLine());
            double count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > p)
                {
                    count++;
                }
                
            }
            Console.WriteLine(count);
        }
    }
}
