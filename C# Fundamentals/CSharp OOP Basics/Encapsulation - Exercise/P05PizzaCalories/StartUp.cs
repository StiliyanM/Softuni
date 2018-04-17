using System;

public class StartUp
{
    static void Main()
    {
        try
        {
            var pizzaArgs = Console.ReadLine().Split(" ".ToCharArray(), StringSplitOptions.None);

            var pizza = new Pizza(pizzaArgs[1]);

            var doughArgs = Console.ReadLine().Split();
            string type = doughArgs[1];
            string bakingTechnique = doughArgs[2];
            double weight = double.Parse(doughArgs[3]);

            var dough = new Dough(type, bakingTechnique, weight);

            pizza.Dough = dough;
            string command;

            while ((command = Console.ReadLine()) != "END")
            {

                var toppingArgs = command.Split();

                var topping = new Topping(toppingArgs[1], double.Parse(toppingArgs[2]));

                pizza.AddTopping(topping);
            }

            Console.WriteLine($"{pizza.Name} - {pizza.GetTotalCalories():f2} Calories.");

        }

        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

