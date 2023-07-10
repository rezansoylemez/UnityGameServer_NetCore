using MediatR;
using MongoDB.Bson;

namespace Application.Features.Players.Commands.Update;
public class UpdatePlayerCommandRequest:IRequest<UpdatedPlayerCommandResponse>
{
    public string Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int? Level { get; set; }
    public bool? Status { get; set; }
    public string? Code { get; set; }
}
