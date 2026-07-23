using System.ComponentModel.DataAnnotations;

namespace Assignment11.Models
{
    public class Manufacturer
    {
        [Required]
        public string ManufacturerName { get; set; }

        [Required]
        public string Country { get; set; }

        [Required]
        [RegularExpression(@"^[0-9]{10}$",
            ErrorMessage ="Enter valid Contact Number")]
        public string ContactNumber { get; set; }

        [Required]
        [EmailAddress(ErrorMessage ="Invalid Email")]
        public string EmailAddress { get; set; }
    }
}