using Amazon.Runtime.Internal;
using MediatR;

namespace Application.Features.EloClusters.Commands.Create;

public class CreateEloClusterRequest:IRequest<CreatedEloCLusterResponse>
{
}
