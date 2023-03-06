using NZWalksApi.Data;
using NZWalksApi.Models.Domain;

namespace NZWalksApi.Repo
{
    public class RegionRepo : IRegionRepo
    {
        private readonly NZDbContext _context;

        public RegionRepo(NZDbContext context)
        {
            this._context = context;
        }
        public IEnumerable<Region> GetAll()
        {
           return  _context.Regions.ToList();
        }
    }
}
