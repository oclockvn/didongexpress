using Autofac;
using AutoMapper;
using didongexpress.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace didongexpress.repos
{
    public class RepositoryConfig
    {
        public static IMapper Factory { get; private set; }
        public static void Register(ContainerBuilder builder)
        {
            // var builder = new ContainerBuilder();

            builder.Register(t => new ExpressDb()).InstancePerRequest();

            var configure = new MapperConfiguration(config =>
            {

            });

            Factory = configure.CreateMapper();
        }
    }
}
