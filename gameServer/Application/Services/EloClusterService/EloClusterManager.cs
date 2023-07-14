using Application.Repositories;
using Domain.Entities;

namespace Application.Services.EloClusterService;
public class EloClusterManager : IEloClusterService
{
    private readonly IEloClusterRepository _eloClusterRepository;
    private readonly IPlayerRepository _palyerRepository;

    public EloClusterManager(IEloClusterRepository eloClusterRepository, IPlayerRepository palyerRepository)
    {
        _eloClusterRepository = eloClusterRepository;
        _palyerRepository = palyerRepository;
    }

    public async Task<EloCluster> Create(EloCluster eloCluster)
    {
        var createdEloCLuster = await _eloClusterRepository.InsertOneAsync(eloCluster);
        return createdEloCLuster;
    }

    public async Task<EloCluster> Delete(EloCluster eloCluster)
    {
        var deletedEloCLuster = await _eloClusterRepository.ReplaceOneAsync(document: eloCluster);
        return deletedEloCLuster;

    }
    public async Task<EloCluster> Update(EloCluster eloCluster)
    {
        var updatedEloCLuster = await _eloClusterRepository.ReplaceOneAsync(eloCluster);
        return updatedEloCLuster;
    }


    public async Task<EloCluster> GetById(string id)
    {
        var eloCLuster = await _eloClusterRepository.FindByIdAsync(id: id);
        return eloCLuster;
    }

    public async Task<EloCluster> Remove(EloCluster eloCluster)
    {
        var deletedEloCLuster = await _eloClusterRepository.DeleteAsync(document: eloCluster);
        return deletedEloCLuster;
    }
}
