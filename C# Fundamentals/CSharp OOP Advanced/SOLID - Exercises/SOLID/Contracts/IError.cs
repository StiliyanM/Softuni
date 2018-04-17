namespace SOLID.Contracts
{
    using Enums;
    using System;

    public interface IError
    {
        ReportLevel? Level { get; }

        DateTime Time { get; }

        string Message { get; }
    }
}