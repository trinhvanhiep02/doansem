using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPMongodb.Models
{
    public class Account
    {
        public int _id { get; set; }
        public int AccountId { get; set; }
        public string AccountName { get; set; }
        public string Gmail { get; set; }
        public int Phone { get; set; }
        public string Address { get; set; }
        public bool Role { get; set; }
        public bool Status { get; set; }
    }
}
