using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Core.Persistence.Models;
public interface IEntity
{
    [BsonId]
    [BsonRepresentation(BsonType.String)]
    ObjectId Id { get; set; }

    DateTime? CreatedDate { get; }
    DateTime? DeletedDate { get; set; }
    DateTime? UpdatedDate { get; set; }
            
    bool? Status { get; set; }
    string? Code { get; set; }

} 
