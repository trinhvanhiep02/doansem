using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPMongodb.Models;
using MongoDB.Driver;

namespace ASPMongodb.Data.Repository
{
    public class RepositoryBrands : IRepositoryBrand
    {
        ShopDbContext db;
        public RepositoryBrands(ShopDbContext db)
        {
            this.db = db;
        }

        public bool Delete(string entity)
        {
            throw new NotImplementedException();
        }

        public List<Brands> GetAll()
        {
            return db.Brands.Find(FilterDefinition<Brands>.Empty).ToList();
        }

        public Brands GetById(string key)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Brands entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(Brands entity)
        {
            throw new NotImplementedException();
        }
    }
}
