using System;

namespace _07._Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] array2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool identifical = true;
            int sum = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] == array2[i])
                {
                    sum += array1[i];
                    continue;
                }
                else
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    identifical = false;
                    break;
                }
            }
            if (identifical)
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
        }
    }
}
