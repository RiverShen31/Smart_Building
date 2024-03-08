using Smart_Building1.Model;
using Smart_Building1.Repository.Interface;
using Smart_Building1.Services.Interface;

namespace Smart_Building1.Services
{
    public class ApartmentService : IApartmentService
    {
        private readonly IApartmentRepo _apartmentRepo;
        public ApartmentService(IApartmentRepo apartmentRepo)
        {
            _apartmentRepo = apartmentRepo;
        }

        public async Task AddApartmentAsync(Apartment apartment)
        {
            await _apartmentRepo.AddAsync(apartment);
        }

        public async Task UpdateApartmentAsync(Apartment apartment)
        {
            await _apartmentRepo.UpdateAsync(apartment);
        }

        public async Task DeleteApartmentAsync(int id)
        {
            await _apartmentRepo.RemoveAsync(_apartmentRepo.GetApartment(id));
        }
    }
}
