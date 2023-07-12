using Core.AuthSecurity.Entities;
using Domain.Entities;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Core.Domain.Models;
public class Player:User
{ 
    public int? Level { get; set; }
    public string? XPosition { get; set; }
    public string? YPosition { get; set; }
    public int? Rank { get; set; }
     

    [BsonRepresentation(BsonType.ObjectId)]
    [BsonElement("InventoryId")]
    public string? InventoryId { get; set; }
    public Inventory Inventory { get; set; }
    public Player()
    {
        Level = 0;
        XPosition = string.Empty;
        YPosition = string.Empty;
        Rank = 1;
        InventoryId = string.Empty;
    }

    public Player(ObjectId id,int? level, string xPosition, string yPosition, int rank, string ınventoryId, Inventory ınventory):base ()
    {
        Id=id;
        Level = level;
        XPosition = xPosition;
        YPosition = yPosition;
        Rank = rank; 
        InventoryId = ınventoryId;
        Inventory = ınventory;
    }
}
