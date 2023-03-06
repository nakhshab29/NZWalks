using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NZWalksApi.Models.Domain;
using NZWalksApi.Repo;

namespace NZWalksApi.Controllers
{
    [Route("Regions")]
    [ApiController]
    public class RegionController : ControllerBase
    {
        private readonly IRegionRepo _repo;
        private readonly IMapper _mapper;
        public RegionController(IRegionRepo repo, IMapper mapper)
        {
            this._mapper = mapper;
            this._repo = repo;
        }
        [HttpGet]
        public IActionResult GetAllRegions()
        {
            var regions =_repo.GetAll();

            // return Dto Regions

            //var regionsDto = new List<Region>();

            //regions.ToList().ForEach(region =>
            //{
            //    var regionDto = new Region()
            //    {
            //        Id = region.Id,
            //        Code = region.Code,
            //        Name = region.Name,
            //        Area = region.Area,
            //        Lat = region.Lat,
            //        Long = region.Long,
            //        Population = region.Population
            //    };



            //});

            var regionsDTO = _mapper.Map<List<Models.DTO.Region>>(regions);

            return Ok(regionsDTO);
        }
        
    }
}
