using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Smart_Building1.Data;
using Smart_Building1.Model;
using Smart_Building1.Repository.Interface;
using Smart_Building1.Services.Interface;

namespace Smart_Building1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ApartmentsController : ControllerBase
    {
        private readonly IApartmentRepo _apartmentRepo;
        private readonly IApartmentService _apartmentService;

        public ApartmentsController(IApartmentRepo apartmentRepo, IApartmentService apartmentService)
        {
            _apartmentRepo = apartmentRepo;
            _apartmentService = apartmentService;
        }

        [HttpGet]
        public IEnumerable<Apartment> GetApartments()
        {
            return _apartmentRepo.GetApartments();
        }

        [HttpGet("{id}")]
        public Apartment GetApartment(int id)
        {
            return _apartmentRepo.GetApartment(id);
        }

        [HttpPost]
        public async Task<ActionResult<Apartment>> CreateApartment(Apartment apartment)
        {
            await _apartmentService.AddApartmentAsync(apartment);
            return CreatedAtAction(nameof(GetApartment), new { id = apartment.Id }, apartment);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateApartment(int id, Apartment apartment)
        {
            if (id != apartment.Id)
            {
                return BadRequest();
            }

            await _apartmentService.UpdateApartmentAsync(apartment);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteApartment(int id)
        {
            await _apartmentService.DeleteApartmentAsync(id);
            return NoContent();
        }
    }
}
