﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerApplication.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public int Age { get; set; }
        public long Contact { get; set; }
        public string City { get; set; }
    }
}