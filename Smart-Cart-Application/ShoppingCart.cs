public class ShoppingCart
{
    private List<Product> items;

    public ShoppingCart()
    {
        items = new List<Product>();
    }

    public IReadOnlyList<Product> Items => items.AsReadOnly();

    public void AddProduct(Product product)
    {
        items.Add(product);
    }

    public void RemoveProduct(Product product)
    {
        items.Remove(product);
    }

    public void ViewCart()
    {
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }

    public decimal CalculateTotalCost()
    {
        return items.Sum(item => item.Price);
    }
}
