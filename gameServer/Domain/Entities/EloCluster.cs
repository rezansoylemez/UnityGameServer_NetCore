using Core.Persistence.Models;
using MongoDB.Bson; 
namespace Domain.Entities;

public class EloCluster:Entity
{
    public string Name { get; set; }
    public string? Description { get; set; }
    public int EloPoint { get; set; }
     
    public EloCluster()
    {
        EloPoint = 0;
    }
    public EloCluster(ObjectId id, string name, string description, int eloPoint) : this()
    {
        Id = id;
        Name = name;
        Description = description;
        EloPoint = eloPoint; 
    }
}
