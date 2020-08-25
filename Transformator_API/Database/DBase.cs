using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Transformator_API.Models;

namespace Transformator_API.Database
{
    public class DBase : DbContext
    {
        public DbSet<Transformator> TBL_TRANSFORMERS {get;set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();
            optionsBuilder.UseOracle(configuration.GetConnectionString("OracleConnection"), options => options.UseOracleSQLCompatibility("11"));
            //optionsBuilder.UseSqlServer();
        }
    }
}
