using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPMongodb.Data
{
    interface IRepositoryGenneric<T,K>
    {
        List<T> GetAll();
        T GetById(K key);
        bool Insert(T entity);
        bool Update(T entity);
        bool Delete(K key);
    }
}
