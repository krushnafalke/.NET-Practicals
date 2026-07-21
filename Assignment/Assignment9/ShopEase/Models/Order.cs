namespace ShopEase.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        public string CustomerName { get; set; } = "";

        public DateTime OrderDate { get; set; }

        public double Total { get; set; }

        public double GST { get; set; }

        public double Discount { get; set; }

        public double GrandTotal { get; set; }
    }
}