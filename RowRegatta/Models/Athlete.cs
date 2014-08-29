using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RowRegattaTracker.Models
{
    public class Athlete
    {
        public Int32 AthleteID { get; set; }
        public String Name { get; set; }
        public virtual Int32 TeamID { get; set; }
    }
}
