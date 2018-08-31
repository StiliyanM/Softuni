namespace Library.Web.Filters
{
    using Microsoft.AspNetCore.Mvc.Filters;
    using Microsoft.Extensions.Logging;
    using System;
    using Serilog;
    public class ExceptionLogging : IExceptionFilter
    {
        private readonly ILogger<ExceptionLogging> logger;

        public ExceptionLogging(ILogger<ExceptionLogging> logger)
        {
            this.logger = logger;
        }

        public void OnException(ExceptionContext context)
        {
            var exceptionType = context.Exception;
            var stackTrace = context.Exception.StackTrace;

            logger.LogError($"Type: {exceptionType}" + Environment.NewLine + $"Trace: {stackTrace}");
            
        }
    }
}
