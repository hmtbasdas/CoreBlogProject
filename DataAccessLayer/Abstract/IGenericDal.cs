using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        List<T> GetListAll();
        void Insert(T item);
        void Delete(T item);
        void Update(T item);
        T GetByID(int id);
        List<T> GetListAll(Expression<Func<T, bool>> filter);

    }
}
