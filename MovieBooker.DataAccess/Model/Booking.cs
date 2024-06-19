﻿using System;
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
        [Required]
        public DateTime FromDateTime { get; set; }
        [Required]
        public DateTime ToDateTime { get; set; }
        [Required]
        public User User { get; set; }
        [Required]
        public Cinema Cinema { get; set; }
        [Required]
        public Runtime Runtime { get; set; }
        [Required]
        public Room Room { get; set; }
        public ICollection<Seat> Seats { get; set; }
        [Required]
        public Movie Movie { get; set; }
    }
}
