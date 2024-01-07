using System;

namespace _05._Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstRange = int.Parse(Console.ReadLine());
            int secondRange = int.Parse(Console.ReadLine());

            for (int i = firstRange; i <= secondRange; i++)
            {
                string asciiChar = ((char)i).ToString();
                Console.Write(asciiChar + " ");
            }
        }
    }
}
