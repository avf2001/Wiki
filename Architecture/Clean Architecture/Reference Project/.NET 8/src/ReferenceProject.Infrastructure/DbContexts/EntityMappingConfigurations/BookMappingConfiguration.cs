using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReferenceProject.Domain.Entities;

namespace ReferenceProject.Infrastructure.DbContexts.EntityMappingConfigurations
{
    internal class BookMappingConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {            
            builder.ToTable("Books").HasKey(book => book.Id);
            
            /*
            // One-to-many mapping

            builder
                .HasOne(book => book.Publisher)
                .WithMany(publisher => publisher.Books)
                .HasPrincipalKey(publisher => publisher.Id)
                .HasForeignKey(book => book.PublisherId);

            // Enum mapping

            builder
                .Property(book => book.Rating)
                .HasColumnType("varchar(32)")
                .HasConversion<string>();


            // Needs example

            // builder
            //     .OwnsOne(book => book. ...)
            //     .ToTable("...");

            // builder
            //     .OwnsMany(book => book. ...)
            //     .ToTable("...");

            ...

            // Seed data
            builder.HasData(
                new Book() {
                    ...
                }
            );
            */
        }
    }
}
