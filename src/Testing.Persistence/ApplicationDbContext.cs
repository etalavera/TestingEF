using Microsoft.EntityFrameworkCore;
using Testing.Models;
using Testing.Models.Configuration;

namespace Testing.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        #region Constructor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options)
        {
        }
        #endregion Constructor

        #region Methods
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            new ClientConfiguration(modelBuilder.Entity<Client>());
        }
        #endregion Methods

        #region Properties
        public DbSet<Client> Clients { get; set; }
        #endregion Properties
    }
}
