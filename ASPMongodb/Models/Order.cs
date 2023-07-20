using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPMongodb.Models
{
    public class Order
    {
        public string _id { get; set; }
        public int OderDetailId { get; set; }
        public int AccountId { get; set; }
        public string CodeId { get; set; }
        public string Gmail { get; set; }
        public int Phone { get; set; }
        public string Address { get; set; }
        public int Total { get; set; }
        public string Note { get; set; }
        public bool Status { get; set; }
    }
}
