using _29JUL.Models;
namespace _29JUL.Services
{
    public class VehicleService : IVehicleService
    {
        private static List<Vehicle> vehicles = new List<Vehicle>()
        {
            new Vehicle{VehicleId = 101, VehicleName="Car"},
            new Vehicle{VehicleId = 102, VehicleName="Bike"}

        };
        public List<Vehicle> getVehicles()
        {
            return vehicles;
        }
        public Vehicle? getVehicle(int vehicleid)
        {
            return vehicles.FirstOrDefault(e => e.VehicleId == e.VehicleId);
        }

        public Vehicle? getVehicleName(string VehicleName)
        {
            return vehicles.FirstOrDefault(e => e.VehicleName == e.VehicleName);
        }

        public Vehicle addVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
            return vehicle;
            
        }
    }
}