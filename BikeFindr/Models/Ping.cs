using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BikeFindr.Models
{
    public class Ping
    {
        public string PingID { get; set; }
        public string BikeFindrID { get; set; }
        public DateTime PingDateTime { get; set; }
        public long PingX { get; set; }
        public long PingY { get; set; }
    }
}