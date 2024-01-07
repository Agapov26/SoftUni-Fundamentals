using System;

namespace _05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int numbers = int.Parse(Console.ReadLine());

            Orders(type, numbers);
        }
        private static void Orders(string type, int number)
        {
            double result = 0.00;
            switch (type)
            {
                case "coffee":
                    result = number * 1.50;
                    break;
                case "water":
                    result = number * 1.00;
                    break;
                case "coke":
                    result = number * 1.40;
                    break;
                case "snacks":
                    result = number * 2.00;
                    break;
                default:
                    break;

            }
            Console.WriteLine($"{result:F2}");
        }
    }
}
