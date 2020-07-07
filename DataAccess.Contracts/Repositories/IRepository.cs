using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Contracts.Repositories
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();

        Task<T> Add(T element);

        Task<IQueryable<T>> Find(Expression<Func<T, bool>> expression);

        Task Delete(T element);
    }
}
