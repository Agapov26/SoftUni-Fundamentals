using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int commandsCount = int.Parse(Console.ReadLine());
            Dictionary<string, User> users = new Dictionary<string, User>();

            for (int i = 0; i < commandsCount; i++)
            {
                string[] arguments = Console.ReadLine().Split();
                string command = arguments[0];
                string username = arguments[1];

                switch (command)
                {
                    case "register":
                        string licensePlate = arguments[2];
                        User newUser = new User();
                        users.Add(username, newUser);
                        break;
                    case "unregister":
                        break;
                }
            }
        }
    }
}
iternal class User
{

}