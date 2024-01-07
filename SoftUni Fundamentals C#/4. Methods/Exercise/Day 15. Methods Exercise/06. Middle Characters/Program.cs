using System;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            MiddleSymbol(input);
        }
        static void MiddleSymbol(string text)
        {
            if (text.Length % 2 == 1)
            {
                Console.WriteLine($"{text[text.Length / 2]}");
            }
            else
            {
                Console.WriteLine($"{text[text.Length / 2 - 1]}{text[text.Length / 2]}");
            }
        }
    }
}
