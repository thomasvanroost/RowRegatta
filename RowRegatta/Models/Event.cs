using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RowRegattaTracker.Models
{
    public class Event
    {
        public Int32 EventID { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public String Location { get; set; }
       
        [DataType(DataType.Date)]
        public DateTime? StartTime { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime? EndTime { get; set; }

        //public virtual Race Race { get; set; }
        public List<Race> Races { get; set; }
    }
}