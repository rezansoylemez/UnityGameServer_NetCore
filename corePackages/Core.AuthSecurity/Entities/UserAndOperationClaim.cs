using Core.Persistence.Models;
using MongoDB.Bson;

namespace Core.AuthSecurity.Entities;

public class UserAndOperationClaim:Entity
{
    public int UserId { get; set; }
    public int OperationClaimId { get; set; }

    public virtual User User { get; set; }
    public virtual OperationClaim OperationClaim { get; set; }

    public UserAndOperationClaim()
    {
    }

    public UserAndOperationClaim(ObjectId id, int userId, int operationClaimId) : this()
    {
        Id = id;
        UserId = userId;
        OperationClaimId = operationClaimId;
    }
}
