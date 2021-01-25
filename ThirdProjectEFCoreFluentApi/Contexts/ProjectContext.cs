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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vendor>()
                .HasKey(id => id.Id)
                .HasName("VendorId");

            modelBuilder.Entity<Vendor>()
                .ToTable("Vendor_FluentApi")
                .Property(b => b.Name)
                .HasColumnName("VendorName")
                .HasMaxLength(128)
                .IsRequired();

            modelBuilder.Entity<Vendor>()
                .Property(t => t.Title)
                .HasMaxLength(128)
                .IsRequired();

            modelBuilder.Entity<Vendor>()
                .Property(t => t.Date)
                .IsRequired();

            modelBuilder.Entity<Vendor>()
                .HasMany(t => t.Tags)
                .WithOne(v => v.Vendor)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);


            modelBuilder.Entity<Tag>()
                .ToTable("Tag_FluentApi")
                .HasKey(id => id.Id)
                .HasName("TagId");

            modelBuilder.Entity<Tag>()
                .HasOne(V => V.Vendor)
                .WithMany(t => t.Tags)
                .HasForeignKey(vId => vId.VendorId);

            modelBuilder.Entity<Tag>()
                .Property(vId => vId.VendorId)
                .IsRequired();

            modelBuilder.Entity<Tag>()
                .Property(n => n.Name)
                .HasMaxLength(128)
                .IsRequired();

            modelBuilder.Entity<Tag>()
                .Property(v => v.Value)
                .HasMaxLength(128)
                .IsRequired();
        }
    }
}
