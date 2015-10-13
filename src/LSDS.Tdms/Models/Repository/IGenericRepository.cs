
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace LSDS.Tdms.Repository
{
    public interface IGenericRepository<TEntity>
    {

        Task<TEntity> GetByIdAsync(int id);
        
        IQueryable<TEntity> SearchFor(Expression<Func<TEntity, bool>> predicate);

        IQueryable<TEntity> GetAll();

        Task EditAsync(TEntity entity);

        Task InsertAsync(TEntity entity);

        Task DeleteAsync(TEntity entity);


        Task<List<TEntity>> ExecuteStoredProcedureAsync(string procedureName, object[] parameters);

        Task<List<TEntity>> ExecuteStoredProcedureAsync(string procedureName);

        IQueryable<TEntity> ExecuteStoredProcedure(string procedureName, object[] parameters);

        IQueryable<TEntity> ExecuteStoredProcedure(string procedureName);


        Task<int> ExecueUpdateAsync(string procedureName, object[] parameters);

        Task<int> ExecueUpdateAsync(string procedureName);

        int ExecueUpdate(string procedureName, object[] parameters);

        int ExecueUpdate(string procedureName);
       
    }
}