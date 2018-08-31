namespace Library.Web.Filters
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Filters;
    using System;

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class AuthorizeAttribute : Attribute, IPageFilter, IActionFilter
    {
        private byte[] sample;
        //private readonly ITempDataDictionaryFactory tempDataDictionaryFactory;

        public AuthorizeAttribute()
        {
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.HttpContext.Session.TryGetValue("__User__",out sample))
            {
                //var tempdata = this.tempDataDictionaryFactory.GetTempData(context.HttpContext);
                //tempdata["Error"] = "You need to be logged in for this operation!";
                context.Result = new RedirectToActionResult("Login","Users", new object { });
            }
        }

        public void OnPageHandlerExecuted(PageHandlerExecutedContext context)
        {
        }

        public void OnPageHandlerExecuting(PageHandlerExecutingContext context)
        {
            if (!context.HttpContext.Session.TryGetValue("__User__", out sample))
            {
                //var tempdata = this.tempDataDictionaryFactory.GetTempData(context.HttpContext);
                //tempdata["Error"] = "You need to be logged in for this operation!";
                context.Result = new RedirectToActionResult("Login", "Users", new object { });
            }
        }

        public void OnPageHandlerSelected(PageHandlerSelectedContext context)
        {
        }
    }
}
