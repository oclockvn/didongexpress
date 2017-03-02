using didongexpress.domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using didongexpress.repos;
using didongexpress.repos.Repos;

namespace didongexpress.bus.Bus
{
    public interface IProductBusiness : IBusiness
    {
        List<ProductIndex> AllProducts();
    }

    public class ProductBusiness : Business, IProductBusiness
    {
        public ProductBusiness(IUnitOfWork unit) : base(unit)
        {
        }

        public List<ProductIndex> AllProducts()
        {
            var products = _unit.Get<IProductRepository>().AllProducts();
            return products;
        }
    }
}
