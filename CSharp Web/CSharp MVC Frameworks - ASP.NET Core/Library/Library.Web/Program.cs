namespace Library.Web
{
    using Microsoft.AspNetCore;
    using Microsoft.AspNetCore.Hosting;
    using Serilog;
    using Serilog.Events;

    public class Program
    {
        public static void Main(string[] args)
        {
           // Log.Logger = new LoggerConfiguration()
           //.MinimumLevel.Debug()
           //.MinimumLevel.Override("Microsoft", LogEventLevel.Information)
           //.Enrich.FromLogContext()
           //.WriteTo.File("/Desktop")
           //.CreateLogger();
        
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
