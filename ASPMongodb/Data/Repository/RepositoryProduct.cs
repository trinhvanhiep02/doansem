using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPMongodb.Models;
using ASPMongodb.Models.ViewModels;
using MongoDB.Bson;
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

        public bool Delete(string key)
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

        public List<Product> GetAll()
        {
            return db.Products.Find(FilterDefinition<Product>.Empty).ToList();
        }

        public Product GetById(string key)
        {

            return db.Products.Find(x => x._id == key).FirstOrDefault();
        }

        public List<ProductViewModel> GetProductFull()
        {
            BsonDocument[] lookup = new BsonDocument[1]
            {
                 new BsonDocument
               {
                   {
                       "$lookup", new BsonDocument
                       {
                           {"from","categories" },
                           {"localField","CategoryId"},
                           {"foreignField","_id"},
                           {"as","categories"}
                       }
                   }

               }
             };
            var products = db.Products.Aggregate<BsonDocument>(lookup).ToList();
            return null;
        } 

        public bool Insert(Product entity)
        {
            db.Products.InsertOne(entity);
            return true;
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
            var p = Builders<Product>.Update
                .Set("ProductName", entity.ProductName)
                .Set("CategoryId", entity.CategoryId)
                .Set("Images", entity.Images)
                .Set("Quantity", entity.Quantity)
                .Set("Price", entity.Price)
                .Set("Content", entity.Content)
                .Set("Status", entity.Status);
                db.Products.UpdateOne(x => x._id == entity._id, p);
            return true;



    }
    }
}
