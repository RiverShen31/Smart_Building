using Smart_Building1.Model;

namespace Smart_Building1.Repository.Interface
{
    public interface IBuildingRepo
    {
        public Task AddAsync(Building building);

        public Task UpdateAsync(Building building);

        public Task RemoveAsync(Building building);

        public IEnumerable<Building> GetBuildings();

        public Building GetBuilding(int id);
    }
}
