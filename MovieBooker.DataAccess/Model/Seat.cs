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
    public class Seat
    {
        public int Id { get; set; }
        public int RowNumber { get; set; }
        public int SeatNumber { get; set; }
        public bool HandicapSeat { get; set; }
        public Room Room { get; set; }
        public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
    }

    public class SeatConfiguration : IEntityTypeConfiguration<Seat>
    {
        public void Configure(EntityTypeBuilder<Seat> builder)
        {
            //Properties
            builder.Property(e => e.RowNumber).IsRequired();
            builder.Property(e => e.SeatNumber).IsRequired();
            builder.Property(e => e.HandicapSeat).IsRequired();
            //Relationships
            builder.HasOne(e => e.Room).WithMany().IsRequired();
        }
    }
}
