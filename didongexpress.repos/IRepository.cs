using didongexpress.entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq.Expressions;

namespace didongexpress.repos
{
    public interface IRepository<T, Key> : IDisposable where T : class // T is BaseEntity
    {
        List<T> All(Expression<Func<T, bool>> predicate);
        T Get(Expression<Func<T, bool>> predicate);
        T GetById(Key id);
        T Create(T model);
        T Update(T model);
        T Update(T model, List<Expression<Func<T, object>>> updateProperties = null);
        T Delete(T model);
        T Delete(Key id);
    }

    public class GenericRepository<T, Key> : IRepository<T, Key> where T : class
    {
        protected bool disposed = false;
        protected ExpressDb db = null;
        protected DbSet table;

        public GenericRepository() : this(new ExpressDb())
        {

        }

        public GenericRepository(ExpressDb db)
        {
            this.db = db;
        }

        public virtual List<T> All(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public virtual T Create(T model)
        {
            throw new NotImplementedException();
        }

        public virtual T Delete(Key id)
        {
            throw new NotImplementedException();
        }

        public virtual T Delete(T model)
        {
            throw new NotImplementedException();
        }

        public virtual T Get(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public virtual T GetById(Key id)
        {
            throw new NotImplementedException();
        }

        public virtual T Update(T model)
        {
            throw new NotImplementedException();
        }

        public virtual T Update(T model, List<Expression<Func<T, object>>> updateProperties = null)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    if (db != null)
                    {                        
                        db.Dispose();
                        db = null;
                    }
                }

                disposed = true;
            }
        }
    }
}
