using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        void Tadd(T t);
        
        void Delete(T t);
        
        void Update(T t);

        List<T> TGetList();

        T TGetById(int id);

        //List<T> GetByFilter(Expression<Func<T,bool>> filter);

    }
}
