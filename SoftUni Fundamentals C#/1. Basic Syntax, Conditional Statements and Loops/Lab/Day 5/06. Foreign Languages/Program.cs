using System;

namespace _06._Foreign_Languages
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();

            string language = GetSpokenLanguage(country);

            Console.WriteLine(language);
        }

        static string GetSpokenLanguage(string country)
        {
            switch (country)
            {
                case "England":
                case "USA":
                    return "English";
                case "Spain":
                case "Argentina":
                case "Mexico":
                    return "Spanish";
                default:
                    return "unknown";
            }
        }
    }
}
