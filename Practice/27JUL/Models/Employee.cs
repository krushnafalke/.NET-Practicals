using System.ComponentModel.DataAnnotations;

namespace _27JUL.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "emp id is required")]
        public int Id {get; set;}

        [Required(ErrorMessage = "emp name is required")]
        [StringLength(25, MinimumLength = 3,ErrorMessage = "Must ba at least 3 letters")]
        public string Name {get; set;}

       
        public string LastName {get; set;}

        [Required(ErrorMessage = "emp dept is required")]
        [StringLength(25,ErrorMessage = " Dept can not be more than 25 letters")]
        public string Dept {get; set;}

        [Required(ErrorMessage = "emp phone number is required")]
        public long PhoneNum {get; set;}
    }
}