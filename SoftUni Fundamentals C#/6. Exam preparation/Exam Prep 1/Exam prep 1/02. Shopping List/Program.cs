﻿using System;
using System.Linq;
namespace _02._Shopping_List
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int[] wagons = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int wagonCapacity = 4;

            for (int i = 0; i < wagons.Length; i++)
            {
                int currentState = wagons[i];
                if (currentState < wagonCapacity)
                {
                    int emptySeats = wagonCapacity - wagons[i];
                    people -= emptySeats;
                    if (people < 0)
                    {
                        wagons[i] = wagonCapacity - Math.Abs(people);
                        Console.WriteLine("The lift has empty spots!");
                        PrintWagons(wagons);
                        return;
                    }
                    wagons[i] = 4;
                }
            }

            if (people != 0)
            {
                Console.WriteLine($"There isn't enough space! {people} people in a queue!");
            }       
            PrintWagons(wagons);
        }

        private static void PrintWagons(int[] wagons)
        {
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
