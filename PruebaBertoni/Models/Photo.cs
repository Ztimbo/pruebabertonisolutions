using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaBertoni.Models
{
    public class Photo
    {
        public int id { get; set; }
        public string title { get; set; }
        public string url { get; set; }
        public string thumbnailUrl { get; set; }
        public string albumId { get; set; }

        public Album Album { get; set; }
    }
}