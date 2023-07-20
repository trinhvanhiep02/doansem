using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPMongodb.Models
{
    public class Comment
    {
        public string _id { get; set; }
        public int CommentId { get; set; }
        public int AccountId { get; set; }
        public string Content { get; set; }
        public DateTime DateTime { get; set; }
       
    }
}
