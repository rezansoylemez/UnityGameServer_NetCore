using Application.Services.PlayerService;
using AutoMapper;
using Domain.EntityModels;
using MediatR; 
namespace Application.Features.Players.Commands.Create;
public class CreatePlayerCommandHandler : IRequestHandler<CreatePlayerCommandRequest, CreatedPlayerCommandResponse>
{
    private readonly IPlayerService _playerService;
    private readonly IMapper _mapper;

    public CreatePlayerCommandHandler(IPlayerService playerService, IMapper mapper)
    {
        _playerService = playerService;
        _mapper = mapper;
    }

    public async Task<CreatedPlayerCommandResponse> Handle(CreatePlayerCommandRequest request, CancellationToken cancellationToken)
    {
        var newPlayer = _mapper.Map<Player>(request);

        newPlayer.Status = true;
        newPlayer.CreatedDate = DateTime.Now; 
        var createdPalyer = await _playerService.Create(newPlayer);

        var response = _mapper.Map<CreatedPlayerCommandResponse>(createdPalyer);

        return response;
    }
}
