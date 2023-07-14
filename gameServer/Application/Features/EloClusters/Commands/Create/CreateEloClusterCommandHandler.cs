using Application.Services.EloClusterService;
using AutoMapper;
using MediatR;
namespace Application.Features.EloClusters.Commands.Create;
public class CreateEloClusterCommandHandler : IRequestHandler<CreateEloClusterRequest, CreatedEloCLusterResponse>
{
    private readonly IEloClusterService _eloClusterService;
    private readonly IMapper _napper;
    public CreateEloClusterCommandHandler(IEloClusterService eloClusterService, IMapper mapper)
    {
        _napper = mapper;
        _eloClusterService = eloClusterService;
    }
    public Task<CreatedEloCLusterResponse> Handle(CreateEloClusterRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
