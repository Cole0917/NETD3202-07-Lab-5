using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NETD3202Lab5.Models
{
    public class Laptop
    {
        public string name { get; set; }

        public double price { get; set; }

        public string description { get; set; }


        // Default Constructor
        public Laptop()
        {

        }

        // Parameterized Constructor
        public Laptop(string name, double price, string description)
        {

        }

    }
}
}
