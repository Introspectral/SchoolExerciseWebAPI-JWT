using Biluthyrning.Data;

namespace Biluthyrning.Interface
{
    public interface IVehicleTypeRepository  
    {
        public Task<bool> CreateVehicleType(VehicleType vehicleType);
        public VehicleType GetById(int vehicleTypeId);
        public Task UpdateVehicleType(VehicleType vehicleType);
        public Task DeleteVehicleType(VehicleType vehicleType);
        public List<VehicleType> GetAll();
    }
}
