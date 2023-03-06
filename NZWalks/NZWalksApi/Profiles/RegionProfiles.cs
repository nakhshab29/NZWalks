using AutoMapper;

namespace NZWalksApi.Profiles
{
    public class RegionProfiles:Profile
    {
        public RegionProfiles()
        {
            CreateMap<Models.Domain.Region, Models.DTO.Region>(); 
        }
    }
}
