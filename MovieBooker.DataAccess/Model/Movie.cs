﻿using System;
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
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string PosterUrl { get; set; }
        [Required]
        public DateTime ReleaseDate { get; set; }
        public ICollection<Category> Categories { get; set; } = new List<Category>();
        public ICollection<Tag> Tags { get; set; } = new List<Tag>();
        public ICollection<Runtime> Runtimes { get; set; } = new List<Runtime>();
        public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
    }
}