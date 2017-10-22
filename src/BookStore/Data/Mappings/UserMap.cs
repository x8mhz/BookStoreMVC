using System.Data.Entity.ModelConfiguration;
using BookStore.Models;

namespace BookStore.Data.Mappings
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            ToTable("Usuario");

            HasKey(p => p.Id);

            Property(p => p.Email)
                .HasColumnName("Email")
                .HasMaxLength(150)
                .IsRequired();

            Property(p => p.Password)
                .HasColumnName("Senha")
                .HasMaxLength(15)
                .IsRequired();

            Property(p => p.Active)
                .HasColumnName("Ativacao")
                .IsRequired();

            Property(p => p.Code)
                .HasColumnName("Codigo")
                .IsRequired();

            Property(p => p.RegisterDate)
                .HasColumnName("Registro")
                .IsRequired();

            HasOptional(p => p.Orders);
        }
    }
}