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
        [Required]
        public Room Room { get; set; }
        public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
    }
}
