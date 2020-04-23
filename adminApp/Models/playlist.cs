using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace adminApp.Models
{
    public class playlist
    {
        public long id { get; set; }
        public string playlist_name { get; set; }
        public string playlist_url { get; set; }
    }
}