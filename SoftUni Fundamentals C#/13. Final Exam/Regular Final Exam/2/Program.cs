using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _2_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string pattern = @"(?<start>\$|\%)(?<name>[A-Z][a-z]+)\1: \[(?<num1>\d+)\]\|\[(?<num2>\d+)\]\|\[(?<num3>\d+)\]\|";

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                var match1 = Regex.Matches(input, pattern);
                int count = match1.Count();

                if (count == 1)
                {
                    foreach (Match match in match1)
                    {
                        string tagName = match.Groups["name"].Value;
                        int number1 = int.Parse(match.Groups["num1"].Value);
                        int number2 = int.Parse(match.Groups["num2"].Value);
                        int number3 = int.Parse(match.Groups["num3"].Value);

                        string decryptedMessage = $"{(char)number1}{(char)number2}{(char)number3}";
                        Console.WriteLine($"{tagName}: {decryptedMessage}");
                    }
                           
                }

                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }
        }
    }
}
