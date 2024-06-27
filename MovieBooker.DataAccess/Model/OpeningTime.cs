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
    public class OpeningTime
    {
        public int Id { get; set; }
        public DayOfWeek FromDayOfWeek { get; set; }
        public TimeSpan FromTime { get; set; }
        public DayOfWeek ToDayOfWeek { get; set; }
        public TimeSpan ToTime { get; set; }
        public bool IsSpecialOpeningTime { get; set; }
        public Cinema Cinema { get; set; }
        //TODO Lastupdated and updatedby 
    }
    public class OpeningTimeConfiguration : IEntityTypeConfiguration<OpeningTime>
    {
        public void Configure(EntityTypeBuilder<OpeningTime> builder)
        {
            //Properties
            //builder.Property(e => e.FromDayOfWeek);
            //builder.Property(e => e.FromTime);
            //builder.Property(e => e.ToDayOfWeek);
            //builder.Property(e => e.ToTime);
            //builder.Property(e => e.IsSpecialOpeningTime);
            //Relationships
            builder.HasOne(e => e.Cinema).WithMany();
        }
    }
}
