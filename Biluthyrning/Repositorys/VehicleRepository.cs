using Biluthyrning.Data;
using Biluthyrning.Interface;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;

namespace Biluthyrning.Repositorys
{
    public class VehicleRepository : IVehicleRepository
    {
        private HttpClient client;

        public VehicleRepository(HttpClient client)
        {
            this.client = client;
        }
        public async Task CreateVehicle(Vehicle vehicle)
        {

            int id = vehicle.VehicleId;
            client.DefaultRequestHeaders.Clear();
            await client.PutAsJsonAsync($"/api/Vehicles", id);
            return;
        }

        public Vehicle GetVehicleById(int vehicleId)
        {

            return client.GetFromJsonAsync<Vehicle>($"/api/Vehicles/{vehicleId}").Result;
        }

        public async Task UpdateVehicle(Vehicle vehicle)
        {

            int id = vehicle.VehicleId;
            client.DefaultRequestHeaders.Clear();
            await client.PutAsJsonAsync($"/api/Vehicles", id);

		}

        public async Task DeleteVehicle(Vehicle vehicle)
        {

            int id = vehicle.VehicleId;
            client.DefaultRequestHeaders.Clear();
            await client.PutAsJsonAsync($"/api/Vehicles", id);
        }

        public List<Vehicle> GetAll()
        {

            return client.GetFromJsonAsync<List<Vehicle>>("/api/Vehicles").Result;
		}
    }
}   

