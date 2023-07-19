using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPMongodb.Models
{
    public class Brands
    {
        public int _id { get; set; }
        public int BrandsId { get; set; }
        public string BrandsName { get; set; }
        public bool Status { get; set; }
        
    }
}
