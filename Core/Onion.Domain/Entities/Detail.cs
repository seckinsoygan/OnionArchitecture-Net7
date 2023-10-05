using Onion.Domain.Common;

namespace Onion.Domain.Entities
{
    public class Detail : EntityBase
    {
        public Detail()
        {

        }
        public Detail(string Title, string Description, int CategoryId)
        {
            this.Title = Title;
            this.Description = Description;
            this.CategoryId = CategoryId;
        }
        public string Title { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public string Category { get; set; }
    }
}
