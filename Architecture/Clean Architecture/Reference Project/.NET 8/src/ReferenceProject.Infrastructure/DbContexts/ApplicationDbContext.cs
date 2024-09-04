using Microsoft.EntityFrameworkCore;
using ReferenceProject.Infrastructure.DbContexts.EntityMappingConfigurations;

namespace ReferenceProject.Infrastructure.DbContexts
{
    internal class ApplicationDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Option 1: load mapping configuration from each class

            modelBuilder.ApplyConfiguration(new BookMappingConfiguration());

            // Option 2: load mapping configuration from assembly

            //modelBuilder.ApplyConfigurationsFromAssembly(...)
        }
    }
}
