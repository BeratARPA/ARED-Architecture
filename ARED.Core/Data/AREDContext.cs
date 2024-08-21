using ARED.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace ARED.Core.Data
{
    public class AREDContext : DbContext
    {
        public AREDContext() : base() { }

        public AREDContext(DbContextOptions<AREDContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(@"data source=(localdb)\MSSQLLocalDB; initial catalog=ARED; integrated security=True;");
        }

        public DbSet<AppAction> AppActions { get; set; }
        public DbSet<AppRule> AppRules { get; set; }
        public DbSet<RuleActionMap> RuleActionMaps { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
