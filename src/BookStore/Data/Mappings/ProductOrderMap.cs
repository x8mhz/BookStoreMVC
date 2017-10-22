using System.Data.Entity.ModelConfiguration;
using BookStore.Models;

namespace BookStore.Data.Mappings
{
    public class ProductOrderMap : EntityTypeConfiguration<ProductOrder>
    {
        public ProductOrderMap()
        {
            ToTable("PedidoProduto");

            HasKey(p => p.Id);

            Property(p => p.Quantity)
                .HasColumnName("Quantidade")
                .IsRequired();

            Property(p => p.Total)
                .HasColumnName("Total")
                .IsRequired();

            /* Relacionamentos */

            HasRequired(p => p.Order);

            HasMany(p => p.Products);
        }
    }
}