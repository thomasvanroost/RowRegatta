using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RowRegatta.Models
{
    public class Result
    {
        public Int32 ResultID { get; set; }
        public Int32 RaceID { get; set; }
        public Int32 TeamID { get; set;}
        public Decimal RaceTime {get; set;}
    }
}