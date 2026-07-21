namespace ShopEase.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        public string Name { get; set; } = "";

        public string Category { get; set; } = "";

        public string Description { get; set; } = "";

        public double Price { get; set; }

        public int Quantity { get; set; }

        public string Brand { get; set; } = "";

        public double Discount { get; set; }

        public double Rating { get; set; }
    }
}