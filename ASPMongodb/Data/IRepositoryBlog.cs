using ASPMongodb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPMongodb.Data
{
    interface IRepositoryBlog : IRepositoryGenneric<Blog, string>
    {
    }
}
