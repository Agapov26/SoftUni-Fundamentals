using System;

namespace _01._Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            string ages = Console.ReadLine();          

            if (age >= 0 && age <= 2)
            {
                ages = "baby";
            }
            else if (age >= 3 && age <= 13)
            {
                ages = "child";
            }
            else if (age >= 14 && age <= 19)
            {
                ages = "teenager";
            }
            else if (age >= 20 && age <= 65)
            {
                ages = "adult";
            }
            else
            {
                ages = "elder";
            }
            Console.Write($"{ages}");
        }
    }
}
