using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Micropower.Interfaces
{
    public interface IRepository<T> where T : IBson
    {
        IMongoDatabase Database { get; }
        void Add(T element);
        void Delete(ObjectId id);
        T FindById(ObjectId id);
        IEnumerable<T> FindAllByValue(string propertyName, string value);
        IEnumerable<T> List();
        void Update(T element);
        IMongoCollection<T> GetCollection();
    }
}