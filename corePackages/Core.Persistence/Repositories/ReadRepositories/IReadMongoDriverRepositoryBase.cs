using Core.Persistence.Models;
using System.Linq.Expressions;

namespace Core.Persistence.Repositories.ReadRepositories;
public interface IReadMongoDriverRepositoryBase<TEntity> where TEntity : IEntity
{
    IQueryable<TEntity> AsQueryable();
    IEnumerable<TEntity> FilterByEnumerable(
       Expression<Func<TEntity, bool>> filterExpression);
    List<TEntity> FilterList(
       Expression<Func<TEntity, bool>> filterExpression);
    IEnumerable<TProjected> FilterBy<TProjected>(
        Expression<Func<TEntity, bool>> filterExpression,
        Expression<Func<TEntity, TProjected>> projectionExpression);

    TEntity FindOne(Expression<Func<TEntity, bool>> filterExpression);

    Task<TEntity> FindOneAsync(Expression<Func<TEntity, bool>> filterExpression);

    TEntity FindById(string id);

    Task<TEntity> FindByIdAsync(string id);
}
