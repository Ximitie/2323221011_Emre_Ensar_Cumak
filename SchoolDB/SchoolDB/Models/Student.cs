using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SchoolDatabase.Models
{
    public class Student
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = string.Empty;

        [BsonElement("Name")]
        public string Name { get; set; } = string.Empty;

        [BsonElement("Age")]
        public int Age { get; set; }

        [BsonElement("Grade")]
        public string Grade { get; set; } = string.Empty;
    }
}