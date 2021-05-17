using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Forsaj.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Forsaj
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

        public class BloggingContextFactory : IDesignTimeDbContextFactory<ForsajContext>
        {
            public ForsajContext CreateDbContext(string[] args)
            {
                var optionsBuilder = new DbContextOptionsBuilder<ForsajContext>();
             
                optionsBuilder.UseSqlServer(connectionString:
     "Data Source=(localdb)\\ProjectsV13;Initial Catalog=DB_FORSAJ; Integrated Security=True; Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;MultipleActiveResultSets=true"
     );

                return new ForsajContext(optionsBuilder.Options);
            }
        }
    }
}
