using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace tigris_mongodb_dotnet_example.Models
{
    public class Game
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Name")]
        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Category { get; set; }

    }
}