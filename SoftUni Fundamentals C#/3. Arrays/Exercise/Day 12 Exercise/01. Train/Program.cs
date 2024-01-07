using System;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int wagons = int.Parse(Console.ReadLine());
            int[] people = new int[wagons];
            int weidth = 0;

            for (int i = 0; i < wagons; i++)
            {
                int peopleCount = int.Parse(Console.ReadLine());
                weidth += peopleCount;
                people[i] = peopleCount;
            }
            Console.WriteLine($"{string.Join(" ", people)}");
            Console.WriteLine($"{weidth}");
        }
    }
}
