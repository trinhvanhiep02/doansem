using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPMongodb.Models;
using MongoDB.Driver;

namespace ASPMongodb.Data.Repository
{
    public class RepositoryAccount : IRepositoryAccount
    {
        ShopDbContext db;
        public RepositoryAccount(ShopDbContext db)
        {
            this.db = db;
        }

        public bool Delete(int key)
        {
            try
            {
                db.Products.DeleteOne(x => x._id == key);

            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }

  

        //public bool Delete(string entity)
        //{
        //    throw new NotImplementedException();
        //}

        public List<Account> GetAll()
        {
            return db.Accounts.Find(FilterDefinition<Account>.Empty).ToList();
        }

        public Account GetById(string key)
        {
            throw new NotImplementedException();
        }

        public Account GetById(int key)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Account entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(Account entity)
        {
            throw new NotImplementedException();
        }
    }
}
