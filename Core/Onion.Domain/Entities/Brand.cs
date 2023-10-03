using Onion.Domain.Common;

namespace Onion.Domain.Entities
{
    public class Brand : EntityBase
    {
        public required string Name { get; set; }
        public Brand()
        {

        }
        public Brand(string Name)
        {
            this.Name = Name;
        }
    }
}
