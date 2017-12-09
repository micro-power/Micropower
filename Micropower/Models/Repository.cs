using Micropower.Interfaces;
using Micropower.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Micropower.Models
{
    public class Repository<T> : IRepository<T> where T : IBson
    {
        IMongoCollection<T> collection;
        IMongoClient client;
        public IMongoDatabase Database { get; private set; }
        string collectionName;
        public Repository(string collectionName)
        {
            //client = new MongoClient("mongodb://localhost:27017");
            //Database = client.GetDatabase("MainApp");
            client = new MongoClient("mongodb://admin:Thespartans1_@micropower-shard-00-00-tmycf.mongodb.net:27017,micropower-shard-00-01-tmycf.mongodb.net:27017,micropower-shard-00-02-tmycf.mongodb.net:27017/test?ssl=true&replicaSet=MicroPower-shard-0&authSource=admin");
            Database = client.GetDatabase("MicroPower");
            //database.DropCollection(collectionName);
            this.collectionName = collectionName;
            GetCollection();

        }

        public IEnumerable<T> List()
        {

            return collection.Find(new BsonDocument()).ToEnumerable();
        }

        public IMongoCollection<T> GetCollection()
        {
            return collection = Database.GetCollection<T>(collectionName);
        }

        public T FindById(ObjectId id)
        {
            return collection.Find(x => x.Id == id).FirstOrDefault();
        }

        public IEnumerable<T> FindAllByValue(string propertyName, string value)
        {
            var filter = Builders<T>.Filter.Eq(propertyName, value);
            return collection.Find(filter).ToEnumerable();
        }

        public void Add(T element)
        {
            collection.InsertOne(element);
        }

        public void Update(T element)
        {
            collection.ReplaceOne(x => x.Id == element.Id, element);
        }
        public void Delete(ObjectId id)
        {
            collection.DeleteOne(x => x.Id == id);
        }
    }
}