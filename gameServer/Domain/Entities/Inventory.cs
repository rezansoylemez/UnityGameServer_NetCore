using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using Core.Domain.Models;

namespace  Domain.Entities;
public class Inventory
{
    [BsonRepresentation(BsonType.ObjectId)]
    [BsonElement("InventoryId")]
    public string PlayerId { get; set; }
    public Player Player { get; set; }
}
