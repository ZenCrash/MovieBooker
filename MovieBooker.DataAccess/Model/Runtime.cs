using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBooker.DataAccess.Model
{
    public class Runtime
    {
        public int Id { get; set; }
        public DateTime FromDateTime { get; set; }
        public DateTime ToDateTime { get; set; }
        public Cinema Cinema { get; set; }
        public Movie Movie { get; set; }
        public Room Room { get; set; }
        public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
    }

    public class RuntimeConfiguration : IEntityTypeConfiguration<Runtime>
    {
        public void Configure(EntityTypeBuilder<Runtime> builder)
        {
            //Properties
            builder.Property(e => e.FromDateTime).IsRequired();
            builder.Property(e => e.ToDateTime).IsRequired();
            //Relationships
            builder.HasOne(e => e.Cinema).WithMany()
        }
    }
}
