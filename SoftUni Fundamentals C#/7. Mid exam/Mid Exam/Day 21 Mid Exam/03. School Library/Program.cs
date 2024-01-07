using System;
using System.Collections.Generic;
using System.Linq;
namespace _03._School_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shelf = new List<string>(Console.ReadLine().Split('&'));

            string input;
            while ((input = Console.ReadLine()) != "Done")
            {
                string[] command = input.Split(" | ");
                string action = command[0];
                string bookName = command[1];

                switch (action)
                {
                    case "Add Book":
                        if (!shelf.Contains(bookName))
                        {
                            shelf.Insert(0, bookName);
                        }
                        break;
                            
                    case "Take Book":
                        if (shelf.Contains(bookName))
                        {
                            shelf.Remove(bookName);
                        }
                        break;

                    case "Swap Books":
                        string book1 = command[1];
                        string book2 = command[2];
                        int index1 = shelf.IndexOf(book1);
                        int index2 = shelf.IndexOf(book2);
                        if (index1 != -1 && index2 != -1)
                        {
                            shelf[index1] = book2;
                            shelf[index2] = book1;
                        }
                        break;

                    case "Insert Book":
                        if (!shelf.Contains(bookName))
                        {
                            shelf.Add(bookName);
                        }
                        break;

                    case "Check Book":
                        int index = int.Parse(bookName);
                        if (index >= 0 && index < shelf.Count)
                        {
                            Console.WriteLine(shelf[index]);
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", shelf));
        }
    }
}
