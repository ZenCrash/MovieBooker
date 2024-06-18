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
        [Required]
        public DateTime FromDateTime { get; set; }
        [Required]
        public DateTime ToDateTime { get; set; }
        public User User { get; set; }
        public Cinema Cinema { get; set; }
        public Runtime Runtime { get; set; }
        public Movie Movie { get; set; }
        public Seat Seat { get; set; }
    }
}
