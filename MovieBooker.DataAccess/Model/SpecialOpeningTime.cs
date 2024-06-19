using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBooker.DataAccess.Model
{
    public class SpecialOpeningTime
    {
        public int Id { get; set; }
        //start
        [Required]
        public DayOfWeek FromDayOfWeek { get; set; }
        public TimeSpan FromTime { get; set; }
        //end
        [Required]
        public DayOfWeek ToDayOfWeek { get; set; }
        public TimeSpan ToTime { get; set; }
        [Required]
        public Cinema Cinema { get; set; }
        //TODO Lastupdated and updatedby
    }
}
