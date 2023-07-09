using Application.Features.Players.Commands.Create; 
using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PlayerController : BaseController
{
    [HttpPost("CreatePlayer")]
    public async Task<IActionResult> CreatePlayer([FromBody] CreatePlayerCommandRequest request)
    {
        CreatedPlayerCommandResponse result = await Mediator.Send(request);
        return Ok(result);
    }
}
