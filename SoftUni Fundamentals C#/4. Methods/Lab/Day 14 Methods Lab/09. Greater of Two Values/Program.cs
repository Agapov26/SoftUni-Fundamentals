using System;

namespace _09._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            if (command == "int")
            {
                int firstNumber = int.Parse(Console.ReadLine());
                int secondNumber = int.Parse(Console.ReadLine());
                int result = GetMax(firstNumber, secondNumber);
                Console.WriteLine(result);
            }

            else if (command == "string")
            {
                string firstText = Console.ReadLine();
                string secondText = Console.ReadLine();
                string result = GetMax(firstText, secondText);
                Console.WriteLine(result);

            }

            else if (command == "char")
            {
                char firstChar = char.Parse(Console.ReadLine());
                char secondChar = char.Parse(Console.ReadLine());
                char result = GetMax(firstChar, secondChar);
                Console.WriteLine(result);
            }
        }


        static int GetMax(int firstNumber, int secondNumber)
        {
            int result = Math.Max(firstNumber, secondNumber);
            return (result);
        }

        static string GetMax(string firstText, string secondText)
        {
            int comparison = firstText.CompareTo(secondText);
            if (comparison > 0)
            {
                return (firstText);
            }
            else
            {
                return (secondText);
            }
        }

        static char GetMax(char firstChar, char secondChar)
        {
            char result = (char)Math.Max(firstChar, secondChar);
            return (result);
        }
    }
}

