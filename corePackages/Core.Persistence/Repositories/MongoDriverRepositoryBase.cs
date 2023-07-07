using Core.Persistence.DbContext;
using Core.Persistence.Models;
using Core.Persistence.Repositories.ReadRepositories;
using Core.Persistence.Repositories.WriteRepositories;
using Core.Persistence.Settings;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Linq.Expressions;

namespace Core.Persistence.Repositories;
public class MongoDriverRepositoryBase<TEntity> : IWriteMongoDriverRepositoryBase<TEntity>, IReadMongoDriverRepositoryBase<TEntity> where TEntity : IEntity
{
    private readonly BaseDbContext _context;
    private readonly IMongoCollection<TEntity> _collection;
    public MongoDriverRepositoryBase(IOptions<DataBaseSettings> context)
    {
        _context = new BaseDbContext(context);
        _collection = _context.GetCollection<TEntity>();
    }
    public virtual IQueryable<TEntity> AsQueryable()
    {
        return _collection.AsQueryable();
    }

    public IEnumerable<TEntity> FilterByEnumerable(
        Expression<Func<TEntity, bool>> filterExpression)
    {
        return _collection.Find(filterExpression).ToEnumerable();
    }
    public List<TEntity> FilterList(
       Expression<Func<TEntity, bool>> filterExpression)
    {
        return _collection.Find(filterExpression).ToList();
    }
    public async Task<IEnumerable<TEntity>> FilterByAsync(
       Expression<Func<TEntity, bool>> filterExpression)
    {
        return await _collection.Find(filterExpression).ToListAsync();
    }
    public virtual IEnumerable<TProjected> FilterBy<TProjected>(
        Expression<Func<TEntity, bool>> filterExpression,
        Expression<Func<TEntity, TProjected>> projectionExpression)
    {
        return _collection.Find(filterExpression).Project(projectionExpression).ToEnumerable();
    }

    public virtual TEntity FindOne(Expression<Func<TEntity, bool>> filterExpression)
    {
        return _collection.Find(filterExpression).FirstOrDefault();
    }

    public virtual Task<TEntity> FindOneAsync(Expression<Func<TEntity, bool>> filterExpression)
    {
        return Task.Run(() => _collection.Find(filterExpression).FirstOrDefaultAsync());
    }

    public virtual TEntity FindById(string id)
    {
        var objectId = new ObjectId(id);
        var filter = Builders<TEntity>.Filter.Eq(doc => doc.Id, objectId);
        return _collection.Find(filter).SingleOrDefault();
    }

    public virtual Task<TEntity> FindByIdAsync(string id)
    {
        return Task.Run(() =>
        {
            var objectId = new ObjectId(id);
            var filter = Builders<TEntity>.Filter.Eq(doc => doc.Id, objectId);
            return _collection.Find(filter).SingleOrDefaultAsync();
        });
    }


    public virtual void InsertOne(TEntity document)
    {
        _collection.InsertOne(document);
    }

    public async Task<TEntity> InsertOneAsync(TEntity document)
    {
        await _collection.InsertOneAsync(document);
        return document;
    }

    public void InsertMany(ICollection<TEntity> documents)
    {
        _collection.InsertMany(documents);
    }


    public virtual async Task InsertManyAsync(ICollection<TEntity> documents)
    {
        await _collection.InsertManyAsync(documents);
    }

    public void ReplaceOne(TEntity document)
    {
        var filter = Builders<TEntity>.Filter.Eq(doc => doc.Id, document.Id);
        _collection.FindOneAndReplace(filter, document);
    }

    public virtual async Task<TEntity> ReplaceOneAsync(TEntity document)
    {
        var filter = Builders<TEntity>.Filter.Eq(doc => doc.Id, document.Id);
        var updatedDocument = await _collection.FindOneAndReplaceAsync(filter, document);
        return updatedDocument;
    }

    public void DeleteOne(Expression<Func<TEntity, bool>> filterExpression)
    {
        _collection.FindOneAndDelete(filterExpression);
    }

    public Task DeleteOneAsync(Expression<Func<TEntity, bool>> filterExpression)
    {
        var deleted = Task.Run(() => _collection.FindOneAndDeleteAsync(filterExpression));

        return deleted;
    }
    public void DeleteById(string id)
    {
        var objectId = new ObjectId(id);
        var filter = Builders<TEntity>.Filter.Eq(doc => doc.Id, objectId);
        _collection.FindOneAndDelete(filter);
    }

    public Task DeleteByIdAsync(string id)
    {
        return Task.Run(() =>
        {
            var objectId = new ObjectId(id);
            var filter = Builders<TEntity>.Filter.Eq(doc => doc.Id, objectId);
            _collection.FindOneAndDeleteAsync(filter);
        });
    }

    public void DeleteMany(Expression<Func<TEntity, bool>> filterExpression)
    {
        _collection.DeleteMany(filterExpression);
    }

    public Task DeleteManyAsync(Expression<Func<TEntity, bool>> filterExpression)
    {
        return Task.Run(() => _collection.DeleteManyAsync(filterExpression));
    }

    public async Task<TEntity> DeleteAsync(TEntity document)
    {
        // Maybe  this mathod wont work 
        var filter = Builders<TEntity>.Filter.Eq(doc => doc.Id, document.Id);
        var deletedDocument = await _collection.FindOneAndDeleteAsync(filter);
        return deletedDocument;
    }
}
