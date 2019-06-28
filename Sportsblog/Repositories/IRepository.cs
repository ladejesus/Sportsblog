using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sportsblog.Repository
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Create(T obj);
        void Delete(T obj);
        void Edit(T obj);
    }
}
