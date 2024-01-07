using System;

namespace _06._Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double lenth = double.Parse(Console.ReadLine());
            double area = CalculateRectangleArea(width, lenth);
            Console.WriteLine(area);

            static double CalculateRectangleArea(double width, double lenth)
            {
                return width * lenth;
            }
        }
    }
}
