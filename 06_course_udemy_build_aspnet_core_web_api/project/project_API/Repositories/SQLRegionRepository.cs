using Microsoft.EntityFrameworkCore;
using project_API.Data;
using project_API.Models.Domain;

namespace project_API.Repositories
{
    public class SQLRegionRepository : IRegionRepository
    {
        private readonly ProjectDbContext dbContext;
        public SQLRegionRepository(ProjectDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<List<Region>> GetAllAsync()
        {
            return await dbContext.Regions.ToListAsync();
        }
        public async Task<Region?> GetByIdAsync(Guid id)
        {
            return await dbContext.Regions.FirstOrDefaultAsync(x =>x.Id == id);
        }
        public async Task<Region> CreateAsync(Region region)
        {
            await dbContext.Regions.AddAsync(region);
            await dbContext.SaveChangesAsync();
            return region;
        }
    }
}
