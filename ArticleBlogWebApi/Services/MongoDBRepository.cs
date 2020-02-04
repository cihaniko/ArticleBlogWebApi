using ArticleBlogWebApi.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArticleBlogWebApi.Services
{


    public class MongoDBRepository<T> : IDBRepository<T> where T : MongoBaseModel
    {
        private readonly IMongoCollection<T> _collection;
        public MongoDBRepository(IDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _collection = database.GetCollection<T>(settings.CollectionName);
        }

        public T Create(T model)
        {
            _collection.InsertOne(model);
            return model;
        }

        public List<T> Get()
        {
            return _collection.Find(model => true).ToList();
        }

        public T Get(string id)
        {
            return _collection.Find<T>(model => model.Id == id).FirstOrDefault();
        }

        public void Remove(T modelIn)
        {
            _collection.DeleteOne(book => book.Id == modelIn.Id);
        }

        public void Remove(string id)
        {
            _collection.DeleteOne(model => model.Id == id);
        }

        public void Update(string id, T model)
        {
            model.Id = id;
            _collection.ReplaceOne(book => book.Id == id, model);

        }
    }
}

