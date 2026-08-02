using _29JUL.Models;

namespace _29JUL.Services
{
    public interface IVehicleService
    {
        List<Vehicle> getVehicles();
        Vehicle? getVehicle(int deptid);
        Vehicle? getVehicleName(string Name);
        Vehicle addVehicle(Vehicle vehicle);
    }
}