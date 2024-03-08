using Smart_Building1.Model;

namespace Smart_Building1.Services.Interface
{
    public interface IBuildingService
    {
        public Task AddBuildingAsync(Building building);

        public Task UpdateBuildingAsync(Building building);

        public Task DeleteBuildingAsync(int id);
    }
}
