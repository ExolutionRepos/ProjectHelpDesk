using System.Linq;

namespace UI.Business.Interfaces.Repositories
{
    public interface IBaseService<T> where T : class
    {
        T Find(int id);
        IQueryable<T> List();
        void Add(T item);
        void AddNotSave(T item);
        void Remove(T item);
        void RemoveNotSave(T item);
        void Edit(T item);
        void EditNotSave(T item);
    }
    
}
