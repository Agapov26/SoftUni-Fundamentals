using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _2._Emoji_Detector
{
    class Program
    {
        static void Main(string[] args)
        {
            string coolThresHoldPattern = @"\d";
            string emojiPattern = @"(\*{2}|\:{2})(?<Emoji>[A-Z][a-z]{2,})\1";

            List<string> coolEmojies = new List<string>();

            string input = Console.ReadLine();

            ulong coolThresHold = 1;

            foreach (Match match in Regex.Matches(input, coolThresHoldPattern))
            {
                coolThresHold *= ulong.Parse(match.Value);
            }

            MatchCollection matches = Regex.Matches(input, emojiPattern);

            foreach (Match match in matches)
            {
                string emojiStr = match.Groups["Emoji"].Value;
                ulong totalEmojiSum = 0;

                foreach (char character in emojiStr)
                {
                    totalEmojiSum += character;
                }

                if (totalEmojiSum >= coolThresHold)
                {
                    coolEmojies.Add(match.Value);
                }
            }

            Console.WriteLine($"Cool threshold: {coolThresHold}");
            Console.WriteLine($"{matches.Count} emojis found in the text. The cool ones are:");
            coolEmojies.ForEach(emoji => Console.WriteLine(emoji));
        }
    }
}
