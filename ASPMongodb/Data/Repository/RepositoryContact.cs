using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPMongodb.Models;
using MongoDB.Driver;

namespace ASPMongodb.Data.Repository
{
    public class RepositoryContact : IRepositoryContact
    {
        ShopDbContext db;
        public RepositoryContact(ShopDbContext db)
        {
            this.db = db;
        }

        public bool Delete(string entity)
        {
            throw new NotImplementedException();
        }

        public List<Contact> GetAll()
        {
            return db.Contacts.Find(FilterDefinition<Contact>.Empty).ToList();
        }

        public Contact GetById(string key)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Contact entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(Contact entity)
        {
            throw new NotImplementedException();
        }
    }
}
