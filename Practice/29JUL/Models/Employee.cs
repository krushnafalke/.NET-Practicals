using System.ComponentModel.DataAnnotations;

namespace _29JUL.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "Id is required")]
        public int Id {get; set;}
        [Required(ErrorMessage = "Nameis required")]
        public string Name {get; set;}
        [Range(8,10, ErrorMessage = "Number must be 8digit or 10digit")]
        public long PhoneN {get; set;}
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email {get; set;}
        [Required(ErrorMessage = "Department Id is required")]
        public int DeptId {get; set;}
    }
}