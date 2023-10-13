using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Entities.Models
{
    public class Audit : IEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        public string? UserName { get; set; }
        public string? CompanyName { get; set; }
        public string? Details { get; set; }
        public DateTime? DateEntry { get; set; }
    }
}
