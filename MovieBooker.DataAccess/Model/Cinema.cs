using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBooker.DataAccess.Model
{
    public class Cinema
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; }
        public string TimeZone { get; set; } = null!;
        public Address Address { get; set; }
        public ICollection<OpeningTime> OpeningTimes { get; set; } = new List<OpeningTime>();
        public ICollection<Room> Rooms { get; set; } = new List<Room>();
        public ICollection<Movie> Movies { get; set; } = new List<Movie>();
        public ICollection<Runtime> Runtimes { get; set; } = new List<Runtime>();
        //TODO Lastupdated and updatedby 
    }   

    public class CinemaConfiguration : IEntityTypeConfiguration<Cinema>
    {
        public void Configure(EntityTypeBuilder<Cinema> builder)
        {
            //Properties
            builder.Property(e => e.Name).HasMaxLength(100);
            builder.Property(e => e.Description).HasMaxLength(2000);
            builder.Property(e => e.TimeZone).HasMaxLength(100);
            //Relationships (has many with one ondelete)
            builder.HasOne(e => e.Address).WithOne().OnDelete(DeleteBehavior.Cascade);
        }
    }
}
