using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3._Heroes_of_Code_and_Logic_VII
{
    class Hero
    {
        public string Name { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }
        public Hero(string name, int hp, int mp)
        {
            Name = name;
            HP = hp;
            MP = mp;
        }

        public int Recharge(int amountMP)
        {
            int recoveredMP = Math.Min(amountMP, 200 - MP);
            MP += recoveredMP;

            return recoveredMP;
        }

        public int Heal(int amountHP)
        {
            int recoveredHP = Math.Min(amountHP, 100 - HP);
            HP += recoveredHP;

            return recoveredHP;
        }

        public override string ToString()
        {
            StringBuilder heroBuilder = new StringBuilder();
            heroBuilder.AppendLine(Name);
            heroBuilder.AppendLine($"  HP: {HP}");
            heroBuilder.Append($"  MP: {MP}");

            return heroBuilder.ToString();
        }
    }
    class Program
    {
        static List<Hero> party = new List<Hero>();
        static void Main(string[] args)
        {
            int heroesCount = int.Parse(Console.ReadLine());            

            for (int i = 0; i < heroesCount; i++)
            {
                string[] heroArgs = Console.ReadLine().Split();
                Hero h = new Hero(heroArgs[0], int.Parse(heroArgs[1]), int.Parse(heroArgs[2]));
                party.Add(h);
            }

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] arguments = input.Split(" - ");

                switch (arguments[0])
                {
                    case "CastSpell":
                        CastSpell(arguments[1], int.Parse(arguments[2]), arguments[3]);
                        break;
                    case "TakeDamage":
                        TakeDamage(arguments[1], int.Parse(arguments[2]), arguments[3]);
                        break;
                    case "Recharge":
                        Recharge(arguments[1], int.Parse(arguments[2]));
                        break;
                    case "Heal":
                        Heal(arguments[1], int.Parse(arguments[2]));
                        break;
                }
            }

            party.ForEach(h => Console.WriteLine(h));
        }

        private static void Heal(string heroName, int amountHP)
        {
            Hero foundHero = party.FirstOrDefault(h => h.Name == heroName);

            if (foundHero == null)
            {
                return;
            }

            int recoveredHP = foundHero.Heal(amountHP);
            Console.WriteLine($"{foundHero.Name} healed for {recoveredHP} HP!");
        }

        private static void Recharge(string heroName, int amountMP)
        {
            Hero foundHero = party.FirstOrDefault(h => h.Name == heroName);

            if (foundHero == null)
            {
                return;
            }

            int recoveredMP = foundHero.Recharge(amountMP);
            Console.WriteLine($"{foundHero.Name} recharged for {recoveredMP} MP!");
        }

        private static void TakeDamage(string heroName, int damage, string attackerName)
        {
            Hero foundHero = party.FirstOrDefault(h => h.Name == heroName);

            if (foundHero == null)
            {
                return;
            }

            foundHero.HP -= damage;

            if (foundHero.HP > 0)
            {
                Console.WriteLine($"{foundHero.Name} was hit for {damage} HP by {attackerName} and now has {foundHero.HP} HP left!");
            }

            else
            {   
                party.Remove(foundHero);
                Console.WriteLine($"{foundHero.Name} has been killed by {attackerName}!");
            }
        }

        private static void CastSpell(string heroName, int mpNeeded, string spellName)
        {
            Hero foundHero = party.FirstOrDefault(h => h.Name == heroName);

            if (foundHero == null)
            {
                return;
            }

            if (foundHero.MP >= mpNeeded)
            {
                foundHero.MP -= mpNeeded;
                Console.WriteLine($"{foundHero.Name} has successfully cast {spellName} and now has {foundHero.MP} MP!");
            }

            else
            {   
                Console.WriteLine($"{foundHero.Name} does not have enough MP to cast {spellName}!");
            }
        }
    }
}
