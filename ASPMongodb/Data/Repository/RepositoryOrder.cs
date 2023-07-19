using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPMongodb.Models;
using MongoDB.Driver;

namespace ASPMongodb.Data.Repository
{
    public class RepositoryOrder : IRepositoryOrder
    {
        ShopDbContext db;
        public RepositoryOrder(ShopDbContext db)
        {
            this.db = db;
        }

        public bool Delete(int entity)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetAll()
        {
            return db.Orders.Find(FilterDefinition<Order>.Empty).ToList();
        }

        public Order GetById(int key)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Order entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(Order entity)
        {
            throw new NotImplementedException();
        }
    }
}
