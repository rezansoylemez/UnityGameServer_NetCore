using MediatR; 

namespace Application.Features.Players.Commands.Create;
public class CreatePlayerCommandRequest:IRequest<CreatedPlayerCommandResponse>
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int? Level { get; set; }  
    public bool? Status { get; set; }

    public string Email { get; set; }
    public string Password { get; set; }

    public string? Code { get; set; } 
    public string? XPosition { get; set; }
    public string? YPosition { get; set; }
    public int? Rank { get; set; }
     
    public string? InventoryId { get; set; }
}
