using System;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int vowelsCount = GetVowelsCount(word);
            Console.WriteLine(vowelsCount);
        }
        static int GetVowelsCount(string word)
        {
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };

            int vowelsCount = 0;
            foreach (char vowel in word.ToLower())
            {
                if (vowels.Contains(vowel))
                {
                    vowelsCount++;
                }
            }
            return vowelsCount;
        }
    }
}
