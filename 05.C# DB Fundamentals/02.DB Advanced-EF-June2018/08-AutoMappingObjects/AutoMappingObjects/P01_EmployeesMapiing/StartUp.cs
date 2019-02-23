using EmployeesMapiing.App;
using EmployeesMapiing.App.Core;
using EmployeesMapiing.App.Core.Contracts;
using EmployeesMapiing.App.Core.Controllers;
using EmployeesMapping.Data;
using EmployeesMapping.Services;
using EmployeesMapping.Services.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using AutoMapper;
using EmployeesMapping.App.Core;
using EmployeesMapping.App.Core.Contracts;
using EmployeesMapping.App.Core.Controllers;

namespace P01_EmployeesMapiing
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var service = ConfigureService();
            IEngine engine = new Engine(service);
            engine.Run();
            
        }

        private static IServiceProvider ConfigureService()
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddAutoMapper(conf => conf.AddProfile<EmployeesMappingProfile>());

            serviceCollection.AddDbContext<EmployeesMappingContext>(opts => opts.UseSqlServer(Configuration.ConnectionString));

            serviceCollection.AddTransient<IDbInitializerService, DbInitializerService>();

            serviceCollection.AddTransient<ICommandInterpreter, CommandIntrepreter>();

            serviceCollection.AddTransient<IEmployeeController, EmployeeController>();

            serviceCollection.AddTransient<IManagerController, ManagerController>();



            var serviceProvider = serviceCollection.BuildServiceProvider();

            return serviceProvider;
        }
    }
}
