using Core.Persistence.Settings;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Core.Persistence.DbContext;
public class BaseDbContext
{
    private readonly IMongoDatabase _database;
    public BaseDbContext(IOptions<DataBaseSettings> settings)
    {
        var client = new MongoClient(settings.Value.ConnectionString);
        _database = client.GetDatabase(settings.Value.DatabaseName);
    }

    public IMongoCollection<TEntity> GetCollection<TEntity>()
    {
        return _database.GetCollection<TEntity>(typeof(TEntity).Name.Trim());
    }
    public IMongoDatabase GetDatabase()
    {
        return _database;
    }
}
