using Application.Features.Players.Commands.Create;
using Application.Features.Players.Commands.Update;
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
    [HttpPut("UpdatePlayer")]
    public async Task<IActionResult> Update([FromBody] UpdatePlayerCommandRequest request)
    {
        UpdatedPlayerCommandResponse result = await Mediator.Send(request);
        return Ok(result);
    }
}
