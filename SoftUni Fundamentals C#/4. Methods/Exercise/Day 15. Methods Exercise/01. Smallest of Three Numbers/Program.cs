using System;

namespace _01._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int result = SmallestNumber(a, b, c);
            Console.WriteLine(result);
        }
        static int SmallestNumber(int a, int b, int c)
        {
            int smallestNum = Math.Min(Math.Min(a, b), c);
            return smallestNum;
        }
    }
}
