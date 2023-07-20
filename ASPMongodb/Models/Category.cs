using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPMongodb.Models
{
    public class Category
    {
        public string _id { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool Status { get; set; }
        
    }
}
