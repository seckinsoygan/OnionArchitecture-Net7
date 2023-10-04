using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Onion.Domain.Entities;

namespace Onion.Persistence.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            Category category1 = new() { Id = 1, Name = "Elektrik", PriorityId = 1, ParentId = 0, isDeleted = false, CreatedDate = DateTime.Now };
            Category category2 = new() { Id = 2, Name = "Moda", PriorityId = 2, ParentId = 0, isDeleted = false, CreatedDate = DateTime.Now };
            Category parent1 = new() { Id = 3, Name = "Bilgisayar", PriorityId = 1, ParentId = 1, isDeleted = false, CreatedDate = DateTime.Now };
            Category parent2 = new() { Id = 4, Name = "Kadın", PriorityId = 1, ParentId = 2, isDeleted = false, CreatedDate = DateTime.Now };

            builder.HasData(category1, category2, parent1, parent2);
        }
    }
}
