﻿using System;

namespace _04._Back_in_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            minutes += 30;

            if (minutes >= 60)
            {
                hours += 1;
                minutes -= 60;
            }
            if (hours >= 24)
            {
                hours -= 24;
            }

            Console.WriteLine($"{hours}:{minutes}");
        }
    }
}
