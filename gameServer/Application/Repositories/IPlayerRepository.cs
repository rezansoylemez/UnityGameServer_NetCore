using Core.Persistence.Repositories.ReadRepositories;
using Core.Persistence.Repositories.WriteRepositories;
using Domain.EntityModels;

namespace Application.Repositories;

public interface IPlayerRepository : IWriteMongoDriverRepositoryBase<Player>, IReadMongoDriverRepositoryBase<Player>
{
}
