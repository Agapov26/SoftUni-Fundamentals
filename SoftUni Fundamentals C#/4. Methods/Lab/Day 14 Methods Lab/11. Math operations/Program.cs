using System;

namespace _11._Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            int n2 = int.Parse(Console.ReadLine());

            int result = Calculate(n1, @operator, n2);
            Console.WriteLine(result);
        }

        static int Calculate(int n1, string @operator, int n2)
        {
            int result = 0;
            switch (@operator)
            {
                case "+":
                    result = n1 + n2;
                    break;
                case "-":
                    result = n1 - n2;
                    break;
                case "*":
                    result = n1 * n2;
                    break;
                case "/":
                    result = n1 / n2;                
                    break;
            }
            return result;
        }
    }
}
