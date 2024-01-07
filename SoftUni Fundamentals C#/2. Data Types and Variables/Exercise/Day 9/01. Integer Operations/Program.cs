using System;

namespace _01._Integer_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int fourth = int.Parse(Console.ReadLine());

            int result1 = first + second;
            int result2 = result1 / third;
            int result3 = result2 * fourth;

            Console.WriteLine(result3);
        }
    }
}
