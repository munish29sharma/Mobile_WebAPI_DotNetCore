using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace WebAPI.Models
{
    public class APIDBContext:DbContext
    {

        private readonly IConfiguration config;

     

        public APIDBContext(DbContextOptions<APIDBContext> options)
            : base(options)
        {

            
        }

        public APIDBContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            //Install-Package Microsoft.EntityFrameworkCore.SqlServer -Version 1.1.2
            optionsBuilder.UseSqlServer(@"data source=Amicus16;Database=Test;User Id=sa;Password=Password01");
        }

        public DbSet<User> user { get; set; }
        

        public DbSet<UserProject> userProject { get; set; }



    }
}
