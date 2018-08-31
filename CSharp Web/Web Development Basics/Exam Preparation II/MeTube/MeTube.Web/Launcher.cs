namespace MeTube.Web
{
    using SimpleMvc.Framework;
    using SimpleMvc.Framework.Routers;
    using Data;

    class Launcher
    {
        static void Main()
        {
            var server = new WebServer.WebServer(1337, new ControllerRouter(), new ResourceRouter());

            MvcEngine.Run(server, new MeTubeDbContext());
        }
    }
}
