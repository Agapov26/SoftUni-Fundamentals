using System;

namespace _02._Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            string result = string.Empty;

            foreach (string word in words)
            {
                int repeatTImes = word.Length;
                for (int i = 0; i < repeatTImes; i++)
                {
                    result += word;
                }
            }
            Console.WriteLine(result);
        }
    }
}
