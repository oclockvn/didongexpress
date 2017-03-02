using Autofac;
using didongexpress.repos;
using didongexpress.repos.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace didongexpress.bus
{
    public class BusinessConfig
    {
        public static void Register(ContainerBuilder builder)
        {
            RepositoryConfig.Register(builder);
            
            builder.Register(t => new UnitOfWork()).As<IUnitOfWork>();
            builder.RegisterGeneric(typeof(GenericRepository<,>)).As(typeof(IRepository<,>));
            builder.RegisterType<ProductRepository>().As<IProductRepository>();
        }
    }
}
