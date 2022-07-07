using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        void Tadd(T t);
        
        void Delete(T t);
        
        void Update(T t);

        List<T> TGetList();

        T TGetById(int id);

    }
}
