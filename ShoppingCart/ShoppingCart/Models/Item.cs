namespace ShoppingCart.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; } //MUG,TSHIRT, CAPS
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public List<string> Sizes { get; set; } = new();
        public List<string> Colors { get; set; } = new();
        public bool IsAvailable { get; set; }
    }
}
