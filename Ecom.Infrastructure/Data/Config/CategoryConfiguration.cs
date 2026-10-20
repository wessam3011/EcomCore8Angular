
using Ecom.Core.Entities.Product;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecom.Infrastructure.Data.Config
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(x => x.Name)
                   .IsRequired()
                   .HasMaxLength(30);

            builder.Property(x => x.Id)
                   .IsRequired();

            //seed data check if data is null or not, if null then won't make seeding
            builder.HasData(
                new Category { Id=1, Name="test", Description="test" }
                );
        }
    }
}




//namespace Ecom.Infrastructure.Data.Config
//{
//    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
//    {
//        public void Configure(EntityTypeBuilder<Category> builder)
//        {
//            builder.Property(propertyExpression: Category x => x.Name).IsRequired().HasMaxLength(maxlength: 30);
//            builder.Property(propertyExpression: Category x => x.Id).IsRequired();


//        }
//    }
//}