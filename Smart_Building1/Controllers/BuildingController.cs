using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Smart_Building1.Model;
using Smart_Building1.Repository;
using Smart_Building1.Repository.Interface;
using Smart_Building1.Services;
using Smart_Building1.Services.Interface;

namespace Smart_Building1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BuildingController : ControllerBase
    {
        private readonly IBuildingRepo _buildingRepo;
        private readonly IBuildingService _buildingService;

        public BuildingController(IBuildingRepo buildingRepo, IBuildingService buildingService)
        {
            _buildingRepo = buildingRepo;
            _buildingService = buildingService;
        }

        [HttpGet]
        public IEnumerable<Building> GetBuildings()
        {
            return _buildingRepo.GetBuildings();
        }

        [HttpGet("{id}")]
        public Building GetBuilding(int id)
        {
            return _buildingRepo.GetBuilding(id);
        }

        [HttpPost]
        public async Task<ActionResult<Building>> CreateBuilding(Building building)
        {
            await _buildingService.AddBuildingAsync(building);
            return CreatedAtAction(nameof(CreateBuilding), new { id = building.Id}, building);   
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBuilding(int id, Building building)
        {
            if (id != building.Id)
            {
                return BadRequest();
            }

            await _buildingService.UpdateBuildingAsync(building);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBuildingAsync(int id)
        {
            await _buildingService.DeleteBuildingAsync(id);
            return NoContent();
        }
    }
}
