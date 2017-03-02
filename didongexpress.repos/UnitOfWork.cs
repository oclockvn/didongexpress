using didongexpress.entities;
using didongexpress.repos;
using didongexpress.repos.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace didongexpress.repos
{
    public interface IUnitOfWork : IDisposable
    {
        bool SaveChanges();
        TRepository Get<TRepository>() where TRepository : class, IRepository;
    }

    public class UnitOfWork : IUnitOfWork
    {
        private readonly Dictionary<Type, Lazy<IRepository>> _repoFactory = null;
        private readonly Lazy<ExpressDb> _db = null;

        public UnitOfWork()
        {
            _db = new Lazy<ExpressDb>(() => new ExpressDb());
            _repoFactory = new Dictionary<Type, Lazy<IRepository>>
            {
                { typeof (IProductRepository), new Lazy<IRepository>(() => new ProductRepository(_db.Value)) }
            };
        }

        public void Dispose()
        {
            // throw new NotImplementedException();
        }

        public TRepository Get<TRepository>() where TRepository : class, IRepository
        {           
            var repo = _repoFactory[typeof(TRepository)];
            return repo.Value as TRepository;
        }

        public bool SaveChanges()
        {
            // throw new NotImplementedException();
            return true;
        }
    }
}
