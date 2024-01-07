using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double pricePerPerson = 0;

            if (groupType == "Students")
            {
                if (dayOfWeek == "Friday")
                    pricePerPerson = 8.45;
                else if (dayOfWeek == "Saturday")
                    pricePerPerson = 9.80;
                else if (dayOfWeek == "Sunday")
                    pricePerPerson = 10.46;
            }
            else if (groupType == "Business")
            {
                if (dayOfWeek == "Friday")
                    pricePerPerson = 10.90;
                else if (dayOfWeek == "Saturday")
                    pricePerPerson = 15.60;
                else if (dayOfWeek == "Sunday")
                    pricePerPerson = 16.00;
            }
            else if (groupType == "Regular")
            {
                if (dayOfWeek == "Friday")
                    pricePerPerson = 15.00;
                else if (dayOfWeek == "Saturday")
                    pricePerPerson = 20.00;
                else if (dayOfWeek == "Sunday")
                    pricePerPerson = 22.50;
            }

            double totalPrice = numberOfPeople * pricePerPerson;

            if (groupType == "Students" && numberOfPeople >= 30)
            {
                totalPrice *= 0.85; 
            }
            else if (groupType == "Business" && numberOfPeople >= 100)
            {
                int freeStayCount = numberOfPeople / 10;
                totalPrice -= freeStayCount * pricePerPerson;
            }
            else if (groupType == "Regular" && numberOfPeople >= 10 && numberOfPeople <= 20)
            {
                totalPrice *= 0.95; 
            }

            Console.WriteLine($"Total price: {totalPrice:F2}");
        }
    }
}
