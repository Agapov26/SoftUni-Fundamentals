using System;

namespace _12._Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    if (number % 2 == 0)
                    {
                        Console.WriteLine($"The number is: {Math.Abs(number)}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please write an even number.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            }
        }
    }
}
