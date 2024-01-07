using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyJohnHas = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double saberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            int freeBelts = studentsCount / 6;
            double totalCost = (saberPrice * Math.Ceiling(studentsCount + studentsCount * 0.10)) +
            (robePrice * studentsCount) + (beltPrice * (studentsCount - freeBelts));

            if (totalCost <= moneyJohnHas)
            {
                Console.WriteLine($"The money is enough - it would cost {totalCost:f2}lv.");
            }
            else
            {
                double neededMoney = totalCost - moneyJohnHas;
                Console.WriteLine($"John will need {neededMoney:f2}lv more.");
            }
        }
    }
}
