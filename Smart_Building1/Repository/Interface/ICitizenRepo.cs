using Smart_Building1.Model;

namespace Smart_Building1.Repository.Interface
{
    public interface ICitizenRepo
    {
        Task<IEnumerable<Citizen>> GetCitizensAsync();

        Task<Citizen> GetCitizenByIdAsync(int id);

        Task AddCitizenAsync(Citizen citizen);

        Task UpdateCitizenAsync(Citizen citizen);

        Task DeleteCitizenAsync(int id);
    }
}
