using System;

namespace NeedForSpeed
{
    class Program
    {
        enum Command
        {
            register, check, open, participate, park, unpark, tune, start
        }
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager();

            string input;

            while ((input = Console.ReadLine()) != "Cops Are Here")
            {
                var arguments = input.Split();

                Enum.TryParse(arguments[0], false, out Command command);

                switch (command)
                {
                    case Command.register:
                        RegisterCommand(carManager, arguments);
                        break;
                    case Command.check:
                        CheckCommand(carManager, arguments);
                        break;
                    case Command.open:
                        OpenCommand(carManager, arguments);
                        break;
                    case Command.participate:
                        ParticipateCommand(carManager, arguments);
                        break;
                    case Command.park:
                        ParkCommand(carManager, arguments);
                        break;
                    case Command.unpark:
                        UnParkCommand(carManager, arguments);
                        break;
                    case Command.tune:
                        TuneCommand(carManager, arguments);
                        break;
                    case Command.start:
                        StartCommand(carManager, arguments);
                        break;
                }
            }
        }

        private static void StartCommand(CarManager carManager, string[] arguments)
        {
            var id = int.Parse(arguments[1]);
            Console.WriteLine(carManager.Start(id));
        }

        private static void TuneCommand(CarManager carManager, string[] arguments)
        {
            var index = int.Parse(arguments[1]);
            var addOn = arguments[2];
            carManager.Tune(index, addOn);
        }

        private static void UnParkCommand(CarManager carManager, string[] arguments)
        {
            var carId = int.Parse(arguments[1]);
            carManager.Unpark(carId);
        }

        private static void ParkCommand(CarManager carManager, string[] arguments)
        {
            var carId = int.Parse(arguments[1]);
            carManager.Park(carId);
        }

        private static void ParticipateCommand(CarManager carManager, string[] arguments)
        {
            var carId = int.Parse(arguments[1]);
            var raceId = int.Parse(arguments[2]);
            carManager.Participate(carId, raceId);
        }

        private static void CheckCommand(CarManager carManager, string[] arguments)
        {
            Console.WriteLine(carManager.Check(int.Parse(arguments[1])));
        }

        private static void OpenCommand(CarManager carManager, string[] arguments)
        {
            var id = int.Parse(arguments[1]);
            var type = arguments[2];
            var length = int.Parse(arguments[3]);
            var route = arguments[4];
            var prizePool = int.Parse(arguments[5]);
            carManager.Open(id, type, length, route, prizePool);
        }

        private static void RegisterCommand(CarManager carManager, string[] arguments)
        {
            var id = int.Parse(arguments[1]);
            var type = arguments[2];
            var brand = arguments[3];
            var model = arguments[4];
            var year = int.Parse(arguments[5]);
            var horsePower = int.Parse(arguments[6]);
            var acceleration = int.Parse(arguments[7]);
            var suspension = int.Parse(arguments[8]);
            var durability = int.Parse(arguments[9]);

            carManager.Register(id, type, brand, model, year, horsePower, acceleration, suspension, durability);
        }
    }
}
