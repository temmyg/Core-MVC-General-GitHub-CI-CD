using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core_MVC_General.EFContext;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Core_MVC_General
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IHost host = CreateHostBuilder(args).Build();

            //using (var scope = host.Services.CreateScope())
            //{
            //    var serviceProvider = scope.ServiceProvider;
            //    LaunchCompanyContext dbContext = serviceProvider.GetRequiredService<LaunchCompanyContext>();

            //    dbContext.Database.EnsureCreated();

            //    //InitializeDb(dbContext);

            //    dbContext.SaveChanges();
            //}

            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

        public static void InitializeDb(LaunchCompanyContext dbContext)
        {
            dbContext.LaunchCenters.Add(new LaunchCenter { ID = "101", Commander = "Jeck" });
            dbContext.LaunchCenters.Add(new LaunchCenter { ID = "103", Commander = "Mori" });

            dbContext.Staffs.Add(new Staff { StaffID = 11, Name = "Charlie", LaunchCenterID = "101" });
            dbContext.Staffs.Add(new Staff { StaffID = 13, Name = "Alex", LaunchCenterID = "101" });
            dbContext.Staffs.Add(new Staff { StaffID = 15, Name = "Nathen", LaunchCenterID = "103" });
        }
    }
}
