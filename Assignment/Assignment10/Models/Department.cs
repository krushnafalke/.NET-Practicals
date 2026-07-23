using System.ComponentModel.DataAnnotations;

namespace Assignment10.Models
{
    public class Department
    {
        [Required(ErrorMessage = "Department Name is required")]
        public string DepartmentName { get; set; }

        [Required(ErrorMessage = "Department Head is required")]
        public string DepartmentHead { get; set; }

        [Required(ErrorMessage = "Contact Number is required")]
        [RegularExpression(@"^[0-9]{10}$",
            ErrorMessage = "Enter valid 10 digit number")]
        public string HeadContactNumber { get; set; }

        [Required(ErrorMessage = "Head Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email")]
        public string HeadEmail { get; set; }
    }
}