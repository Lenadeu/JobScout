using JobScout.Web.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace JobScout.Web.Infrastructure.Data
{

    // JobScoutDbContext inherits from base class DbContext
    public class JobScoutDbContext : DbContext
    {
        // constructor.
        // gets DB configuration as a parameter called options
        // and sends it to the constructor of the base class
        public JobScoutDbContext(DbContextOptions<JobScoutDbContext> options)
                :base(options)
        {

        }
        // Property represent the collection of companies
        // DbSet - entity collection that EF Core can query and save
        // DbSet<Company> - EF Core set containing Company entities
        // Set<Company>() - asks the DbContext for the set of Company entities
        // => provides short property implementation, when Companies are called, the
        // set of companies is returned. this is called expression-bodied member
        // Companies is read-only property
        public DbSet<Company> Companies => Set<Company>();

        public DbSet<JobApplication> JobApplications => Set<JobApplication>();

        public DbSet<JobPosition> JobPositions => Set<JobPosition>();

    }
}
