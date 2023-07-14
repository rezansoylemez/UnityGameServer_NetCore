using Core.Persistence.Repositories.ReadRepositories;
using Core.Persistence.Repositories.WriteRepositories;
using Domain.Entities;

namespace Application.Repositories;
public interface IEloClusterRepository : IWriteMongoDriverRepositoryBase<EloCluster>, IReadMongoDriverRepositoryBase<EloCluster>
{
}
