using Microsoft.EntityFrameworkCore;
using Smart_Building1.Data;
using Smart_Building1.Model;
using Smart_Building1.Repository.Interface;

namespace Smart_Building1.Repository
{
    public class CitizenRepo : ICitizenRepo
    {
        private readonly AppDbContext _context;

        public CitizenRepo(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Citizen>> GetCitizensAsync()
        {
            return await _context.Citizens.ToListAsync();
        }

        public async Task<Citizen> GetCitizenByIdAsync(int id)
        {
            return (await _context.Citizens.FindAsync(id))!;
        }

        public async Task AddCitizenAsync(Citizen citizen)
        {
            _context.Citizens.Add(citizen);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateCitizenAsync(Citizen citizen)
        {
            _context.Citizens.Update(citizen);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCitizenAsync(int id)
        {
            var citizen = await _context.Citizens.FindAsync(id);
            if (citizen != null)
            {
                _context.Citizens.Remove(citizen);
                await _context.SaveChangesAsync();
            }
        }
    }
}
