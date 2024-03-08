using Smart_Building1.Data;
using Smart_Building1.Model;
using Smart_Building1.Repository.Interface;

namespace Smart_Building1.Repository
{
    public class ApartmentRepo : IApartmentRepo
    {
        private readonly AppDbContext _context;
        public ApartmentRepo(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Apartment apartment)
        {
            _context.Apartments.Add(apartment);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Apartment apartment)
        {
            _context.Apartments.Update(apartment);
            await _context.SaveChangesAsync();
        }

        public async Task RemoveAsync(Apartment apartment)
        {
            _context.Apartments.Remove(apartment);
            await _context.SaveChangesAsync();
        }

        public IEnumerable<Apartment> GetApartments()
        {
            return _context.Apartments.ToList();
        }

        public Apartment GetApartment(int id)
        {
            return _context.Apartments.Find(id)!;
        }
    }
}
