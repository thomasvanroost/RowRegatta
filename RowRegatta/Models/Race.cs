using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RowRegattaTracker.Models
{
    public class Race
    {
        public Int32 RaceID { get; set; }
        public String Category { get; set; }
        public DateTime Start { get; set; }
        public Category Categories { get; set; }
    }
}