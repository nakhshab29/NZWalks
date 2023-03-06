using NZWalksApi.Models.Domain;

namespace NZWalksApi.Repo
{
    public interface IRegionRepo
    {
        Task<IEnumerable<Region>> GetAllAsync();
    }
}
