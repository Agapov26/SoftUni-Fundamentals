using System;

namespace _03._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (n == "add")
            {
                Add(a, b);
            }
            if (n == "multiply")
            {
                Multiply(a, b);
            }
            if (n == "subtract")
            {
                Subtract(a, b);
            }
            if (n == "divide")
            {
                Divide(a, b);
            }

        }

        private static void Divide(int firstNum, int secondNum)
        {
            int result = firstNum / secondNum;
            Console.WriteLine(result);
        }

        private static void Subtract(int firstNum, int secondNum)
        {
            int result = firstNum - secondNum;
            Console.WriteLine(result);
        }

        private static void Multiply(int firstNum, int secondNum)
        {
            int result = firstNum * secondNum;
            Console.WriteLine(result);
        }

        private static void Add(int firstNum, int secondNum)
        {
            int result = firstNum + secondNum;
            Console.WriteLine(result);
        }  
    }
}

