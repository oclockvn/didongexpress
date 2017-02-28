using AutoMapper;

namespace didongexpress
{
    public class MapperConfig
    {
        public static IMapper Factory { get; private set; }

        public static void Register()
        {
            var configure = new MapperConfiguration(config =>
            {

            });

            Factory = configure.CreateMapper();
        }
    }
}