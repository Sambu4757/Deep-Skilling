namespace RetailInventory.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }

        // Many-to-one: a Product belongs to one Category
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
