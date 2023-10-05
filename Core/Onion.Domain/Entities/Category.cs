using Onion.Domain.Common;

namespace Onion.Domain.Entities
{
    public class Category : EntityBase
    {
        public Category()
        {

        }
        public Category(int ParentId, string Name, int PriorityId)
        {
            this.ParentId = ParentId;
            this.Name = Name;
            this.PriorityId = PriorityId;
        }
        public int ParentId { get; set; }
        public string Name { get; set; }
        public int PriorityId { get; set; }
        public ICollection<Detail> Details { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
