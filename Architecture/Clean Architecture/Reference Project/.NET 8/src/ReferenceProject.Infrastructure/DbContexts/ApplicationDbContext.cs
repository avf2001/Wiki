using Microsoft.EntityFrameworkCore;
using ReferenceProject.Domain.Entities;
using ReferenceProject.Infrastructure.DbContexts.EntityMappingConfigurations;

namespace ReferenceProject.Infrastructure.DbContexts
{
    internal class ApplicationDbContext : DbContext
    {
        #region Конструктор

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        #endregion

        #region DbSets

        public DbSet<Book> Books { get; } = new Set<Book>();

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Option 1: load mapping configuration from each class

            modelBuilder.ApplyConfiguration(new BookMappingConfiguration());

            // Option 2: load mapping configuration from assembly

            //modelBuilder.ApplyConfigurationsFromAssembly(System.Reflection.Assembly.GetExecutingAssembly());
        }
    }
}
