using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using UI.Business.Interfaces.Repositories;
using UI.Business.Persistence;

namespace UI.Business.Interfaces.Services
{
    public class BaseRepository<T>
        : IDisposable, IBaseRepository<T> where T : class
    {
        private BaseContext _context;

        #region Ctor
        public BaseRepository(IUnitOfWork unitOfWork)
        {
            if (unitOfWork == null)
                throw new ArgumentNullException("unitOfWork");

            _context = unitOfWork as BaseContext;
        }
        #endregion

        public T Find(int id)
        {
            var a = "";
            try
            {
                return _context.Set<T>().Find(id);
            }
            catch (Exception e)
            {
                a = e.Message;
            }

            return _context.Set<T>().Find(id);
        }

        public T FindMax()
        {
            return _context.Set<T>().OrderBy(y => y).First();
        }

        public IQueryable<T> List()
        {
            var a = "";
            try
            {
                return _context.Set<T>();
            }
            catch (Exception e)
            {
                a = e.Message;
            }

            return _context.Set<T>();
        }


        public void Add(T item)
        {
            var a = "";
            try
            {
                _context.Set<T>().Add(item);
            }
            catch (Exception e)
            {
                a = e.Message;
            }

        }

        public void Remove(T item)
        {
            _context.Set<T>().Remove(item);
        }

        public void Edit(T item)
        {
            _context.Entry(item).State = EntityState.Modified;
        }

        public void Dispose()
        {
            _context.Dispose();
        }

    }

}
