using System.Data.Entity;

namespace SupplierDatabase.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Supplier> Suppliers { get; set; }

        public ApplicationDbContext() : base("DefaultConnection")
        {
        }
    }
}
