﻿using System;
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
        public decimal PingX { get; set; }
        public decimal PingY { get; set; }
    }
}