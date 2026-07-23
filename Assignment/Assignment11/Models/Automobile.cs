using System.ComponentModel.DataAnnotations;

namespace Assignment11.Models
{
    public class Automobile
    {
        [Required(ErrorMessage ="Vehicle ID is required")]
        public int VehicleId { get; set; }

        [Required(ErrorMessage ="Vehicle Name is required")]
        [StringLength(30, MinimumLength = 3, ErrorMessage ="Vehicle Name must be between 3 and 30 characters")]
        public string VehicleName { get; set; }

        [Required(ErrorMessage ="Brand is required")]
        public string Brand { get; set; }

        [Required(ErrorMessage ="Model Year is required")]
        [Range(2000,2100,ErrorMessage ="Enter valid Model Year")]
        public int ModelYear { get; set; }

        [Required(ErrorMessage ="Price is required")]
        [Range(50000,10000000,ErrorMessage ="Enter valid Price")]
        public decimal Price { get; set; }

        [Required(ErrorMessage ="Fuel Type is required")]
        [RegularExpression("Petrol|Diesel|Electric|CNG|Hybrid", ErrorMessage ="Fuel must be Petrol, Diesel, Electric, CNG or Hybrid")]
        public string FuelType { get; set; }
    }
}