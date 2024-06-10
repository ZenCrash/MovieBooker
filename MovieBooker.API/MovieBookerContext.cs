using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MovieBooker.API.Model;

namespace MovieBooker.API
{
    public class MovieBookerContext : IdentityDbContext<User, Role, string>
    {
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Role> Roles { get; set; }

        private readonly string _databaseName = "MovieBookerDB";

       

        public MovieBookerContext(DbContextOptions<MovieBookerContext> options) : base(options) 
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
