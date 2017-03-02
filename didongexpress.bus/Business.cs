using didongexpress.repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace didongexpress.bus
{
    public interface IBusiness
    {

    }

    public class Business : IBusiness
    {
        protected IUnitOfWork _unit;

        public Business(IUnitOfWork unit)
        {
            _unit = unit;
        }
    }
}
