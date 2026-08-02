using System.ComponentModel.DataAnnotations;

namespace _29JUL.Models
{
    public class Vehicle
    {
        [Required(ErrorMessage = "Id is required")]
        public int VehicleId {get; set;}
        [Required(ErrorMessage = "Nameis required")]
        public string VehicleName {get; set;}
        

        
    }
}