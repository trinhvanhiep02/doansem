using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPMongodb.Models;
using MongoDB.Driver;

namespace ASPMongodb.Data.Repository
{
    public class RepositoryProduct : IRepositoryProduct
    {
        ShopDbContext db;
        public RepositoryProduct(ShopDbContext db)
        {
            this.db = db;
        }

        public bool Delete(int entity)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return db.Products.Find(FilterDefinition<Product>.Empty).ToList();
        }

        public Product GetById(int key)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Product entity)
        {
            throw new NotImplementedException();
        }

        public List<Product> Paping(int page, int pagesize, out long totalrows)
        {
            throw new NotImplementedException();
        }

        public List<Product> SearchPaging(string name, int page, int pagesize, out long totalrows)
        {
            throw new NotImplementedException();
        }

        public bool Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
