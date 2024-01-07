using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resourceMap = new Dictionary<string, int>();
            string resource;
            while ((resource = Console.ReadLine()) != "stop")
            {
                if (!resourceMap.ContainsKey(resource))
                {
                    resourceMap.Add(resource, 0);
                }

                int quantity = int.Parse(Console.ReadLine());
                resourceMap[resource] += quantity;
            }

            foreach (var resourcePair in resourceMap)
            {
                Console.WriteLine($"{resourcePair.Key} -> {resourcePair.Value}");
            }
        }
    }
}
