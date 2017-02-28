using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace didongexpress.bus.Bus
{
    public interface IOrderDetailBusiness : IBusiness
    {

    }

    public class OrderDetailBusiness : Business, IOrderDetailBusiness
    {
    }
}
