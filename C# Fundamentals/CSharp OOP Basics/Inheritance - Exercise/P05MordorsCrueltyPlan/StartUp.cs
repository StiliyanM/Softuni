using System;

namespace P05MordorsCrueltyPlan
{
    class StartUp
    {
        static void Main()
        {
            var foods = Console.ReadLine().Split();

            var food = new Food();

            var happinessAmount = food.CalcuteHappinessAmount(foods);

            var mood = new Mood(happinessAmount);

            Console.WriteLine(happinessAmount);
            Console.WriteLine(mood.MoodName);
        }
    }
}
