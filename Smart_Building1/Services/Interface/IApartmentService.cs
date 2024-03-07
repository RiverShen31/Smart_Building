using Smart_Building1.Model;

namespace Smart_Building1.Services.Interface
{
    public interface IApartmentService
    {
        public Task AddApartmentAsync(Apartment apartment);

        public Task UpdateApartmentAsync(Apartment apartment);

        public Task DeleteApartmentAsync(int id);
    }
}
