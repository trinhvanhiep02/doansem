using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPMongodb.Models
{
    public class Blog
    {
        public string _id { get; set; }
        public int BlogId { get; set; }
        public string Content { get; set; }
        public string images { get; set; }
        public bool Status { get; set; }
    
    }
}
