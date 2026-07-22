using System.ComponentModel.DataAnnotations;

namespace _22JUL.Models
{
    public class Stationery
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Item Name is required")]
        public string ItemName { get; set; }

        [Required(ErrorMessage = "Category is required")]
        public string Category { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [Range(1, 10000, ErrorMessage = "Price must be between 1 and 10000")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Quantity is required")]
        [Range(1, 1000)]
        public int Stock { get; set; }
    }
}