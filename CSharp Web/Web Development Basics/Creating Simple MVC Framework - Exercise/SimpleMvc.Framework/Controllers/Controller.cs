namespace SimpleMvc.Framework.Controllers
{
    using Contracts;
    using Attributes.Property;
    using System.Runtime.CompilerServices;
    using Models;
    using Views;
    using Security;
    using ActionResults;
    using System.Reflection;
    using System.Linq;
    using WebServer.Http.Contracts;
    using WebServer.Http;

    public abstract class Controller
    {
        protected Controller()
        {
            this.Model = new ViewModel();
            this.User = new Authentication();
        }

        protected ViewModel Model { get; }

        protected internal IHttpRequest Request { get; internal set; }

        protected internal Authentication User { get; internal set; }

        protected internal void InitializeController()
        {
            var user = this.Request.Session.Get<string>(SessionStore.CurrentUserKey);

            if (user != null)
            {
                this.User = new Authentication(user);
            }
        }

        protected IActionResult View([CallerMemberName] string caller = "")
        {
            this.InitializeViewModelData();

            string controllerName = this.GetType()
                .Name
                .Replace(MvcContext.Get.ControllersSuffix, string.Empty);

            string fullQualifiedName = string.Format(
               "{0}\\{1}\\{2}",
               MvcContext.Get.ViewsFolder,
               controllerName,
               caller.ToLower());

            IRenderable view = new View(fullQualifiedName, this.Model.Data);

            return new ViewResult(view);
        }

        private void InitializeViewModelData()
        {
            this.Model["displayType"] = this.User.IsAuthenticated ? "block" : "none";
        }

        protected IRedirectable RedirectToAction(string redirectUrl)
        {
            return new RedirectResult(redirectUrl);
        }

        protected bool IsValidModel(object bindingModel)
        {

            foreach (var property in bindingModel.GetType().GetProperties())
            {
                var attributes = property
                        .GetCustomAttributes()
                        .Where(a => a is PropertyAttribute);

                if (!attributes.Any())
                {
                    continue;
                }

                foreach (PropertyAttribute attribute in attributes)
                {
                    if (!attribute.IsValid(property.GetValue(bindingModel)))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        protected void SignIn(string name)
        {
            this.Request.Session.Add(SessionStore.CurrentUserKey, name);
        }

        protected void SignOut()
        {
            this.Request.Session.Clear();
        }
    }
}
