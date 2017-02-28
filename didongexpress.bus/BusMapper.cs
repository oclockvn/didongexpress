using AutoMapper;

namespace didongexpress.bus
{
    /// <summary>
    /// used to map from app to business
    /// and from business to repo
    /// </summary>
    public class BusMapper
    {
        public static IMapper Factory { get; private set; }

        public static void Register()
        {
            var configure = new MapperConfiguration(config =>
            {
                // create map
                // config.CreateMap<T1, T2>();
            });

            Factory = configure.CreateMapper();
        }
    }
}
