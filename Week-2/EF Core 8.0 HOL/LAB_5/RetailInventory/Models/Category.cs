namespace RetailInventory.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        // One-to-many: a Category has many Products
        public List<Product> Products { get; set; } = new();
    }
}
