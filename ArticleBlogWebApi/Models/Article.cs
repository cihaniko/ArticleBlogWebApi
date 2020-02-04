using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArticleBlogWebApi.Models
{
    public class Article : MongoBaseModel
    {

        [BsonElement("Title")]
        public string Title { get; set; }

        public string Description { get; set; }

        public string Category { get; set; }

        public string Author { get; set; }
    }
}
