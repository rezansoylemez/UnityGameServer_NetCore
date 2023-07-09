using MediatR;

namespace Application.Features.Players.Commands.Create;
public class CreatePlayerCommandRequest:IRequest<CreatedPlayerCommandResponse>
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int? Level { get; set; }  
    public bool? Status { get; set; }
    public string? Code { get; set; }
}
