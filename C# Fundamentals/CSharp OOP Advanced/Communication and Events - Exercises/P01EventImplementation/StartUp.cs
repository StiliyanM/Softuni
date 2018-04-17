using System;

namespace P01EventImplementation
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var dispatcher = new Dispatcher("Pesho");

            var handler = new Handler();

            dispatcher.NameChange += handler.OnDispatcherNameChange;

            string name;

            while ((name = Console.ReadLine()) != "End")
            {
                dispatcher.Name = name;
            }
        }
    }
}
