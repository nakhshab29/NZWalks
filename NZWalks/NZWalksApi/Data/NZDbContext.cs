using Microsoft.EntityFrameworkCore;
using NZWalksApi.Models.Domain;

namespace NZWalksApi.Data
{
    public class NZDbContext:DbContext
    {
        public NZDbContext(DbContextOptions<NZDbContext> options): base(options)
        {
            
        }

        public DbSet<Region> Regions { get; set; }

        public DbSet<Walk> Walks { get; set; }

        public DbSet<WalkDifficulty> WalkDifficulties { get; set; }

    }
}
