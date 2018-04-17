using System;

namespace SOLID.Models
{
    using Contracts;
    using SOLID.Enums;

    public class Error : IError
    {
        public ReportLevel? Level { get; }

        public DateTime Time { get; }

        public string Message { get; }

        public Error(ReportLevel level, DateTime time, string message)
        {
            this.Level = level;
            this.Time = time;
            this.Message = message;
        }
    }
}
