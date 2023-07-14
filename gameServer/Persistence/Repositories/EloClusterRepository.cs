using Application.Repositories;
using Core.Persistence.Repositories;
using Core.Persistence.Settings;
using Domain.Entities;
using Microsoft.Extensions.Options;

namespace Persistence.Repositories;
public class EloClusterRepository : MongoDriverRepositoryBase<EloCluster>, IEloClusterRepository
{
    public EloClusterRepository(IOptions<DataBaseSettings> context) : base(context)
    {

    }
}