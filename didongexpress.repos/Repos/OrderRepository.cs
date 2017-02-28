using didongexpress.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace didongexpress.repos.Repos
{
    public interface IOrderRepository : IRepository<Order, int>
    {

    }

    public class OrderRepository : GenericRepository<Order, int>, IOrderRepository
    {
    }
}
