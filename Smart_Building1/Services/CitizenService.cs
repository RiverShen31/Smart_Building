using Smart_Building1.Model;
using Smart_Building1.Repository.Interface;
using Smart_Building1.Services.Interface;

namespace Smart_Building1.Services
{
    public class CitizenService : ICitizenService
    {
        private readonly ICitizenRepo _citizenRepo;
        public CitizenService(ICitizenRepo citizenRepo)
        {
            _citizenRepo = citizenRepo;
        }

        public async Task<IEnumerable<Citizen>> GetCitizensAsync()
        {
            return await _citizenRepo.GetCitizensAsync();
        }

        public async Task<Citizen> GetCitizenByIdAsync(int id)
        {
            return await _citizenRepo.GetCitizenByIdAsync(id);
        }

        public async Task<Citizen> CreateCitizenAsync(Citizen citizen)
        {
            await _citizenRepo.AddCitizenAsync(citizen);
            return citizen;
        }

        public async Task UpdateCitizenAsync(Citizen citizen)
        {
            await _citizenRepo.UpdateCitizenAsync(citizen);
        }

        public async Task DeleteCitizenAsync(int id)
        {
            await _citizenRepo.DeleteCitizenAsync(id);
        }
    }
}
