namespace ACME.Data
{
    using System;
    using System.Data.Entity;

    public partial class ACMEContext : DbContext
    {
        public ACMEContext()
            : base("name=ACMEContext")
        {
            this.Database.Log = (query) => Console.WriteLine(query);
            this.Configuration.AutoDetectChangesEnabled = false;
        }

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomerAddress> CustomerAddresses { get; set; }
        public virtual DbSet<DistributionCompany> DistributionCompanies { get; set; }
        public virtual DbSet<DistributionCompanyAddress> DistributionCompanyAddresses { get; set; }
        public virtual DbSet<PrintDistribution> PrintDistributions { get; set; }
        public virtual DbSet<Publication> Publications { get; set; }
        public virtual DbSet<Subscription> Subscriptions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>()
                .HasMany(e => e.CustomerAddresses)
                .WithRequired(e => e.Country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.DistributionCompanyAddresses)
                .WithRequired(e => e.Country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.CustomerAddresses)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CustomerAddress>()
                .HasMany(e => e.Subscriptions)
                .WithRequired(e => e.CustomerAddress)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DistributionCompany>()
                .Property(e => e.EndPoint)
                .IsUnicode(false);

            modelBuilder.Entity<DistributionCompany>()
                .HasMany(e => e.DistributionCompanyAddresses)
                .WithRequired(e => e.DistributionCompany)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DistributionCompany>()
                .HasMany(e => e.PrintDistributions)
                .WithRequired(e => e.DistributionCompany)
                .HasForeignKey(e => e.DistributionCompnayId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Subscription>()
                .HasMany(e => e.PrintDistributions)
                .WithRequired(e => e.Subscription)
                .WillCascadeOnDelete(false);
        }
    }
}
