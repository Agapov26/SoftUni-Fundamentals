﻿using System;
using System.Text;

namespace _04._Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            StringBuilder cipherBuilder = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                char original = text[i];
                cipherBuilder.Append((char)(original + 3));
            }

            Console.WriteLine(cipherBuilder);
        }
    }
}
