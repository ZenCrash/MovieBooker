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
    public class Address
    {
        public int Id { get; set; }
        public string AddressLine { get; set; } = null!;
        public string AddressLine2 {  get; set; }
        public string City { get; set; } = null!;
        public string Region { get; set; } = null!;
        public string PostalCode { get; set; } = null!;
        public string Country { get; set; } = null!;
        public Cinema Cinema { get; set; }
    }

    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            //Properties
            builder.Property(e => e.AddressLine).HasMaxLength(200);
            builder.Property(e => e.AddressLine2).HasMaxLength(200);
            builder.Property(e => e.City).HasMaxLength(200);
            builder.Property(e => e.Region).HasMaxLength(200);
            builder.Property(e => e.PostalCode).HasMaxLength(100);
            builder.Property(e => e.Country).HasMaxLength(200);
            //Relationships
        }
    }
}
