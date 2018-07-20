using IMS.Core.Entities;
using System.Data.Entity;

namespace IMS.Infrastructure.Data
{
    public class IMSContext : DbContext
    {
        public IMSContext() : base("IMSContext")
        {
        }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<LineItem> LineItems { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<PaymentTerm> PaymentTerms { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<PurchaseOrder> PurchaseOrders { get; set; }
        public DbSet<SalesOrder> SalesOrders { get; set; }
        public DbSet<StateProvince> StateProvinces { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Tax> Taxes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
