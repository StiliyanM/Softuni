namespace SimpleMvc.Framework.Routers
{
    using WebServer.Contracts;
    using WebServer.Http.Contracts;
    using System.Collections.Generic;
    using System.Linq;
    using System.Globalization;
    using System.Reflection;
    using System;
    using WebServer.Http.Response;
    using Attributes.Methods;
    using Controllers;
    using Contracts;
    using WebServer.Enums;
    using WebServer.Exceptions;

    public class ControllerRouter : IHandleable
    {
        public IHttpResponse Handle(IHttpRequest request)
        {
            var getParams = new Dictionary<string,string>(request.UrlParameters);
            var postParams = new Dictionary<string,string>(request.FormData);
            var requestMethod = request.Method.ToString().ToUpper();

            var pathParts = request.Path.Split("/?".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            if(pathParts == null || pathParts.Length != 2)
            {
                throw new BadRequestException("Invalid URL!");
            }

            var controllerName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(pathParts.First()) + (MvcContext.Get.ControllersSuffix);
            var actionName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(pathParts[1]);

            Controller controller = this.GetController(controllerName);

            if(controller != null)
            {
                controller.Request = request;
                controller.InitializeController();
            }

            MethodInfo method = this.GetMethod(controller, requestMethod, actionName);

            if (method == null)
            {
                return new NotFoundResponse();
            }

            IEnumerable<ParameterInfo> parameters = method.GetParameters();

            var methodParams = this.AddParameters(parameters, getParams, postParams);

            try
            {
                IHttpResponse response = this.GetResponse(method, controller, methodParams);

                return response;
            }
            catch (Exception ex)
            {
                return new InternalServerErrorResponse(ex);
            }
        }

        private IHttpResponse GetResponse(MethodInfo method, Controller controller, object[] methodParams)
        {
            var actionResult = method.Invoke(controller, methodParams);

            IHttpResponse response = null;

            if(actionResult is IViewable)
            {
                string content = ((IViewable)actionResult).Invoke();

                response = new ContentResponse(HttpStatusCode.Ok, content);
            }
            else if(actionResult is IRedirectable)
            {
                string redirectUrl = ((IRedirectable)actionResult).Invoke();

                response = new RedirectResponse(redirectUrl);
            }

            return response;
        }

        private object[] AddParameters(IEnumerable<ParameterInfo> parameters, Dictionary<string, string> getParams, Dictionary<string, string> postParams)
        {
            int index = 0;

            object[] methodParams = new object[parameters.Count()];

            foreach (ParameterInfo parameter in parameters)
            {
                if (parameter.ParameterType.IsPrimitive || parameter.ParameterType == typeof(string))
                {
                    methodParams[index] = this.ProcessPrimitiveParameter(parameter, getParams);

                    index++;
                }
                else
                {
                    methodParams[index] = this.ProcessComplexParameter(parameter, postParams);

                    index++;                   
                }
            }

            return methodParams;

        }

        private object ProcessComplexParameter(ParameterInfo parameter, Dictionary<string, string> postParams)
        {
            Type bindingModelType = parameter.ParameterType;
            object bindingModel = Activator.CreateInstance(bindingModelType);

            IEnumerable<PropertyInfo> properties = bindingModelType.GetProperties();

            foreach (PropertyInfo property in properties)
            {
                property.SetValue(
                    bindingModel,
                    Convert.ChangeType(
                        postParams[property.Name],
                        property.PropertyType));
            }

            return Convert.ChangeType(
                bindingModel,
                bindingModelType);
        }

        private object ProcessPrimitiveParameter(ParameterInfo parameter, Dictionary<string, string> getParams)
        {
            object value = getParams[parameter.Name];
            return Convert.ChangeType(value, parameter.ParameterType);
        }

        private MethodInfo GetMethod(Controller controller, string requestMethod, string actionName)
        {
            foreach (MethodInfo methodInfo in this.GetSuitableMethods(controller,actionName))
            {
                IEnumerable<Attribute> attributes = methodInfo
                    .GetCustomAttributes()
                    .Where(a => a is HttpMethodAttribute);

                if (!attributes.Any() && requestMethod == "GET")
                {
                    return methodInfo;
                }

                foreach (HttpMethodAttribute attribute in attributes)
                {
                    if (attribute.IsValid(requestMethod))
                    {
                        return methodInfo;
                    }
                }
            }

            return null;
        }

        private IEnumerable<MethodInfo> GetSuitableMethods(Controller controller, string actionName)
        {
            if (controller == null)
            {
                return new MethodInfo[0];
            }

            return
                controller
                .GetType()
                .GetMethods()
                .Where(m => m.Name == actionName);
        }

        private Controller GetController(string controllerName)
        {
            var controllerFullQualifiedName = string.Format(
                "{0}.{1}.{2}, {0}",
                MvcContext.Get.AssemblyName,
                MvcContext.Get.ControllersFolder,
                controllerName);

            Type type = Type.GetType(controllerFullQualifiedName);

            if (type == null)
            {
                return null;
            }

            var controller = (Controller)Activator.CreateInstance(type);

            return controller;
        }
    }
}
