using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RowRegattaTracker.Models
{
    public class Team
    {
        public Int32 TeamID { get; set; }
        public String Name { get; set; }
        public String Country { get; set; }
        public String Couch { get; set; }
        //public List<Person> Members { get; set;}
    }
}
