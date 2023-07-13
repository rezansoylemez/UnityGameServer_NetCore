using Core.Persistence.Models;
using MongoDB.Bson;

namespace Core.AuthSecurity.Entities;

public class RefreshToken : Entity
{
    public ObjectId UserId { get; set; }
    public string Token { get; set; }
    public DateTime Expires { get; set; }
    public DateTime Created { get; set; }
    public string CreatedByIp { get; set; }
    //Cancellation status can be checked here
    public DateTime? Revoked { get; set; }
    public string? RevokedByIp { get; set; }

    //Update status can be checked here
    public string? ReplacedByToken { get; set; }

    public string? ReasonRevoked { get; set; }
    //public bool IsExpired => DateTime.UtcNow >= Expires;
    //public bool IsRevoked => Revoked != null;
    //public bool IsActive => !IsRevoked && !IsExpired;

    public virtual User User { get; set; }

    public RefreshToken()
    {
    }

    public RefreshToken(ObjectId id, string token, DateTime expires, DateTime created, string createdByIp, DateTime? revoked,
                        string revokedByIp, string replacedByToken, string reasonRevoked)
    {
        Id = id;
        Token = token;
        Expires = expires;
        Created = created;
        CreatedByIp = createdByIp;
        Revoked = revoked;
        RevokedByIp = revokedByIp;
        ReplacedByToken = replacedByToken;
        ReasonRevoked = reasonRevoked;
    }
}
