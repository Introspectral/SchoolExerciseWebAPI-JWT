using Biluthyrning.Data;

namespace Biluthyrning.Interface
{
    public interface IVehicleRepository
    {
		public Task CreateVehicle(Vehicle vehicle);
		public Vehicle GetVehicleById(int vehicleId);
		public Task UpdateVehicle(Vehicle vehicle);
		public Task DeleteVehicle(Vehicle vehicle);
		public List<Vehicle> GetAll();
	}
}
