﻿public class GroceryStore
{
    private List<Product> products;

    public GroceryStore(ProductGenerator generator, int numberOfProducts)
    {
        products = new List<Product>();
        for (int i = 0; i < numberOfProducts; i++)
        {
            var product = generator.GenerateProduct();
            if (product.Category == ProductCategory.Food)
            {
                products.Add(product);
            }
        }
    }

    public void DisplayProducts()
    {
        Console.WriteLine("Grocery Store Products:");
        foreach (var product in products)
        {
            Console.WriteLine(product);
        }
    }

    public Product GetProductByName(string name)
    {
        return products.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
    }

    public void RemoveProduct(Product product)
    {
        products.Remove(product);
    }
}
