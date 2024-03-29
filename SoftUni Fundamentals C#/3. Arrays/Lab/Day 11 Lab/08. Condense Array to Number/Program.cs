﻿using System;

namespace _08._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] condensedArray = new int[array.Length - 1];

            if (array.Length == 1)
            {
                Console.WriteLine(array[0]);
                return;
            }

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < condensedArray.Length - i; j++)
                {
                    condensedArray[j] = array[j] + array[j + 1];
                }
                array = condensedArray;
            }
            Console.WriteLine(condensedArray[0]);
        }
    }
}
