using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPMongodb.Models;
using MongoDB.Driver;

namespace ASPMongodb.Data.Repository
{
    public class RepositoryBlog : IRepositoryBlog
    {
        ShopDbContext db;
        public RepositoryBlog(ShopDbContext db)
        {
            this.db = db;
        }

        public bool Delete(string entity)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetAll()
        {
            return db.Blogs.Find(FilterDefinition<Blog>.Empty).ToList();
        }

        public Blog GetById(string key)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Blog entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(Blog entity)
        {
            throw new NotImplementedException();
        }
    }
}
