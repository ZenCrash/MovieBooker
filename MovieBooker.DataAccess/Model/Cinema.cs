using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBooker.DataAccess.Model
{
    public class Cinema
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string TimeZone { get; set; }
        public Address Address { get; set; }
        public ICollection<OpeningTime> Openings { get; set; } = new List<OpeningTime>();
        public ICollection<SpecialOpeningTime> SpecialOpenings { get; set; } = new List<SpecialOpeningTime>();
        public ICollection<Movie> Movies { get; set; } = new List<Movie>();
        public ICollection<Room> Rooms { get; set; } = new List<Room>();
        public ICollection<Runtime> Runtimes { get; set; } = new List<Runtime>();
        //TODO Lastupdated and updatedby 
    }
}
