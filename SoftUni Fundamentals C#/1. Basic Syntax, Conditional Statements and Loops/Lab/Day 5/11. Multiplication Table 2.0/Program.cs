using System;

namespace _11._Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            if (inputNumber < 1 || inputNumber > 100)
            {
                Console.WriteLine("Invalid input. Please enter an integer between 1 and 100.");
                return;
            }

            int multiplier = int.Parse(Console.ReadLine());

            if (multiplier < 1)
            {
                Console.WriteLine("Multiplier should be greater than or equal to 1.");
                return;
            }

            if (multiplier <= 10)
            {
                for (int i = multiplier; i <= 10; i++)
                {
                    int product = inputNumber * i;
                    Console.WriteLine($"{inputNumber} X {i} = {product}");
                }
            }
            else
            {
                int product = inputNumber * multiplier;
                Console.WriteLine($"{inputNumber} X {multiplier} = {product}");
            }
        }
    }
}
