using Domain.Entities;

namespace Application.Services.EloClusterService;
public interface IEloClusterService
{
    Task<EloCluster> Create(EloCluster eloCluster);
    Task<EloCluster> Update(EloCluster eloCluster);
    Task<EloCluster> Delete(EloCluster eloCluster);
    Task<EloCluster> Remove(EloCluster eloCluster);
    Task<EloCluster> GetById(string id);
}
