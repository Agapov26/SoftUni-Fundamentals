﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Race
{
    class Participant
    {
        public Participant(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public uint Distance { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<string> participantNames = Console.ReadLine().Split(", ").ToList();
            List<Participant> participants = new List<Participant>();


            foreach (string name in participantNames)
            {
                Participant participant = new Participant(name);
                participants.Add(participant);
            }

            string input;
            while ((input = Console.ReadLine()) != "end of race")
            {
                StringBuilder nameBuilder = new StringBuilder();
                string lettersPattern = @"[A-Za-z]";
                foreach (Match match in Regex.Matches(input, lettersPattern))
                {
                    nameBuilder.Append(match.Value);
                }

                string participantName = nameBuilder.ToString(); 
                
                uint distance = 0;
                string digitsPattern = @"\d";
                foreach (Match match in Regex.Matches(input, digitsPattern))    
                {
                    distance += uint.Parse(match.Value);    
                }

                Participant foundParticipant = participants.FirstOrDefault(p => p.Name == participantName);
                if (foundParticipant != null)
                {
                    foundParticipant.Distance += distance;
                }
                
            }

            List<Participant> FirstThreeParticipants = participants.OrderByDescending(p => p.Distance).Take(3).ToList();

            Console.WriteLine($"1st place: {FirstThreeParticipants[0].Name}");
            Console.WriteLine($"2nd place: {FirstThreeParticipants[1].Name}");
            Console.WriteLine($"3rd place: {FirstThreeParticipants[2].Name}");
        }
    }
}
