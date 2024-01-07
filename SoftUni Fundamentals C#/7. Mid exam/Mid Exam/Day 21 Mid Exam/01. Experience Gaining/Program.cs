using System;

namespace _01._Experience_Gaining
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededExperience = double.Parse(Console.ReadLine());
            double battleCount = double.Parse(Console.ReadLine());
            double totalExperience = 0;

            for (int i = 1; i <= battleCount; i++)
            {
                double experiencePerBattle = double.Parse(Console.ReadLine());

                if (i % 3 == 0)
                {
                    experiencePerBattle += 0.15 * experiencePerBattle;
                }
                if (i % 5 == 0)
                {
                    experiencePerBattle -= 0.10 * experiencePerBattle;
                }
                if (i % 15 == 0)
                {
                    experiencePerBattle += 0.05 * experiencePerBattle;
                }

                totalExperience += experiencePerBattle;

                if (totalExperience >= neededExperience)
                {
                    Console.WriteLine($"Player successfully collected his needed experience for {i} battles.");
                    return;
                }
            }

            double needed = neededExperience - totalExperience;
            Console.WriteLine($"Player was not able to collect the needed experience, {needed:F2} more needed.");-
        }
    }
}
