using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseDrink
{
    class Program
    {
        static void Main(string[] args)
        {
            var profession = Console.ReadLine();
            string drink = string.Empty;
       

            if (profession == "Athlete")
                drink = "Water";
            else if (profession == "Businesswoman" || profession == "Businessman")
                drink = "Coffee";
            else if (profession == "SoftUni Student")
                drink = "Beer";
            else
                drink = "Tea";

            Console.WriteLine(drink);
        }
    }
}
