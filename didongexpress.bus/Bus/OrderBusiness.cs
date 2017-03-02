using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using didongexpress.repos;

namespace didongexpress.bus.Bus
{
    public interface IOrderBusiness : IBusiness
    {

    }

    public class OrderBusiness : Business, IOrderBusiness
    {
        public OrderBusiness(IUnitOfWork unit) : base(unit)
        {
        }
    }
}
