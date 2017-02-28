using didongexpress.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace didongexpress.repos.Repos
{
    public interface IOrderDetailRepository : IRepository<OrderDetail, int>
    {

    }

    public class OrderDetailRepository : GenericRepository<OrderDetail, int>, IOrderDetailRepository
    {
    }
}
