using System.ComponentModel.DataAnnotations;
namespace _24JJUL.Models
{
    public class Student
    {
        [Required (ErrorMessage="Username is required")]
        public string Username {get; set;}
        
        [Required (ErrorMessage="Password is required")]
        public string Password {get; set;}

    }
}