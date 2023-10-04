using Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Onion.Domain.Entities;

namespace Onion.Persistence.Configurations
{
    public class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(256);

            Faker faker = new("tr");

            Brand brand1 = new() { Id = 1, Name = faker.Commerce.Department(), CreatedDate = DateTime.Now, isDeleted = false };
            Brand brand2 = new() { Id = 2, Name = faker.Commerce.Department(), CreatedDate = DateTime.Now, isDeleted = false };
            Brand brand3 = new() { Id = 3, Name = faker.Commerce.Department(), CreatedDate = DateTime.Now, isDeleted = true };

            builder.HasData(brand1, brand2, brand3);
        }
    }
}
