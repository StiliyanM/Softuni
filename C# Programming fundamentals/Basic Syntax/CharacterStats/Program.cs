﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterStats
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var currentHealth = int.Parse(Console.ReadLine());
            var maxHealth = int.Parse(Console.ReadLine());
            var currentEnergy = int.Parse(Console.ReadLine());
            var MaxEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Health: " + '|' + new string('|',currentHealth) + new string('.', maxHealth - currentHealth) + '|');
            Console.WriteLine("Energy: " + '|' + new string('|', currentEnergy) + new string('.', MaxEnergy - currentEnergy) + '|');

        }
    }
}