namespace SimpleMvc.Framework.Views
{
    using Contracts;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    public class View : IRenderable
    {
        public const string BaseLayoutFileName = "Layout";

        public const string ContentPlaceholder = "{{{content}}}";

        public const string HtmlExtension = ".html";

        public const string LocalErrorPath = @"\SimpleMvc.Framework\Errors\Error.html";

        private readonly string templateFullQualifiedName;

        private readonly IDictionary<string, string> viewData;

        public View(string templateFullQualifiedName, IDictionary<string, string> viewData)
        {
            this.templateFullQualifiedName = templateFullQualifiedName;
            this.viewData = viewData;
        }

        public string Render()
        {
            string fullHtml = this.ReadFile();

            if (this.viewData.Any())
            {
                foreach (var parameter in this.viewData)
                {
                    fullHtml = fullHtml.Replace($"{{{{{{{parameter.Key}}}}}}}", parameter.Value);
                }
            }

            return fullHtml;
        }

        private string ReadFile()
        {
            string layoutHtml = this.RenderLayoutHtml();

            string templateFullQualifiedNameWithExtension = this.templateFullQualifiedName + HtmlExtension;

            if (!File.Exists(templateFullQualifiedNameWithExtension))
            {
                return AddError("Requested view does not exist!");
            }

            var content = File.ReadAllText(templateFullQualifiedNameWithExtension);
            var result = layoutHtml.Replace(ContentPlaceholder, content);

            return result;
        }

        private string AddError(string message)
        {
            string errorPath = this.GetErrorPath();
            string errorHtml = File.ReadAllText(errorPath);
            this.viewData["error"] = "Requested view does not exist!";
            return errorHtml;
        }

        private string RenderLayoutHtml()
        {
            string layoutHtmlQualifiedName = string.Format(
               "{0}\\{1}{2}",
               MvcContext.Get.ViewsFolder,
               BaseLayoutFileName,
               HtmlExtension
               );

            if (!File.Exists(layoutHtmlQualifiedName))
            {
                return AddError("Layout view does not exist!");
            }

            string layoutHtmlFileContent = File.ReadAllText(layoutHtmlQualifiedName);

            return layoutHtmlFileContent;
        }

        private string GetErrorPath()
        {
            string appDirectoryPath = Directory.GetCurrentDirectory();
            DirectoryInfo parentDirectory = Directory.GetParent(appDirectoryPath);
            string parentDirectoryPath = parentDirectory.FullName;

            string errorPagePath = parentDirectoryPath + LocalErrorPath;

            return errorPagePath;
        }

    }
}
