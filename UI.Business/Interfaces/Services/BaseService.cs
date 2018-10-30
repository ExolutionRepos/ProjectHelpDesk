using System.Collections.Generic;
using System.Linq;
using UI.Business.Interfaces.Repositories;
using UI.Business.Persistence;

namespace UI.Business.Interfaces.Services
{
    public class BaseService<T> : IBaseService<T> where T : class
    {
        IUnitOfWork unitOfWork = new BaseContext((new ApplicationDBContext())._db);
        IBaseRepository<T> _repository;

        public BaseService()
        {
            _repository = new BaseRepository<T>(unitOfWork);
        }

        public T Find(int id)
        {
            return _repository.Find(id);
        }

        public IQueryable<T> List()
        {
            return _repository.List();
        }

        public void Add(T item)
        {
            _repository.Add(item);
            unitOfWork.SALVAR();
        }

        public void AddNotSave(T item)
        {
            _repository.Add(item);
        }

        public void Remove(T item)
        {
            _repository.Remove(item);
            unitOfWork.SALVAR();
        }

        public void RemoveNotSave(T item)
        {
            _repository.Remove(item);
        }

        public void Edit(T item)
        {
            _repository.Edit(item);
            unitOfWork.SALVAR();
        }

        public void EditNotSave(T item)
        {
            _repository.Edit(item);
            unitOfWork.SALVAR();
        }

        //public void Dispose()
        //{
        //    _repository.Dispose();
        //}
    }
    
}
