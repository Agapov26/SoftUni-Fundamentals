using System;
using System.Collections.Generic;

namespace _3_
{
    class Follower  
    {
        public int Likes { get; set; }
        public int Comments { get; set; }

        public Follower(int likes = 0, int comments = 0)
        {
            Likes = likes;
            Comments = comments;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Follower> followers = new Dictionary<string, Follower>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Log out")
                    break;

                string[] command = input.Split(": ");

                switch (command[0])
                {
                    case "New follower":
                        string username = command[1];
                        if (!followers.ContainsKey(username))
                            followers.Add(username, new Follower());
                        break;

                    case "Like":
                        username = command[1];
                        int likesCount = int.Parse(command[2]);
                        if (!followers.ContainsKey(username))
                            followers.Add(username, new Follower(likesCount));
                        else
                            followers[username].Likes += likesCount;
                        break;

                    case "Comment":
                        username = command[1];
                        if (!followers.ContainsKey(username))
                            followers.Add(username, new Follower(0, 1));
                        else
                            followers[username].Comments++;
                        break;

                    case "Blocked":
                        username = command[1];
                        if (followers.ContainsKey(username))
                            followers.Remove(username);
                        else
                            Console.WriteLine($"{username} doesn't exist.");
                        break;
                }
            }

            Console.WriteLine($"{followers.Count} followers");
            foreach (var follower in followers)
            {
                Console.WriteLine($"{follower.Key}: {follower.Value.Likes + follower.Value.Comments}");
            }
        }
    }
}
