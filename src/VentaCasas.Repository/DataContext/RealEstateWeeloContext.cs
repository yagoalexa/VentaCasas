using Microsoft.EntityFrameworkCore;
using VentaCasas.Entities.POCOs;

namespace VentaCasas.Repository.DataContext
{
    public class VentaCasasContext : DbContext
    {
        public VentaCasasContext(DbContextOptions<VentaCasasContext> options)
            : base(options)
        {

        }
        public DbSet<Owner> Owner { get; set; }
        public DbSet<Property> Property { get; set; }
        public DbSet<PropertyImage> PropertyImage { get; set; }
        public DbSet<PropertyTrace> PropertyTrace { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Owner>()
                .Property(p => p.Id)
                .HasColumnName(nameof(Owner) + "Id");
            modelBuilder.Entity<Owner>()
                .HasKey(t => t.Id);
            modelBuilder.Entity<Property>()
                .Property(p => p.Id)
                .HasColumnName(nameof(Property) + "Id");
            modelBuilder.Entity<Property>()
               .Property(p => p.CodeInternal)
               .IsRequired();
            modelBuilder.Entity<Property>()
               .Property(p => p.Address)
               .IsRequired();
            modelBuilder.Entity<Property>()
               .Property(p => p.Name)
               .IsRequired();
            modelBuilder.Entity<Property>()
                .HasKey(t => t.Id);
            modelBuilder.Entity<PropertyImage>()
                .Property(t => t.Id)
                .HasColumnName(nameof(PropertyImage) + "Id");
            modelBuilder.Entity<PropertyImage>()
                .HasKey(t => t.Id);
            modelBuilder.Entity<PropertyTrace>()
                .Property(t => t.Id)
                .HasColumnName(nameof(PropertyTrace) + "Id");
            modelBuilder.Entity<PropertyTrace>()
                .HasKey(t => t.Id);
        }
    }
}
