using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Models
{
    using Contracts;

    public class Logger : ILogger
    {
        private ICollection<IAppender> appenders = new List<IAppender>();

        public IReadOnlyCollection<IAppender> Appenders => (IReadOnlyCollection<IAppender>)appenders;

        public Logger(ICollection<IAppender> appenders)
        {
            this.appenders = appenders;
        }
        public void Log(IError error)
        {
            foreach (var appender in this.appenders)
            {
                appender.Append(error);
            }
        }
    }
}
