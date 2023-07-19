using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPMongodb.Models;
using MongoDB.Driver;

namespace ASPMongodb.Data.Repository
{
    public class RepositoryOrderdetail:IRepositoryOrderdetail
    {
        ShopDbContext db;
        public RepositoryOrderdetail(ShopDbContext db)
        {
            this.db = db;
        }

        public bool Delete(int entity)
        {
            throw new NotImplementedException();
        }

        public List<OrderDetail> GetAll()
        {
            return db.OrderDetails.Find(FilterDefinition<OrderDetail>.Empty).ToList();
        }

        public OrderDetail GetById(int key)
        {
            throw new NotImplementedException();
        }

        public bool Insert(OrderDetail entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(OrderDetail entity)
        {
            throw new NotImplementedException();
        }
    }
}
