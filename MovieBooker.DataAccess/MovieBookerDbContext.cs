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
        public DbSet<Address> Address { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<OpeningTime> OpeningTimes { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Runtime> Runtimes { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<SpecialOpeningTime> SpecialOpeningTimes { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }

        public MovieBookerDbContext(DbContextOptions<MovieBookerDbContext> options) : base(options) 
        { 
        
        }

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
