using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DemoMovies.DL.Entity;

namespace Movies.Repository.EntityTypeConfigurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Products>
    {
        public void Configure(EntityTypeBuilder<Products> builder)
        {
            builder.ToTable("Products");

            builder.HasKey(pk => pk.ProductId);

            builder.HasOne(fk => fk.Categories)
                .WithMany(fk => fk.products)
                .HasForeignKey(fk => fk.CategoryId);
        }
    }
}