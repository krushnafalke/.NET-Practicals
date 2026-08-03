using System.ComponentModel.DataAnnotations;

namespace Assignment16.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        [Required (ErrorMessage = "Employee firstname is mandatory")]
        public string FirstName { get; set; } = string.Empty;

        [Required (ErrorMessage = "Employee lastname is mandatory")]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Employee email id is mandatory")]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        public string Mobile { get; set; } = string.Empty;

        public DateTime DateOfBirth { get; set; }

        public string Gender { get; set; } = string.Empty;

        public double Salary { get; set; }

        [Required (ErrorMessage = "Employee date of joining is mandatory")]
        public DateTime DateOfJoining { get; set; }

        [Required (ErrorMessage = "Employee demartment is mandatory")]
        public string Department { get; set; } = string.Empty;

        public string Designation { get; set; } = string.Empty;

        public string Status { get; set; } = "Active";
    }
}