using Smart_Building1.Data;
using Smart_Building1.Model;
using Smart_Building1.Repository.Interface;

namespace Smart_Building1.Repository
{
    public class BuildingRepo : IBuildingRepo
    {
        private readonly AppDbContext _context;
        
        public BuildingRepo(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Building building)
        {
            _context.Buildings.Add(building);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Building building)
        {
            _context.Buildings.Update(building);
            await _context.SaveChangesAsync();
        }

        public async Task RemoveAsync(Building building)
        {
            _context.Buildings.Remove(building);
            await _context.SaveChangesAsync();
        }

        public IEnumerable<Building> GetBuildings()
        {
            return _context.Buildings.ToList();
        }

        public Building GetBuilding(int id)
        {
            return _context.Buildings.Find(id)!;
        }
    }
}
