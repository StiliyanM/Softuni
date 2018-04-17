using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Factories
{
    using Contracts;
    using Enums;
    using Models;

    public class AppenderFactory
    {
        private LayoutFactory layoutFactory = new LayoutFactory();

        public IAppender CreateAppender(string appenderType, string layoutType, string reportLevel)
        {
            var layout = layoutFactory.CreateLayout(layoutType);

            var level = ParseLevel(reportLevel);

            switch (appenderType)
            {
                case "ConsoleAppender":
                    return new ConsoleAppender(layout);
                default:
                    throw new ArgumentException("Invalid Appender Type!");
            }
        }

        private ReportLevel ParseLevel(string reportLevel)
        {
            var isValid = Enum.TryParse(reportLevel, out ReportLevel level);

            if (!isValid)
            {
                throw new ArgumentException("Invalid level!");
            }

            return level;
        }
    }
}
