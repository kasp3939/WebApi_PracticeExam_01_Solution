using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiWebApplication.Models
{
    public class Bid
    {
        public int ItemNumber { get; set; }
        public string CustomName { get; set; }
        public string Phone { get; set; }
        public decimal Price { get; set; }
    }
}