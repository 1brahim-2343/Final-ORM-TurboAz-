using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Final_ORM_TurboAz__.Domain.Abstraction
{
    public interface IRepository<T>
    {
        T? Get(int id);
        T? Get(Expression<Func<T, bool>> exp);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAll(Expression<Func<T, bool>> exp);
        T? Add(T obj);

        void AddRange(params T[] values);
        bool Update(T obj);
        bool Delete(int id);
        bool Delete(Expression<Func<T, bool>> exp);
        int SaveChanges();



    }
}
