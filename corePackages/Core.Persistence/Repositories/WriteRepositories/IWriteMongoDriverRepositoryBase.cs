using Core.Persistence.Models;
using System.Linq.Expressions;

namespace Core.Persistence.Repositories.WriteRepositories;
public interface IWriteMongoDriverRepositoryBase<TEntity> where TEntity : IEntity
{
    void InsertOne(TEntity document);

    Task<TEntity> InsertOneAsync(TEntity document);

    void InsertMany(ICollection<TEntity> documents);

    Task InsertManyAsync(ICollection<TEntity> documents);

    void ReplaceOne(TEntity document);

    Task<TEntity> ReplaceOneAsync(TEntity document);

    void DeleteOne(Expression<Func<TEntity, bool>> filterExpression);

    Task DeleteOneAsync(Expression<Func<TEntity, bool>> filterExpression);
    Task<TEntity> DeleteAsync(TEntity document);

    void DeleteById(string id);

    Task DeleteByIdAsync(string id);

    void DeleteMany(Expression<Func<TEntity, bool>> filterExpression);

    Task DeleteManyAsync(Expression<Func<TEntity, bool>> filterExpression); 
}
