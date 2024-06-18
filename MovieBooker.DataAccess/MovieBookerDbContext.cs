using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MovieBooker.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBooker.DataAccess
{
    public class MovieBookerDbContext : IdentityDbContext<User, Role, string>
    {
        //Db connectionstring is only for db creation
        //leave blank after model creation
        private readonly string _onModelCreationConnectionString = @"";
        private readonly string _onModelCreationConnectionStringLocalDb = @"Server=.\SQLExpress;Database=MovieBookerDb;Trusted_Connection=True;TrustServerCertificate=True";
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer(_onModelCreationConnectionStringLocalDb);
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }

}
