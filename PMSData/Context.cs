namespace PMSData
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using PMSData.DbObjects;
    using System.Data.Entity;

    public partial class PmContext : IdentityDbContext
    {
        public PmContext()
            : base("name=PMSConnectionString")
        {
        }

        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Feature> Features { get; set; }
        public virtual DbSet<OfType> OfTypes { get; set; }
        public virtual DbSet<Photo> Photos { get; set; }
        public virtual DbSet<Property> Properties { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>()
                .HasMany(e => e.Properties)
                .WithRequired(e => e.Address)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OfType>()
                .HasMany(e => e.Properties)
                .WithRequired(e => e.OfType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Property>()
                .HasMany(e => e.Photos)
                .WithRequired(e => e.Property)
                .WillCascadeOnDelete(false);
        }
    }
}
