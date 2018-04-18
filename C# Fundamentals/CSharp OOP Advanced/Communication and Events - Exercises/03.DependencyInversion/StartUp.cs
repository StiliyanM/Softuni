namespace _03.DependencyInversion
{
    using System;

    using _03DependencyInversion;

    class StartUp
    {
        static void Main()
        {
            var calculator = new PrimitiveCalculator();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] data = input.Split("\t ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                if (data[0] == "mode")
                {
                    char @operator = data[1][0];

                    calculator.changeStrategy(@operator);
                }
                else
                {
                    int number1 = int.Parse(data[0]);
                    int number2 = int.Parse(data[1]);

                    Console.WriteLine(calculator.performCalculation(number1, number2));
                }
            }
        }
    }
}
