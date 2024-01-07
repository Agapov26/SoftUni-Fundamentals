using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            Factorial(n1, n2);
        }
        static void Factorial(int n1, int n2)
        {
            double f1 = 1;
            double f2 = 1;

            for (int i = n1; i > 0; i--)
            {
                f1 = f1 * i;
            }

            for (int i = n2; i > 0; i--)
            {
                f2 = f2 * i;
            }

            double result = f1 / f2;
            Console.WriteLine($"{result:f2}");
        }
    }
}
