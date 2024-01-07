using System;

namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "END")
            {
                input = Console.ReadLine();
                PalindromeIntegers(input);
            }
        }
        static void PalindromeIntegers(string input)
        {
            bool isPalindrome = true;
            int index = input.Length -1;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != input[index - i])
                {
                    isPalindrome = false;
                    index -= 1;
                    break;
                }
            }

            if (input == "END")
            {
                return;
            }
            if (isPalindrome)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
