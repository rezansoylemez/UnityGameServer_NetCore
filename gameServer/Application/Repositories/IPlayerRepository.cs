using Core.Domain.Models;
using Core.Persistence.Repositories.ReadRepositories;
using Core.Persistence.Repositories.WriteRepositories;

namespace Application.Repositories;

public interface IPlayerRepository : IWriteMongoDriverRepositoryBase<Player>, IReadMongoDriverRepositoryBase<Player>
{
}
