using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPMongodb.Models
{
    public class DiscoutCode
    {
        public string _id { get; set; }
        public int CodeId { get; set; }
        public string CodeName { get; set; }
        public int Price { get; set; }
        public DateTime Cretate_At { get; set; }
        public DateTime Update_At { get; set; }
      
    }
}
