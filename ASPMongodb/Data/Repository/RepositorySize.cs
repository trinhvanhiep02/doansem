using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPMongodb.Models;
using MongoDB.Driver;

namespace ASPMongodb.Data.Repository
{
    public class RepositorySize : IRepositorySize
    {
        ShopDbContext db;
        public RepositorySize(ShopDbContext db)
        {
            this.db = db;
        }

        public bool Delete(string entity)
        {
            throw new NotImplementedException();
        }

        public List<Size> GetAll()
        {
            return db.Sizes.Find(FilterDefinition<Size>.Empty).ToList();
        }

        public Size GetById(string key)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Size entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(Size entity)
        {
            throw new NotImplementedException();
        }
    }
}
