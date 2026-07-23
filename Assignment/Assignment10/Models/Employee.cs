using System.ComponentModel.DataAnnotations;
using Microsoft.Net.Http.Headers;

namespace Assignment10.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "ID is mandatory")]
        public int Emp_ID {get; set;}

        [Required(ErrorMessage = "Name is mandatory")]
        public string Emp_Name {get; set;}

        [Required(ErrorMessage = "Department is mandatory")]
        public string Department {get; set;}

        [Required(ErrorMessage = "Salary is mandatory")]
        [Range(1000, 100000, ErrorMessage = "Enter valid salary")]
        public double Salary {get; set;}

        [Required(ErrorMessage = "Email is mandatory")]
        [EmailAddress(ErrorMessage = "Invalid Email")]
        public string Email {get; set;}
    }
}