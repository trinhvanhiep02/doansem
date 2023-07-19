using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPMongodb.Models;
using MongoDB.Driver;

namespace ASPMongodb.Data.Repository
{
    public class RepositoryProductDetail : IRepositoryProductDetail
    {
        ShopDbContext db;
        public RepositoryProductDetail(ShopDbContext db)
        {
            this.db = db;
        }

        public bool Delete(int entity)
        {
            throw new NotImplementedException();
        }

        public List<ProductDetail> GetAll()
        {
            return db.ProductDetails.Find(FilterDefinition<ProductDetail>.Empty).ToList();
        }

        public ProductDetail GetById(int key)
        {
            throw new NotImplementedException();
        }

        public bool Insert(ProductDetail entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(ProductDetail entity)
        {
            throw new NotImplementedException();
        }
    }
}
