namespace Onion.Application.Interfaces.AutoMapper
{
    public interface IMapper
    {
        Destination Map<Destination, Source>(Source source, string? ignore = null);
        IList<Destination> Map<Destination, Source>(IList<Source> source, string? ignore = null);

        Destination Map<Destination>(object source, string? ignore = null);

        IList<Destination> Map<Destination>(IList<object> source, string? ignore = null);
    }
}
