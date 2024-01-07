using System;
using System.Linq;
namespace _1_
{
    class Program
    {
        static void Main(string[] args)
        {
            string decryptingMessage = Console.ReadLine();

            string input;
            while ((input = Console.ReadLine()) != "Finish")
            {
                string[] possibleCommands = input.Split();

                switch (possibleCommands[0])
                {
                    case "Replace":
                        
                        string currentSubstring = possibleCommands[1];
                        string newSubstring = possibleCommands[2];
                        decryptingMessage = decryptingMessage.Replace(currentSubstring, newSubstring);
                        Console.WriteLine(decryptingMessage);                       
                        break;

                    case "Cut":
                        int startIndex = int.Parse(possibleCommands[1]);
                        int endIndex = int.Parse(possibleCommands[2]);

                        if (startIndex < 0 || endIndex >= decryptingMessage.Length)
                        {
                            Console.WriteLine("Invalid indices!");
                            continue;
                        }

                        decryptingMessage = decryptingMessage.Remove(startIndex, endIndex - startIndex + 1);
                        Console.WriteLine(decryptingMessage);
                        break;

                    case "Make":

                        if (possibleCommands[1] == "Upper")
                        {
                            decryptingMessage = decryptingMessage.ToUpper();
                        }

                        else if (possibleCommands[1] == "Lower")
                        {
                            decryptingMessage = decryptingMessage.ToLower();
                        }
                        Console.WriteLine(decryptingMessage);
                        break;

                    case "Check":
                        string substringToCheck = possibleCommands[1];

                        if (decryptingMessage.Contains(substringToCheck))
                        {
                            Console.WriteLine($"Message contains {substringToCheck}");
                        }

                        else
                        {
                            Console.WriteLine($"Message doesn't contain {substringToCheck}");
                        }
                        break;

                    case "Sum":
                        startIndex = int.Parse(possibleCommands[1]);
                        endIndex = int.Parse(possibleCommands[2]);

                        if (startIndex < 0 || endIndex >= decryptingMessage.Length)
                        {
                            Console.WriteLine("Invalid indices!");
                            continue;
                        }

                        int sum = 0;

                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            sum += decryptingMessage[i];
                        }

                        Console.WriteLine(sum);
                        break;
                }
            }
        }
    }
}
