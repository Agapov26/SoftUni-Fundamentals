using System;
using System.Collections.Generic;
using System.Linq;
namespace _03._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> first = ReadIntList();
            List<int> second = ReadIntList();

            List<int> result = new List<int>();
            int itterations = Math.Max(first.Count, second.Count);
            for (int i = 0; i < itterations; i++)
            {
                if (i < first.Count)
                {
                    result.Add(first[i]);
                }
                if (i < second.Count)
                {
                    result.Add(second[i]);
                }           
            }
            Console.WriteLine(string.Join(" ", result));
        }
        public static List<int>ReadIntList()
        {
            return Console.ReadLine().Split().Select(int.Parse).ToList();
        }
    }
}
