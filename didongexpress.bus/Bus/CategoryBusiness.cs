using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using didongexpress.repos;

namespace didongexpress.bus.Bus
{
    public interface ICategoryBusiness : IBusiness
    {

    }

    public class CategoryBusiness : Business, ICategoryBusiness
    {
        public CategoryBusiness(IUnitOfWork unit) : base(unit)
        {
        }
    }
}
