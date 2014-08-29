using RowRegatta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RowRegattaTracker.Models
{
    public class Race
    {
        public Int32 RaceID { get; set; }
        public DateTime? Start { get; set; }
        public Int32 CategoryID { get; set; }
        public Int32 EventID { get; set; }
        public ICollection<Event> Events { get; set; }

        public List<Result> Results { get; set; }
    }
}