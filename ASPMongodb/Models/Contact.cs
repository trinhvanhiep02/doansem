using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPMongodb.Models
{
    public class Contact
    {
        public string _id { get; set; }
        public int ContactId { get; set; }
        public string ContactName { get; set; }
        public string Gmail { get; set; }
        public int Phone { get; set; }
        public string Status { get; set; }
     
    }
}
