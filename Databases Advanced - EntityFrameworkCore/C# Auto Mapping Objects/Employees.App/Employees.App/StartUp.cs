namespace Employees.App
{
    using Microsoft.Extensions.DependencyInjection;
    using System;
    using Employees.Data;
    using Microsoft.EntityFrameworkCore;
    using Employees.Services;
    using AutoMapper;

    class StartUp
    {
        static void Main()
        {
            var serviceProvider = ConfigureServices();
            var engine = new Engine(serviceProvider);

            ResetDatabase();

            engine.Run();
        }

        private static void ResetDatabase()
        {
            using (var db = new EmployeesContext())
            {
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();
            }
        }

        static IServiceProvider ConfigureServices()
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection.
                AddDbContext<EmployeesContext>(options => options.UseSqlServer(Configuration.ConnectionString));

            serviceCollection.AddTransient<EmployeeService>();

            serviceCollection.AddSingleton<CommandParser>();

            serviceCollection.
                AddAutoMapper(cfg => cfg.AddProfile<MappingProfile>());

            var serviceProvider = serviceCollection.BuildServiceProvider();

            return serviceProvider;
        }
    }
}