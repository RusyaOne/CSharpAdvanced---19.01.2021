using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NetCoreWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreWebApp
{
    public class NetCoreWebAppContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(@"D:\Courses\CSharpProfessional\13.NetCore\NetCoreWebApp\NetCoreWebApp")
                .AddJsonFile("appsettings.json")
                .Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("NetCoreWebAppContext"));
        }

        public DbSet<Character> Characters { get; set; }        
    }
}
