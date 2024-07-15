public class ProductGenerator
{
    private static Random random = new Random();

    public Product GenerateProduct()
    {
        string[] productNames = { "Apple", "T-Shirt", "Laptop", "Banana", "Jeans", "Smartphone" };
        ProductCategory[] categories = { ProductCategory.Food, ProductCategory.Clothing, ProductCategory.Electronics };

        string name = productNames[random.Next(productNames.Length)];
        decimal price = Math.Round((decimal)(random.NextDouble() * 100), 2);
        ProductCategory category = categories[random.Next(categories.Length)];

        return new Product(name, price, category);
    }
}
