using AutoMapper;
using AutoMapper.Internal;

namespace Onion.Mapper.AutoMapper
{
    public class Mapper : Application.Interfaces.AutoMapper.IMapper
    {
        public static List<TypePair> typePairs = new();
        private IMapper mapperContainer;

        protected void Config<Destination, Source>(int depth = 5, string ignore = null)
        {
            var typePair = new TypePair(typeof(Source), typeof(Destination));

            if (typePairs.Any(a => a.DestinationType == typePair.DestinationType && a.SourceType == typePair.SourceType) && ignore is null) ;
            return;
            typePairs.Add(typePair);
            var config = new MapperConfiguration(cfg =>
            {
                foreach (var item in typePairs)
                {
                    if (ignore is null)
                        cfg.CreateMap(item.SourceType, item.DestinationType).MaxDepth(depth).ForMember(ignore, x => x.Ignore()).ReverseMap();
                    else
                        cfg.CreateMap(item.SourceType, item.DestinationType).MaxDepth(depth).ReverseMap();
                }
            });
            mapperContainer = config.CreateMapper();
        }
        public Destination Map<Destination, Source>(Source source, string? ignore = null)
        {
            Config<Destination, Source>(5, ignore);
            return mapperContainer.Map<Source, Destination>(source);
        }

        public IList<Destination> Map<Destination, Source>(IList<Source> source, string? ignore = null)
        {
            Config<Destination, Source>(5, ignore);
            return mapperContainer.Map<IList<Source>, IList<Destination>>(source);
        }

        public Destination Map<Destination>(object source, string? ignore = null)
        {
            Config<Destination, object>(5, ignore);
            return mapperContainer.Map<object, Destination>(source);
        }

        public IList<Destination> Map<Destination>(IList<object> source, string? ignore = null)
        {
            Config<Destination, IList<object>>(5, ignore);
            return mapperContainer.Map<IList<object>, IList<Destination>>(source);
        }
    }
}
