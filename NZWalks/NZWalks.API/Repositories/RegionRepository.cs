using NZWalks.API.Data;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Repositories
{
    public class RegionRepository : IRegionRepository
    {
        private readonly NZWalksDbContext nzWalksDbContext;

        public RegionRepository(NZWalksDbContext NzWalksDbContext)
        {
            nzWalksDbContext = NzWalksDbContext;
        }

        public IEnumerable<Region> GetAll()
        {
            return nzWalksDbContext.Regions.ToList();
        }
    }
}
