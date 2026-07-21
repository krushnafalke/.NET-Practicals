namespace ShopEase.Models
{
    public class Cart
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; } = "";

        public double Price { get; set; }

        public int Quantity { get; set; }

        public double Total
        {
            get
            {
                return Price * Quantity;
            }
        }
    }
}