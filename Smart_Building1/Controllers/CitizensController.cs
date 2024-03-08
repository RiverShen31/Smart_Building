using Microsoft.AspNetCore.Mvc;
using Smart_Building1.Model;
using Smart_Building1.Services.Interface;

namespace Smart_Building1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CitizensController : ControllerBase
    {
        private readonly ICitizenService _citizenService;

        public CitizensController(ICitizenService citizenService)
        {
            _citizenService = citizenService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Citizen>>> GetCitizens()
        {
            var citizens = await _citizenService.GetCitizensAsync();
            return Ok(citizens);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Citizen>> GetCitizen(int id)
        {
            var citizen = await _citizenService.GetCitizenByIdAsync(id);

            return Ok(citizen);
        }

        [HttpPost]
        public async Task<ActionResult<Citizen>> CreateCitizen(Citizen citizen)
        {
            var createdCitizen = await _citizenService.CreateCitizenAsync(citizen);
            return CreatedAtAction(nameof(GetCitizen), new { id = createdCitizen.Id }, createdCitizen);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCitizen(int id, Citizen citizen)
        {
            if (id != citizen.Id)
            {
                return BadRequest();
            }

            await _citizenService.UpdateCitizenAsync(citizen);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCitizen(int id)
        {
            await _citizenService.DeleteCitizenAsync(id);
            return NoContent();
        }
    }
}
