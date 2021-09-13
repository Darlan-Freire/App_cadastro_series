using System;
using System.Collections.Generic;

namespace app_cadastro
{
    public interface IRepository<T>
    {
        List<T> Lista();
        T ReturnById(int id);
        void Insert(T entidade);
        void Delete(int id);
        void Update(int id, T entidade);
        int NextId();
    }
}
