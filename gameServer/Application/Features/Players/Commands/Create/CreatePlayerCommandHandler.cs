using Application.Services.PlayerService;
using AutoMapper;
using Core.Domain.Models; 
using MediatR; 
namespace Application.Features.Players.Commands.Create;
public class CreatePlayerCommandHandler : IRequestHandler<CreatePlayerCommandRequest, CreatedPlayerCommandResponse>
{
    private readonly IPlayerService _playerService;
    private IMapper _mapper;

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
        newPlayer.Email = request.Email;
        newPlayer.Code = request.Code;
        newPlayer.XPosition = request.XPosition;
        newPlayer.YPosition = request.YPosition;
        newPlayer.Rank = request.Rank;  

        var createdPalyer = await _playerService.Create(newPlayer);

        var response = _mapper.Map<CreatedPlayerCommandResponse>(createdPalyer);

        response.FirstName = createdPalyer.FirstName;
        return response;

        ////var newPlayer = _mapper.Map<Player>(request);

        //var newPlayer = new Player();

        //newPlayer.Status = true;
        //newPlayer.CreatedDate = DateTime.Now; 
        //var createdPalyer = await _playerService.Create(newPlayer);

        //// var response = _mapper.Map<CreatedPlayerCommandResponse>(createdPalyer);

        //var response = new CreatedPlayerCommandResponse();
        //response.FirstName = createdPalyer.FirstName;
        //return response;
    }
}
