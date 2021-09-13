using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DemoMovies.DL.Entity;

namespace Movies.Repository.EntityTypeConfigurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Categories>
    {
        public void Configure(EntityTypeBuilder<Categories> builder)
        {
            builder.ToTable("Categories");

            builder.HasKey(pk => new { pk.CategoryId });

            builder.HasMany(fk => fk.products)
            .WithOne(fk => fk.Categories)
                .HasForeignKey(fk => fk.CategoryId);

        }
    }
}
