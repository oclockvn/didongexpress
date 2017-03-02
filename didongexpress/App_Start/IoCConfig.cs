using Autofac;
using Autofac.Integration.Mvc;
using didongexpress.bus;
using didongexpress.bus.Bus;
using System.Web.Mvc;

namespace didongexpress
{
    public class IoCConfig
    {
        /// <summary>
        /// autofac register
        /// </summary>
        public static void Register()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(didongexpress.MvcApplication).Assembly);

            BusinessConfig.Register(builder);

            builder.RegisterType<Business>().As<IBusiness>();
            builder.RegisterType<ProductBusiness>().As<IProductBusiness>();                

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}