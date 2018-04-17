using System;

namespace P03WildFarm
{
    class StartUp
    {
        static void Main()
        {
            string command;

            bool evenLine = true;
            while ((command = Console.ReadLine()) != "End")
            {
                if (evenLine)
                {
                    RegisterAnimal();
                }
                else
                {
                    FeedAnimal();
                }

                evenLine = !evenLine;
            }
        }

        private static void RegisterAnimal()
        {
            throw new NotImplementedException();
        }

        private static void FeedAnimal()
        {
            throw new NotImplementedException();
        }
    }
}
