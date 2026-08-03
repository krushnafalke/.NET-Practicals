using System.ComponentModel.DataAnnotations;

namespace Assignment16.Models
{
    public class Department
    {
        public int Id { get; set; }

        [Required (ErrorMessage = "Department name is mandatory")]
        [StringLength(50)]
        public string DepartmentName { get; set; } = string.Empty;

        public string DepartmentCode { get; set; } = string.Empty;

        public string Status { get; set; } = "Active";
    }
}