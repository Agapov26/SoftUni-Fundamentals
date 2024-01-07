using System;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Array1 = Console.ReadLine().Split(' ');
            string[] Array2 = Console.ReadLine().Split(' ');

            int length = Math.Min(Array1.Length, Array2.Length);
            string[] outputArray = new string[length];
            int index = 0;

            for (int i = 0; i < Array2.Length; i++)
            {
                string elementFromSecondArray = Array2[i];

                bool isEqual = false;
                for (int j = 0; j < Array1.Length; j++)
                {
                    string elementFromFirstArray = Array1[j];

                    if (elementFromSecondArray == elementFromFirstArray)
                    {
                        isEqual = true;
                        break;
                    }
                }
                if (isEqual)
                {
                    outputArray[index] = elementFromSecondArray;
                    index++;
                    isEqual = false;
                }
            }

            Console.WriteLine(string.Join(" ", outputArray));
        }
        
    }
}
