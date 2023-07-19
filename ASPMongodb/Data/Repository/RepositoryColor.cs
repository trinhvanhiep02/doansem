using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPMongodb.Models;
using MongoDB.Driver;

namespace ASPMongodb.Data.Repository
{
    public class RepositoryColor : IRepositoryColor
    {
        ShopDbContext db;
        public RepositoryColor(ShopDbContext db)
        {
            this.db = db;
        }

        public bool Delete(string entity)
        {
            throw new NotImplementedException();
        }

        public List<Color> GetAll()
        {
            return db.Colors.Find(FilterDefinition<Color>.Empty).ToList();
        }

        public Color GetById(string key)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Color entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(Color entity)
        {
            throw new NotImplementedException();
        }
    }
}
