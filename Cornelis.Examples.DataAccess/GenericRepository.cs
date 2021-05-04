using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Cornelis.Examples.DataAccess
{
    /// <summary>
    /// A Generic class of which repositories will inherit
    /// to make repositories easier to use and manage.
    ///
    /// For this example crud operations will be added
    /// And additional Query<T> function which will allow the use
    /// of Query language operations without the need to instantiate
    /// additional data readers like Linq does.
    ///
    /// And two Linq Queryable Examples will be added.
    /// </summary>
    public abstract class GenericRepository<TEntity, TKey> : IGenericRepository<TEntity, TKey> where TEntity : class
    {
        #region Private Variables

        private DbContext _context;
        private DbSet<TEntity> DbSet { get => _context.Set<TEntity>(); }

        #endregion Private Variables

        #region Constructors

        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="context"></param>
        public GenericRepository(DbContext context)
        {
            this._context = context;
        }

        #endregion Constructors

        #region public functions

        /// <summary>
        /// Get the entity by key.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public async Task<TEntity> GetByKeyAsync(TKey key) => await DbSet.FindAsync(key);

        /// <summary>
        /// Update the entity.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<int> UpdateEntityAsync(TEntity entity)
        {
            // Update in memeory
            DbSet.Update(entity);

            // Consilidate between memory and database
            return await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Insert an entity.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<int> InsertEntityAsync(TEntity entity)
        {
            // Add to memory if it does not exist
            if (!await DbSet.ContainsAsync(entity))
            {
                DbSet.Add(entity);
                return await _context.SaveChangesAsync();
            }

            // Consilidate between memory and database
            return 0;
        }

        /// <summary>
        /// Delete an entity.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<int> DeleteEntityAsync(TEntity entity)
        {
            // Remove entity from memory
            DbSet.Remove(entity);

            // Consilidate between memory and database
            return await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Delete an entity on its key.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public async Task<int> DeleteEntityByKeyAsync(TKey key)
        {
            // Retrieve the entity to delete
            var entity = await GetByKeyAsync(key);

            // Delete the entity
            return await DeleteEntityAsync(entity);
        }

        /// <summary>
        /// Return a different table.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public DbSet<T> Query<T>() where T : class => _context.Set<T>();

        /// <summary>
        /// A function that works like the LINQ Where clause.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> predicate) => DbSet.Where(predicate);

        /// <summary>
        /// A function that works like the LINQ FirstOrDefault clause.
        /// </summary>
        /// <param na
        public TEntity FirstOrDefault(Expression<Func<TEntity, bool>> predicate) => DbSet.FirstOrDefault(predicate);

        #endregion public functions
    }

    public abstract class GenericRepository<TEntity, TKey1, TKey2> : IGenericRepository<TEntity, TKey1, TKey2> where TEntity : class
    {
        #region Private Variables

        private DbContext _context;
        private DbSet<TEntity> DbSet { get => _context.Set<TEntity>(); }

        #endregion Private Variables

        #region Constructors

        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="context"></param>
        public GenericRepository(DbContext context)
        {
            this._context = context;
        }

        #endregion Constructors

        #region public functions

        /// <summary>
        /// Get the entity by key.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public async Task<TEntity> GetByKey(TKey1 key, TKey2 key2) => await DbSet.FindAsync(key, key2);

        /// <summary>
        /// Update the entity.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<int> UpdateEntity(TEntity entity)
        {
            // Update in memeory
            DbSet.Update(entity);

            // Consilidate between memory and database
            return await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Insert an entity.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<int> InsertEntity(TEntity entity)
        {
            // Add to memory if it does not exist
            if (!await DbSet.ContainsAsync(entity))
            {
                DbSet.Add(entity);
            }

            // Consilidate between memory and database
            return await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Delete an entity.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<int> DeleteEntity(TEntity entity)
        {
            // Remove entity from memory
            DbSet.Remove(entity);

            // Consilidate between memory and database
            return await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Delete an entity on its key.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public async Task<int> DeleteEntityByKey(TKey1 key, TKey2 key2)
        {
            // Retrieve the entity to delete
            var entity = await GetByKey(key, key2);

            // Delete the entity
            return await DeleteEntity(entity);
        }

        /// <summary>
        /// Return a different table.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public DbSet<T> Query<T>() where T : class => _context.Set<T>();

        /// <summary>
        /// A function that works like the LINQ Where clause.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> predicate) => DbSet.Where(predicate);

        /// <summary>
        /// A function that works like the LINQ FirstOrDefault clause.
        /// </summary>
        /// <param na
        public TEntity FirstOrDefault(Expression<Func<TEntity, bool>> predicate) => DbSet.FirstOrDefault(predicate);

        #endregion public functions
    }
}