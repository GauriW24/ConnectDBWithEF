
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ConnectDBWithEF.Models
{
    public class EFContext : System.Data.Entity.DbContext
    {
        public EFContext() : base("EFContext")
        {
        }
        public DbSet<Employee> Employees { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}