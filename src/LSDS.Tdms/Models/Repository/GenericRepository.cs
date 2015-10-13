
using System;
using Microsoft.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace LSDS.Tdms.Repository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        protected DbSet<TEntity> DbSet;

        private readonly DbContext _dbContext;

        public GenericRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
            DbSet = _dbContext.Set<TEntity>();
        }

        public GenericRepository()
        {
        }

        public IQueryable<TEntity> GetAll()
        {
            return DbSet;
        }
       
        public async Task<TEntity> GetByIdAsync(int id)
        {
            return null;// await DbSet.Where(a => a.id == id);
        }

        public IQueryable<TEntity> SearchFor(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.Where(predicate);
        }

        public async Task EditAsync(TEntity entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task InsertAsync(TEntity entity)
        {

            DbSet.Add(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(TEntity entity)
        {
            DbSet.Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<TEntity>> ExecuteStoredProcedureAsync(string procedureName, object[] parameters)
        {
            DbSet.FromSql(procedureName,parameters);
            await _dbContext.SaveChangesAsync();
            return await DbSet.ToListAsync();
        }
        public async Task<List<TEntity>> ExecuteStoredProcedureAsync( string procedureName)
        {
            DbSet.FromSql(procedureName);
            await _dbContext.SaveChangesAsync();
            return await DbSet.ToListAsync();
        }
        public IQueryable<TEntity> ExecuteStoredProcedure(string procedureName, object[] parameters)
        {
            
            DbSet.FromSql(procedureName, parameters);
            _dbContext.SaveChanges();
            return DbSet;
        }
        public IQueryable<TEntity> ExecuteStoredProcedure(string procedureName)
        {
            DbSet.FromSql(procedureName);
            _dbContext.SaveChanges();
            return DbSet;
        }
     
        public async Task<int> ExecueUpdateAsync(string procedureName, object[] parameters)
        {
            DbSet.FromSql(procedureName, parameters);
            return await _dbContext.SaveChangesAsync();
        }
        public async Task<int> ExecueUpdateAsync(string procedureName)
        {
            DbSet.FromSql(procedureName);
            return await _dbContext.SaveChangesAsync();
        }
        public int ExecueUpdate(string procedureName, object[] parameters)
        {
            DbSet.FromSql(procedureName, parameters);
            return  _dbContext.SaveChanges();
        }
        public int ExecueUpdate(string procedureName)
        {
            DbSet.FromSql(procedureName);
            return  _dbContext.SaveChanges();
        }

       
    }
}