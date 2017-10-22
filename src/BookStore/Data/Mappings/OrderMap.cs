using BookStore.Models;
using System.Data.Entity.ModelConfiguration;

namespace BookStore.Data.Mappings
{
    public class OrderMap : EntityTypeConfiguration<Order>
    {
        public OrderMap()
        {
            ToTable("Pedido");

            HasKey(p => p.Id);

            Property(p => p.OrderDate)
                .HasColumnName("DataPedido")
                .IsRequired();

            Property(p => p.SendDate)
                .HasColumnName("Data Envio")
                .IsRequired();

            Property(p => p.DeliveryDate)
                .HasColumnName("Data Entrega")
                .IsRequired();

            /* Relacionamento */
            HasRequired(p => p.User);

        }
    }
}