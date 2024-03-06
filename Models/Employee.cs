using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Apiemployee.Models
{
    public class Employee
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string empId { get; set; } = string.Empty;

        [BsonElement("empName")]
        public string empName { get; set; } = string.Empty;

        [BsonElement("empQualification")]
        public string empQualification { get; set; } = string.Empty;

        [BsonElement("empAge")]
        public int empAge { get; set; }

        [BsonElement("empGender")]
        public string empGender { get; set; } = string.Empty;

        [BsonElement("empYoP")]
        public string empYoP { get; set; } = string.Empty;
  
    }
}
