using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace adminApp.Models
{
    public class feedback
    {
        public long id { get; set; }
        public double rec { get; set;}
        public string email { get; set; }
        public string comment { get; set; }
    }
}