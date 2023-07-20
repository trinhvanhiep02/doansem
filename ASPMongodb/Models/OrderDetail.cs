using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPMongodb.Models
{
    public class OrderDetail
    {
        public string _id { get; set; }
        public int OderDetailId { get; set; }
        public int ProductDetailId { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        
    }
}
