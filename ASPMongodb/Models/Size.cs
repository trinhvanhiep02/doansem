using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPMongodb.Models
{
    public class Size
    {
        public string _id { get; set; }
        public int SizeId { get; set; }
        public string SizeName { get; set; }
        public bool Status { get; set; }
        
    }
}
