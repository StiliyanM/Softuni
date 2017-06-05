using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            var people = int.Parse(Console.ReadLine());


            double money = 0.0;
            double isEnough = 0.0;
            if(people < 5)
            {
                money = 0.25 * budget;
                if (category == "VIP")
                    isEnough = people * 499.99;
                else if (category == "Normal")
                    isEnough = people * 249.99;
            }
            else if(people >= 5 && people < 10)
            {
                money = 0.4 * budget;
                if (category == "VIP")
                    isEnough = people * 499.99;
                else if (category == "Normal")
                    isEnough = people * 249.99;
            }
            else if(people >= 10 && people < 25)
            {
                money = 0.5 * budget;
                if (category == "VIP")
                    isEnough = people * 499.99;
                else if (category == "Normal")
                    isEnough = people * 249.99;
            }
            else if(people >= 25 && people < 50)
            {
                money = 0.6 * budget;
                if (category == "VIP")
                    isEnough = people * 499.99;
                else if (category == "Normal")
                    isEnough = people * 249.99;
            }
            else if(people > 50)
            {
                money = 0.75 * budget;
                if (category == "VIP")
                    isEnough = people * 499.99;
                else if (category == "Normal")
                    isEnough = people * 249.99;
            }
            if(money >= isEnough)
                Console.WriteLine("Yes! You have {0:f2} leva left.",money - isEnough);
            else if(isEnough > money)
                Console.WriteLine("Not enough money! You need {0:f2} leva.",isEnough - money);
        }
    }
}
