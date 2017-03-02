using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using didongexpress.entities;
using didongexpress.domains;
using System.Data.Entity;

namespace didongexpress.repos.Repos
{
    public interface IProductRepository : IRepository<Product, int>
    {
        List<ProductIndex> AllProducts();
    }

    public class ProductRepository : GenericRepository<Product, int>, IProductRepository
    {
        public ProductRepository(ExpressDb db) : base(db)
        {

        }

        public List<ProductIndex> AllProducts()
        {
            var products = All(p => p.IsActive);
            return RepositoryConfig.Factory.Map<List<Product>, List<ProductIndex>>(products);
        }
    }
}
