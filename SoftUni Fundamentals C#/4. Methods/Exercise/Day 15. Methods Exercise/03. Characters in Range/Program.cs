using System;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char input1 = char.Parse(Console.ReadLine());
            char input2 = char.Parse(Console.ReadLine());

            charactersInRange(input1, input2);
        }       
        static void charactersInRange(char first, char second)
        {
            int startingChar = Math.Min(first, second);
            int endingChar = Math.Max(first, second);

            for (int i = startingChar + 1; i < endingChar; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
