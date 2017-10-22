using System.Data.Entity.ModelConfiguration;
using BookStore.Models;

namespace BookStore.Data.Mappings
{
    public class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            ToTable("Produto");

            HasKey(p => p.Id);

            Property(p => p.Title)
                .HasColumnName("Titulo")
                .IsRequired();

            Property(p => p.Price)
                .HasColumnName("Valor")
                .IsRequired();

            HasRequired(p => p.Category);
        }
    }
}