using Application.Services.PlayerService;
using AutoMapper; 
using MediatR;

namespace Application.Features.Players.Commands.Update;
public class UpdatePlayerCommandHandler : IRequestHandler<UpdatePlayerCommandRequest, UpdatedPlayerCommandResponse>
{
    private readonly IPlayerService _playerService;
    private readonly IMapper _mapper;

    public UpdatePlayerCommandHandler(IPlayerService playerService, IMapper mapper)
    {
        _playerService = playerService;
        _mapper = mapper;
    }
    public async Task<UpdatedPlayerCommandResponse> Handle(UpdatePlayerCommandRequest request, CancellationToken cancellationToken)
    {
        var updatePlayer = await _playerService.GetById(request.Id);

        updatePlayer.FirstName = request.FirstName;
        updatePlayer.LastName = request.LastName;
        updatePlayer.Status = request.Status;
        updatePlayer.Code = request.Code;

        var createdPalyer = await _playerService.Update(updatePlayer);

        var response = _mapper.Map<UpdatedPlayerCommandResponse>(createdPalyer);

        return response;
    }
}
