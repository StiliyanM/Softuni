using System;

namespace SOLID
{
    using Contracts;
    using Factories;
    using System.Collections.Generic;
    using Models;
    class StartUp
    {
        static AppenderFactory appenderFactory = new AppenderFactory();
        static void Main()
        {
           var logger = InitializeLogger();

            var engine = new Engine(logger);

            engine.Run();
        }

        private static ILogger InitializeLogger()
        {
            int count = int.Parse(Console.ReadLine());

            var appenders = new List<IAppender>();

            for (int i = 0; i < count; i++)
            {
                var arguments = Console.ReadLine().Split();

                var appenderType = arguments[0];
                var layoutType = arguments[1];
                var reportLevel = "INFO";

                if(arguments.Length == 3)
                {
                    reportLevel = arguments[2];
                }

                IAppender appender = appenderFactory.CreateAppender(appenderType, layoutType, reportLevel);

                appenders.Add(appender);
            }

            return new Logger(appenders);
        }
    }
}
