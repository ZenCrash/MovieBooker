using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.IO;
using MovieBooker.DataAccess.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace MovieBooker.DataAccess
{
    public class MovieBookerContext : IdentityDbContext<User>
    {
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Role> Roles { get; set; }

        private readonly string _databaseName = "MovieBookerDB";

        public MovieBookerContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer($"Server=.\\SQLExpress;Database={_databaseName};Trusted_Connection=True;TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
