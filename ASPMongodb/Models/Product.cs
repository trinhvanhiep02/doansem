using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPMongodb.Models
{
    public class Product
    {
        public int _id { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string CategoryId { get; set; }
        public string Images { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public string Content { get; set; }
        public bool Status { get; set; }
    }
}
