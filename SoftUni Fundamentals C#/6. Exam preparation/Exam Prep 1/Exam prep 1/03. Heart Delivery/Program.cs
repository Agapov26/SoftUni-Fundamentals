using System;
using System.Collections.Generic;
using System.Linq;
namespace _03._Heart_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split().Select(int.Parse).ToList();

            string line = default;
            while ((line = Console.ReadLine()) != "End")
            {
                string[] inputTokens = line.Split().ToArray();
                string command = inputTokens[0];
                int index = int.Parse(inputTokens[1]);
                int value = int.Parse(inputTokens[2]);

                if (command == "Shoot")
                {
                    if (isValidIndex(index, targets))
                    {
                        targets[index] -= value;
                        if (targets[index] <= 0)
                        {
                            targets.RemoveAt(index);
                        }
                    }
                }
                else if (command == "Add")
                {
                    if (isValidIndex(index, targets))
                    {
                        targets.Insert(index, value);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                }
                else
                {
                    if (isValidIndex(index, targets) && isValidIndex(index + value, targets) && isValidIndex(index - value, targets))
                    {
                        for (int i = 1; i <= value; i++)
                        {
                            targets.RemoveAt(index + i);
                        }
                        targets.RemoveAt(index);
                        for (int i = 1; i <= value; i++)
                        {
                            targets.RemoveAt(index - i);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Strike missed!");
                    }
                }
            }
            Console.WriteLine(string.Join("|", targets));
        }

        static bool isValidIndex(int index, List<int> targets)
        {
            return index >= 0 && index < targets.Count;
        }
    }
}
