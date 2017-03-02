using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using didongexpress.repos;

namespace didongexpress.bus.Bus
{
    public interface IOrderDetailBusiness : IBusiness
    {

    }

    public class OrderDetailBusiness : Business, IOrderDetailBusiness
    {
        public OrderDetailBusiness(IUnitOfWork unit) : base(unit)
        {
        }
    }
}
