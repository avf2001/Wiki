```csharp
using Microsoft.EntityFrameworkCore;

public class BookMapping : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.ToTable("Books").HasKey(book => book.Id);

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
    }
}

...

public class ApplicationDbContext : DbContext
{
    public override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Option 1: load mapping configuration from each class

        modelBuilder.ApplyConfiguration(new BookMapping());

        // Option 2: load mapping configuration from assembly

        // modelBuilder.ApplyConfigurationFrom Assembly
    }
}

...

public class Book : EntityBase
{
    public ICollection<Author> Authors = new HashSet<Author>();

    public Publisher? Publisher { get; set; }

    public BookRating? Rating { get; set; }
}

public enum BookRating
{
    VeryPoor = 1, 
    
    Poor = 2, 
    
    Average = 3, 
    
    Good = 4, 
    
    Excellent = 5
}

public class Author : EntityBase
{

}

public class Publisher : EntityBase
{
    public ICollection<Book> Books = new HashSet<Book>();
}
```
