using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPMongodb.Models
{
    public class ProductDetail
    {
        public int _id { get; set; }
        public int ProductDetailId { get; set; }
        public int ColorId { get; set; }
        public int SizeId { get; set; }
        public int Quantity_Product { get; set; }
       
    }
}
