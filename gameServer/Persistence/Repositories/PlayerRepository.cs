using Application.Repositories;
using Core.Persistence.Repositories;
using Core.Persistence.Settings;
using Domain.EntityModels;
using Microsoft.Extensions.Options;

namespace Persistence.Repositories;
public class PlayerRepository : MongoDriverRepositoryBase<Player>, IPlayerRepository
{
    public PlayerRepository(IOptions<DataBaseSettings> context) : base(context)
    {

    }
}
