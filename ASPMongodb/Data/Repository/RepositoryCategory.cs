using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPMongodb.Models;
using MongoDB.Driver;

namespace ASPMongodb.Data.Repository
{
    public class RepositoryCategory : IRepositoryCategory
    {
        ShopDbContext db;
        public RepositoryCategory(ShopDbContext db)
        {
            this.db = db;
        }

        public bool Delete(int entity)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll()
        {
            return db.Categories.Find(FilterDefinition<Category>.Empty).ToList();
        }

        public Category GetById(int key)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Category entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
