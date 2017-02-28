using didongexpress.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace didongexpress.repos.Repos
{
    public interface ICategoryRepository : IRepository<Category, int>
    {

    }

    public class CategoryRepository : GenericRepository<Category, int>, ICategoryRepository
    {
    }
}
