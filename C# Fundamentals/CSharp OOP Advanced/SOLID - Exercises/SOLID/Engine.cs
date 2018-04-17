using System;
using SOLID.Contracts;

namespace SOLID
{
    using Factories;
    internal class Engine
    {
        private ILogger logger;
         
        public Engine(ILogger logger)
        {
            this.logger = logger;
        }

        internal void Run()
        {
            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                var error = 
            }
        }
    }
}