using Biluthyrning.Data;
using Biluthyrning.Interface;

namespace Biluthyrning.Repositorys
{
    public class VehicleTypeRepository : IVehicleTypeRepository
    {
        private HttpClient client;
        public VehicleTypeRepository(HttpClient client)
        {
            this.client = client;
        }
        public async Task<bool> CreateVehicleType(VehicleType vehicleType)
        {
            int id = vehicleType.VehicleTypeId;
            client.DefaultRequestHeaders.Clear();
            await client.PutAsJsonAsync($"/api/VehicleTypes", id);
            return true;
        }

        public async Task DeleteVehicleType(VehicleType vehicleType)
        {
            int id = vehicleType.VehicleTypeId;
            client.DefaultRequestHeaders.Clear();
            await client.PutAsJsonAsync($"/api/VehicleTypes", id);
        }

        public List<VehicleType> GetAll()
        {
            return client.GetFromJsonAsync<List<VehicleType>>("/api/VehicleTypes").Result;
        }

        public VehicleType GetById(int vehicleTypeId)
        {
            return client.GetFromJsonAsync<VehicleType>($"/api/VehicleTypes/{vehicleTypeId}").Result;
        }

        public async Task UpdateVehicleType(VehicleType vehicleType)
        {
            int id = vehicleType.VehicleTypeId;
            client.DefaultRequestHeaders.Clear();
            await client.PutAsJsonAsync($"/api/VehicleTypes", id);
        }
    }
}
