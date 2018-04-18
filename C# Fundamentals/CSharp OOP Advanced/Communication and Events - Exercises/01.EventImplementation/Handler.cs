namespace _01.EventImplementation
{
    using System;

    public class Handler
    {
        public void OnDispatcherNameChange(object sender, NameChangeEventArgs arguments)
        {
            Console.WriteLine($"Dispatcher's name changed to {arguments.Name}.");
        }
    }
}