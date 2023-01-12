﻿using System.Collections.Generic;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;

namespace DataAccessLayer.Repository
{
    public class GenericUnitOfWorkRepository<T>:IGenericUnitOfWorkDal<T> where T : class
    {

        private readonly Context _context;

        public GenericUnitOfWorkRepository(Context context)
        {
            _context = context;
        }

        public void Insert(T t)
        {
            _context.Add(t);
        }

        public void Update(T t)
        {
            _context.Update(t);
        }

        public void MultiUpdate(List<T> t)
        {
            _context.UpdateRange(t);
        }

        public T GetByID(int id)
        {
           return _context.Set<T>().Find(id);
        }
    }
}
