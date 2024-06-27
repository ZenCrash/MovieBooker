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
    public class Booking
    {
        public int Id { get; set; }
        public User User { get; set; }
        public Runtime Runtime { get; set; }
        public ICollection<Seat> Seats { get; set; } = new List<Seat>();
    }
    public class BookingConfiguration : IEntityTypeConfiguration<Booking>
    {
        public void Configure(EntityTypeBuilder<Booking> builder)
        {
            //Properties
            //Relationships
        }
    }
}
