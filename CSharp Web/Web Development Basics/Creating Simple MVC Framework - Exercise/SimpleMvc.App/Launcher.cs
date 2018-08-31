namespace SimpleMvc.App
{
    using Framework;
    using Framework.Routers;
    using WebServer;
    using Services;

    class Launcher
    {
        static void Main()
        {
            var server = new WebServer(1337,new ControllerRouter(), new ResourceRouter());

            var database = new DatabaseInitializerService();

            database.Initialize();

            MvcEngine.Run(server);
        }
    }
}
