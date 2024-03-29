﻿using System;
using System.Collections.Generic;
using System.Linq;
namespace _02._Shoot_for_the_Win
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input;
            int shootedTargets = 0;
            while ((input = Console.ReadLine()) != "End")
            {
                int targetIndex = int.Parse(input);

                if (targetIndex < 0 || targetIndex >= numbers.Count)
                {
                    continue;
                }

                int targetValue = numbers[targetIndex];

                if (numbers[targetIndex] == -1)
                {
                    continue;
                }

                numbers[targetIndex] = -1;
                shootedTargets++;

                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] == -1)
                    {
                        continue;
                    }
                    else if (targetValue < numbers[i])
                    {
                        numbers[i] -= targetValue;
                    }
                    else if (targetValue >= numbers[i])
                    {
                        numbers[i] += targetValue;
                    }
                }
            }

            Console.WriteLine($"Shot targets: {shootedTargets} -> {string.Join(" ", numbers)}");
        }
    }
}
