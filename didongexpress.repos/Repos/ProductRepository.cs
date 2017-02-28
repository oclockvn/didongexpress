using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using didongexpress.entities;

namespace didongexpress.repos.Repos
{
    public interface IProductRepository : IRepository<Product, int>
    {

    }

    public class ProductRepository : GenericRepository<Product, int>, IProductRepository
    {
    }
}
