using Microsoft.EntityFrameworkCore;
using project_API.Models.Domain;

namespace project_API.Data
{
    public class ProjectDbContext : DbContext
    {
        public ProjectDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {   
        }

        public DbSet<Difficulty> Difficulties {  get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
    }
}
