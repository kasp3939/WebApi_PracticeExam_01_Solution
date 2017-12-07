using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace WebApiWebApplication.Models
{
    
    public class AuctionItem
    {
        
        public int ItemNumber { get; set; }
        
        public string ItemDescription { get; set; }
        
        public int RatingPrice { get; set; }
        
        public decimal BidPrice { get; set; }
        
        public string BidCustomName { get; set; }
        
        public string BidCustomPhone { get; set; }
        
        public DateTime BidTimestamp { get; set; }
    }
}