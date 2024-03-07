using Smart_Building1.Model;

namespace Smart_Building1.Services.Interface
{
    public interface ICitizenService
    {
        Task<IEnumerable<Citizen>> GetCitizensAsync();

        Task<Citizen> GetCitizenByIdAsync(int id);

        Task<Citizen> CreateCitizenAsync(Citizen citizen);

        Task UpdateCitizenAsync(Citizen citizen);

        Task DeleteCitizenAsync(int id);
    }
}
