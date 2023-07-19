using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPMongodb.Models;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace ASPMongodb.Data
{
    public class ShopDbContext
    {
        IConfiguration Configuration;

        public ShopDbContext(IConfiguration Configuration)
        {
            this.Configuration =  Configuration;
        }
        public IMongoDatabase Connection
        {
            get
            {
                var client = new MongoClient(Configuration.GetConnectionString("MongoConnection"));
                var database = client.GetDatabase(Configuration.GetConnectionString("database"));
                return database;
            }
        }
       
        public IMongoCollection<Account> Accounts => Connection.GetCollection<Account>("accounts");
        public IMongoCollection<Blog> Blogs => Connection.GetCollection<Blog>("blogs");
        public IMongoCollection<Brands> Brands => Connection.GetCollection<Brands>("brands");
        public IMongoCollection<Category> Categories => Connection.GetCollection<Category>("categories");
        public IMongoCollection<Color> Colors => Connection.GetCollection<Color>("colors");
        public IMongoCollection<Comment> Comments => Connection.GetCollection<Comment>("comments");
        public IMongoCollection<Contact> Contacts => Connection.GetCollection<Contact>("contacts");
        public IMongoCollection<DiscoutCode> DiscoutCodes => Connection.GetCollection<DiscoutCode>("discoutCodes");
        public IMongoCollection<Order> Orders => Connection.GetCollection<Order>("orders");
        public IMongoCollection<OrderDetail> OrderDetails => Connection.GetCollection<OrderDetail>("orderDetails");
        public IMongoCollection<Product> Products => Connection.GetCollection<Product>("products");
        public IMongoCollection<ProductDetail> ProductDetails => Connection.GetCollection<ProductDetail>("productDetails");
        public IMongoCollection<Size> Sizes => Connection.GetCollection<Size>("sizes");

    }
}
