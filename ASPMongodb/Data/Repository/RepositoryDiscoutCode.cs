using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPMongodb.Models;
using MongoDB.Driver;

namespace ASPMongodb.Data.Repository
{
    public class RepositoryDiscoutCode : IRepositoryDiscoutCode
    {
        ShopDbContext db;
        public RepositoryDiscoutCode(ShopDbContext db)
        {
            this.db = db;
        }

        public bool Delete(int entity)
        {
            throw new NotImplementedException();
        }

        public List<DiscoutCode> GetAll()
        {
            return db.DiscoutCodes.Find(FilterDefinition<DiscoutCode>.Empty).ToList();
        }

        public DiscoutCode GetById(int key)
        {
            throw new NotImplementedException();
        }

        public bool Insert(DiscoutCode entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(DiscoutCode entity)
        {
            throw new NotImplementedException();
        }
    }
}
