using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Cornelis.Examples.DataAccess
{
    /// <summary>
    /// Interface for the <see cref="GenericRepository{TEntity, TKey, Tkey2}"/> abstract class.
    /// </summary>
    public interface IGenericRepository<TEntity, TKey>
    {
        /// <summary>
        /// Retrieve an entity by the Id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<TEntity> GetByKeyAsync(TKey key);

        /// <summary>
        /// Update an entity.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<int> UpdateEntityAsync(TEntity entity);

        /// <summary>
        /// Insert a new entity
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<int> InsertEntityAsync(TEntity entity);

        /// <summary>
        /// Delete an entity
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<int> DeleteEntityAsync(TEntity entity);

        /// <summary>
        /// Delete an entity by its Key
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        Task<int> DeleteEntityByKeyAsync(TKey key);

        /// <summary>
        /// Expose a different table to allow for
        /// advance query operations.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        DbSet<T> Query<T>() where T : class;

        /// <summary>
        /// Allows for the Linq Expression "Where" to be used on the table.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> predicate);

        /// <summary>
        /// Allows for the Linq Expression "Where" to be used on the table.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        TEntity FirstOrDefault(Expression<Func<TEntity, bool>> predicate);
    }

    /// <summary>
    /// Overload method with two Keys
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <typeparam name="TKey"></typeparam>
    public interface IGenericRepository<TEntity, TKey1, TKey2>
    {
        /// <summary>
        /// Retrieve an entity by the Id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<TEntity> GetByKey(TKey1 key, TKey2 key2);

        /// <summary>
        /// Update an entity.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<int> UpdateEntity(TEntity entity);

        /// <summary>
        /// Insert a new entity
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<int> InsertEntity(TEntity entity);

        /// <summary>
        /// Delete an entity
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<int> DeleteEntity(TEntity entity);

        /// <summary>
        /// Delete an entity by its Key
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        Task<int> DeleteEntityByKey(TKey1 key, TKey2 key2);

        /// <summary>
        /// Expose a different table to allow for
        /// advance query operations.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        DbSet<T> Query<T>() where T : class;

        /// <summary>
        /// Allows for the Linq Expression "Where" to be used on the table.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> predicate);

        /// <summary>
        /// Allows for the Linq Expression "Where" to be used on the table.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        TEntity FirstOrDefault(Expression<Func<TEntity, bool>> predicate);
    }
}