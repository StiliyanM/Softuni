using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Nether_Realms
{
    class Program
    {
        class Demon
        {
            public string Name { get; set; }
            public int Health { get; set; }
            public double Damage { get; set; }
        }
        static void Main(string[] args)
        {
            var healthPattern = @"(?![0-9]|([.\-+\/*]))(?<characters>.)";
            var damagePattern = @"[-+]?[0-9]+\.?[0-9]*";
            var multiplicationPattern = @"[\*\/]";

            var demonNames = Regex.Split(Console.ReadLine(), @"[,\s]+");

            Regex healthRegex = new Regex(healthPattern);
            Regex damageRegex = new Regex(damagePattern);

            var demons = new List<Demon>();
            foreach (var name in demonNames)
            {
                Demon demon = new Demon
                {
                    Name = name,
                    Health = GetHealth(healthRegex,name),
                    Damage = GetDamage(damageRegex,name,multiplicationPattern)
                };

                demons.Add(demon);
            }

            PrintResults(demons);
        }

        private static void PrintResults(List<Demon> demons)
        {
            foreach (var demon in demons.OrderBy(x => x.Name))
            {
                Console.WriteLine($"{demon.Name} - {demon.Health} health, {demon.Damage:f2} damage");
            }
        }

        private static double GetDamage(Regex damageRegex, string name, string multiplicationPattern)
        {
            var matches = damageRegex.Matches(name);
            double damage = 0;
            foreach (Match m in matches)
            {
                damage += double.Parse(m.Value);
            }

            var operations = Regex.Matches(name, multiplicationPattern);

            foreach (Match op in operations)
            {
                if(op.Value == "*")
                {
                    damage *= 2;
                }
                else if(op.Value == "/")
                {
                    damage /= 2;
                }
            }
            return damage;
        }

        private static int GetHealth(Regex healthRegex, string name)
        {
            var matches = healthRegex.Matches(name);

            int health = 0;
            foreach (Match m in matches)
            {
                health += char.Parse(m.Value);
            }
            return health;
        }
    }
}
