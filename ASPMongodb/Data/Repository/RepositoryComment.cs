using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPMongodb.Models;
using MongoDB.Driver;

namespace ASPMongodb.Data.Repository
{
    public class RepositoryComment : IRepositoryComment
    {
        ShopDbContext db;
        public RepositoryComment(ShopDbContext db)
        {
            this.db = db;
        }

        public bool Delete(string entity)
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetAll()
        {
            return db.Comments.Find(FilterDefinition<Comment>.Empty).ToList();
        }

        public Comment GetById(string key)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Comment entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(Comment entity)
        {
            throw new NotImplementedException();
        }
    }
}
