using MongoDB.Bson;

namespace Application.Features.Players.Commands.Create;

public class CreatedPlayerCommandResponse
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int? Level { get; set; }
    public ObjectId Id { get; set; }

    public DateTime? CreatedDate { get; }
    public DateTime? DeletedDate { get; set; }
    public DateTime? UpdatedDate { get; set; }

    public bool? Status { get; set; }
    public string? Code { get; set; }
}
