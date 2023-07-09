using MongoDB.Bson;

namespace Core.Persistence.Models;
public class Entity : IEntity
{
    public ObjectId Id { get; set; }

    public DateTime? CreatedDate { get; set; }
    public DateTime? DeletedDate { get; set; }
    public DateTime? UpdatedDate { get; set; }

    public bool? Status { get; set; }
    public string? Code { get; set; }

    public Entity()
    {
        
    }
    public Entity(ObjectId ıd, DateTime createdDate, DateTime deletedDate, DateTime updatedDate, bool status, string? code)
    {
        Id = ıd;
        CreatedDate = createdDate;
        DeletedDate = deletedDate;
        UpdatedDate = updatedDate;
        Status = status;
        Code = code;
    }
}
