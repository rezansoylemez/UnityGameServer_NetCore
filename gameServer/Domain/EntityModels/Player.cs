using Core.Persistence.Models;
using MongoDB.Bson;

namespace Domain.EntityModels;
public class Player:Entity
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int? Level { get; set; }
    public Player()
    {
            
    }
    public Player(ObjectId id ,string? firstName, string? lastName, int? level):this()
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Level = level;
    }
}
