using System.Data.Entity.ModelConfiguration;
using BookStore.Models;

namespace BookStore.Data.Mappings
{
    public class CategoryMap : EntityTypeConfiguration<Category>
    {
        public CategoryMap()
        {
            ToTable("Categoria");

            HasKey(p => p.Id);

            Property(p => p.Title)
                .HasColumnName("Titulo")
                .IsRequired();
        }
    }
}