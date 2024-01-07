using System;
using System.Collections.Generic;
using System.Linq;
namespace _07._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArrays = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries);

            List<string> symbols = ExtractSymbols(stringArrays);

            Console.WriteLine(string.Join(" ", symbols));
        }

        private static List<string> ExtractSymbols(string[] stringArrays)
        {
            List<string> result = new List<string>();

            for (int i = stringArrays.Length - 1; i>=0; i-- )
            {
                string sequence = stringArrays[i];
                string[] array = sequence.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                result.AddRange(array);
            }          
            
            return result;
        }
    }
}
