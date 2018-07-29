namespace Ncma.Repository.EFCore
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using System.Threading.Tasks;
    using Models;

    public interface IRepository<T> where T : class, IDataModel
    {
        Task<T> DeleteAsync(int id, bool isHardDelete = false);
        Task<List<T>> GetAsync();
        Task<T> GetAsync(int id);
        Task<T> SaveAsync(int? id, T entity);

        Task<List<T>> GetActiveAsync();
        Task<List<T>> GetInactiveAsync();

        Task<List<T>> QueryAsync(Expression<Func<T, bool>> predicate);

        IEnumerable<T> Include(params Expression<Func<T, object>>[] includes);
    }
}