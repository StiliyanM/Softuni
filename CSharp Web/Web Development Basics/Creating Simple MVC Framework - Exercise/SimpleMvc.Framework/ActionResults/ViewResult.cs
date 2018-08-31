namespace SimpleMvc.Framework.ActionResults
{
    using Contracts;

    public class ViewResult : IViewable
    {
        public ViewResult(IRenderable view)
        {
            View = view;
        }

        public IRenderable View { get; set; }

        public string Invoke()
        {
            return this.View.Render();
        }
    }
}
