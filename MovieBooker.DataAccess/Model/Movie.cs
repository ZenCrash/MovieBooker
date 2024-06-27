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
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string PosterUrl { get; set; }
        public string PosterUri { get; set; }
        public DateTime ReleaseDate { get; set; }
        public ICollection<Cinema> Cinemas { get; set; } = new List<Cinema>();
        public ICollection<Category> Categories { get; set; } = new List<Category>();
        public ICollection<Tag> Tags { get; set; } = new List<Tag>();
    }
    public class MovieConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            //Properties
            builder.Property(e => e.Name).HasMaxLength(200).IsRequired();
            builder.Property(e => e.Description).HasMaxLength(2000);
            builder.Property(e => e.PosterUrl).HasMaxLength(2000);
            builder.Property(e => e.PosterUri).HasMaxLength(2000);
            //Relationships
            builder.HasMany(e => e.Categories).WithMany(i => i.Movies);
            builder.HasMany(e => e.Tags).WithMany(i => i.Movies);
        }
    }
}
