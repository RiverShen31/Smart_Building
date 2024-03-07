using Microsoft.AspNetCore.Mvc;
using Smart_Building1.Model;

namespace Smart_Building1.Repository.Interface
{
    public interface IApartmentRepo
    {
        public Task AddAsync(Apartment apartment);

        public Task UpdateAsync(Apartment apartment);

        public Task RemoveAsync(Apartment apartment);

        public IEnumerable<Apartment> GetApartments();

        public Apartment GetApartment(int id);
    }
}
