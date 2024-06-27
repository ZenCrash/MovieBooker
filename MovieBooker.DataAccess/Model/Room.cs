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
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Capacity { get; set; }
        public int HandicapCapacity { get; set; }
        public Cinema Cinema { get; set; }
        public Seat Seat { get; set; }
    }

    public class RoomConfiguration : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            //Properties
            builder.Property(e => e.Name).HasMaxLength(200).IsRequired();
            //Relationships
            builder.HasOne(e => e.Cinema).WithMany();
        }
    }
}
