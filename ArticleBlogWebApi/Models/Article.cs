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

        [BsonElement("Description")]
        public string Description { get; set; }

        [BsonElement("Category")]
        public string Category { get; set; }

        [BsonElement("Author")]
        public string Author { get; set; }

        public DateTime? Created_At{ get; set; }
        public DateTime? Updated_At{ get; set; }
    }
}
