using Application.Repositories;
using Core.Domain.Models;
using Core.Persistence.Repositories;
using Core.Persistence.Settings; 
using Microsoft.Extensions.Options;

namespace Persistence.Repositories;
public class PlayerRepository : MongoDriverRepositoryBase<Player>, IPlayerRepository
{
    public PlayerRepository(IOptions<DataBaseSettings> context) : base(context)
    {

    }
}
