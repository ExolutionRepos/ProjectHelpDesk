using System.Collections.Generic;
using System.Linq;

namespace UI.Business.Interfaces.Repositories
{
    public interface IBaseRepository<T> where T : class
    {
        //void INSERIRREGISTRO(T item);
        //void ATUALIZARREGISTRO(T item);
        //void EXCLUIRREGISTRO(T item);
        //T CONSULTARREGISTRO(int id);
        //IQueryable<T> CONSULTARREGISTROS();

        T Find(int id);
        IQueryable<T> List();
        void Add(T item);
        void Remove(T item);
        void Edit(T item);
    }
}
