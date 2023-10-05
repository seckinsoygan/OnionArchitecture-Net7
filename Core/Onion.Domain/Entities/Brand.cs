using Onion.Domain.Common;

namespace Onion.Domain.Entities
{
    public class Brand : EntityBase
    {
        public string Name { get; set; }
        public Brand()
        {

        }
        public Brand(string Name)
        {
            this.Name = Name;
        }
    }
}
