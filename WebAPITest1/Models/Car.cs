﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPITest1.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Color { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
    }
}