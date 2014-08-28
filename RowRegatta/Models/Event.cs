using System;
using System.Collections.Generic;
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
        
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public List<Race> Race { get; set; }
    }
}