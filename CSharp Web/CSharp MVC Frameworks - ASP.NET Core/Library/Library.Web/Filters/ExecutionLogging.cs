namespace Library.Web.Filters
{
    using Microsoft.AspNetCore.Mvc.Filters;
    using Microsoft.Extensions.Logging;
    using System.Diagnostics;

    public class ExecutionLogging : IPageFilter, IActionFilter
    {
        private readonly ILogger<ExecutionLogging> logger;
        private readonly Stopwatch stopwatch;

        public ExecutionLogging(ILogger<ExecutionLogging> logger, Stopwatch stopwatch)
        {
            this.logger = logger;
            this.stopwatch = stopwatch;
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
            this.LogExecutedMessage(context.HttpContext.Request.Method, context.ActionDescriptor.DisplayName);
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            this.LogExecutingMessage(context.HttpContext.Request.Method, context.ActionDescriptor.DisplayName, context.ModelState.IsValid);
        }

        public void OnPageHandlerExecuted(PageHandlerExecutedContext context)
        {
            this.LogExecutedMessage(context.HttpContext.Request.Method,context.ActionDescriptor.DisplayName);
        }

        public void OnPageHandlerExecuting(PageHandlerExecutingContext context)
        {
            this.LogExecutingMessage(context.HttpContext.Request.Method, context.ActionDescriptor.DisplayName, context.ModelState.IsValid);
        }

        public void OnPageHandlerSelected(PageHandlerSelectedContext context)
        {
        }

        private void LogExecutingMessage(string httpMethod, string actionName, bool isModelValid)
        {
            this.stopwatch.Restart();

            this.logger.LogInformation($"Executing {httpMethod} {actionName}");
            this.logger.LogInformation($"Model State: {(isModelValid ? "valid" : "invalid")}");
        }

        private void LogExecutedMessage(string httpMethod, string actionName)
        {
            this.stopwatch.Stop();

            var seconds = this.stopwatch.Elapsed.TotalSeconds;

            this.logger.LogInformation($"Executed {httpMethod} {actionName} in {seconds:f2} s.");
        }
    }
}
