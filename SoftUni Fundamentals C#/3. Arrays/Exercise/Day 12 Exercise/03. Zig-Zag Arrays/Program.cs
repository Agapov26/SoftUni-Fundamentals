using System;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isfirstSelectedArray = true;
            string[] Array1 = new string[n];
            string[] Array2 = new string[n];
            int[] intArray = new int[Array1.Length];
            

            for (int i = 0; i < n; i++)
            {
                string numbers = Console.ReadLine();
                string[] numbersArr = numbers.Split(' ');
                if (isfirstSelectedArray)
                {
                    Array1[i] = numbersArr[0];
                    Array2[i] = numbersArr[1];
                }
                else
                {
                    Array1[i] = numbersArr[1];
                    Array2[i] = numbersArr[0];
                }
                isfirstSelectedArray = !isfirstSelectedArray;
            }
            Console.WriteLine(string.Join(" ", Array1));
            Console.WriteLine(string.Join(" ", Array2));
        }
    }
}
