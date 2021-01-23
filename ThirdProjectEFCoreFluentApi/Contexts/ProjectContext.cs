using Microsoft.EntityFrameworkCore;
using ThirdProjectEFCoreFluentApi.Models;

namespace ThirdProjectEFCoreFluentApi.Contexts
{
    public class ProjectContext : DbContext
    {
        public ProjectContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Vendor> Vendor { get; set; }
        public DbSet<Tag> Tag { get; set; }

        //Using Fluent Api
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vendor>()
                .HasMany(t => t.Tags)
                .WithOne(v => v.Vendor)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
