using System;
using System.Collections.Generic;
using System.Linq;
namespace _02._Space_Travel
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] commands = Console.ReadLine().Split("||");
            int fuel = int.Parse(Console.ReadLine());
            int ammunition = int.Parse(Console.ReadLine());

            for (int i = 0; i < commands.Length; i++)
            {
                string[] tokens = commands[i].Trim().Split();
                string action = tokens[0];

                switch (action)
                {
                    case "Travel":
                        int distance = int.Parse(tokens[1]);
                        if (fuel >= distance)
                        {
                            fuel -= distance;
                            Console.WriteLine($"The spaceship travelled {distance} light-years.");
                        }
                        else
                        {
                            Console.WriteLine("Mission failed.");
                            return;
                        }
                        break;

                    case "Enemy":
                        int enemyArmor = int.Parse(tokens[1]);
                        if (ammunition >= enemyArmor)
                        {
                            ammunition -= enemyArmor;
                            Console.WriteLine($"An enemy with {enemyArmor} armour is defeated.");
                        }
                        else
                        {
                            int fuelConsumed = enemyArmor * 2;
                            if (fuel >= fuelConsumed)
                            {
                                fuel -= fuelConsumed;
                                Console.WriteLine($"An enemy with {enemyArmor} armour is outmaneuvered.");
                            }
                            else
                            {
                                Console.WriteLine("Mission failed.");
                                return;
                            }
                        }
                        break;

                    case "Repair":
                        int fuelToAdd = int.Parse(tokens[1]);
                        int ammunitionToAdd = int.Parse(tokens[1]) * 2;
                        fuel += fuelToAdd;
                        ammunition += ammunitionToAdd;
                        Console.WriteLine($"Ammunitions added: {ammunitionToAdd}.");
                        Console.WriteLine($"Fuel added: {fuelToAdd}.");
                        break;

                    case "Titan":
                        Console.WriteLine("You have reached Titan, all passengers are safe.");
                        return;

                    default:
                        Console.WriteLine("Invalid command.");
                        return;
                }
            }
        }
    }
}
