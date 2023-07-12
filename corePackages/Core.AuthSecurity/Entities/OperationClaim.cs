using Core.Persistence.Models;
using MongoDB.Bson;

namespace Core.AuthSecurity.Entities;
public class OperationClaim:Entity
{
    public string Name { get; set; }

    public OperationClaim()
    {
    }
    public OperationClaim(ObjectId id, string name) : this()
    {
        Id = id;
        Name = name;
    }
}
