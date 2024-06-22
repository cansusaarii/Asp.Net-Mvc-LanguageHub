namespace EmptyCoreWebApplication.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public String? ProductName { get; set; } = String.Empty;
        public decimal Price { get; set; }
        public string Description { get; set; } = String.Empty;
    }
}
