﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03_OOPS
{
    class Customer
    {

        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public Account Aaccount;

        public override string ToString()
        {
            return "CustomerId => " + CustomerId.ToString() + " " + "CustomerName => " + CustomerName + "CustomerEmail =>" + " "+ CustomerEmail;
        }

    }

}
