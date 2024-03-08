using Smart_Building1.Model;
using Smart_Building1.Repository;
using Smart_Building1.Repository.Interface;
using Smart_Building1.Services.Interface;

namespace Smart_Building1.Services
{
    public class BuildingService : IBuildingService
    {
        private readonly IBuildingRepo _buildingRepo;

        public BuildingService(IBuildingRepo buildingRepo)
        {
            _buildingRepo = buildingRepo;
        }

        public async Task AddBuildingAsync(Building building)
        {
            await _buildingRepo.AddAsync(building);
        }

        public async Task UpdateBuildingAsync(Building building)
        {
            await _buildingRepo.UpdateAsync(building);
        }

        public async Task DeleteBuildingAsync(int id)
        {
            await _buildingRepo.RemoveAsync(_buildingRepo.GetBuilding(id));
        }
    }
}
