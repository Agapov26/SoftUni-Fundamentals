using System;

namespace _10._Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if (number < 1 || number > 100)
            {
                Console.WriteLine("Invalid input. Please enter an integer between 1 and 100.");
                return;
            }

            for (int i = 1; i <= 10; i++)
            {
                int product = number * i;
                Console.WriteLine($"{number} X {i} = {product}");
            }
        }
    }
}
