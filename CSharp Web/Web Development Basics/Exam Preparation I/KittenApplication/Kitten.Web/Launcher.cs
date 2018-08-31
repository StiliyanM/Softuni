namespace KittenApp.Web
{
    using Data;
    using SimpleMvc.Framework;
    using SimpleMvc.Framework.Routers;

    class Launcher
    {
        static void Main(string[] args)
        {

            var server = new WebServer.WebServer(1337, new ControllerRouter(), new ResourceRouter());

            MvcEngine.Run(server, new KittenDbContext());
        }
    }
}
