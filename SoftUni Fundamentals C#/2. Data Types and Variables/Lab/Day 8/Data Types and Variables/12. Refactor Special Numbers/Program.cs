using System;

namespace _12._Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int givenDigit = int.Parse(Console.ReadLine());
            int total = 0;
            int cycleCopier = 0;
            bool dividedOrNot = false;

            for (int cycle = 1; cycle <= givenDigit; cycle++)
            {
                cycleCopier = cycle;
                while (cycleCopier > 0)
                {
                    total += cycleCopier % 10;
                    cycleCopier /= 10;
                }
                dividedOrNot = total == 5 || total == 7 || total == 11;
                Console.WriteLine($"{cycle} -> {dividedOrNot}");

                total = 0;
            }
        }
    }
}
