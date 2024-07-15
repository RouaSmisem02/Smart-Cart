using System;
using System.Collections.Generic;

namespace ShoppingCartApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductGenerator generator = new ProductGenerator();
            ShoppingCart cart = new ShoppingCart();

            GroceryStore groceryStore = new GroceryStore(generator, 10);
            ClothingStore clothingStore = new ClothingStore(generator, 10);

            bool shopping = true;

            while (shopping)
            {
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Shop at Grocery Store");
                Console.WriteLine("2. Shop at Clothing Store");
                Console.WriteLine("3. View Cart");
                Console.WriteLine("4. Calculate Total Cost");
                Console.WriteLine("5. Checkout and Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ShopAtStore(groceryStore, cart);
                        break;
                    case "2":
                        ShopAtStore(clothingStore, cart);
                        break;
                    case "3":
                        cart.ViewCart();
                        break;
                    case "4":
                        Console.WriteLine($"Total Cost: ${cart.CalculateTotalCost()}");
                        break;
                    case "5":
                        shopping = false;
                        GenerateBill(cart);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void ShopAtStore(dynamic store, ShoppingCart cart)
        {
            bool shoppingAtStore = true;

            while (shoppingAtStore)
            {
                Console.WriteLine("Available Products:");
                store.DisplayProducts();

                Console.WriteLine("Enter the name of the product to add to the cart, or 'back' to return to the main menu:");
                string productName = Console.ReadLine();

                if (productName.ToLower() == "back")
                {
                    shoppingAtStore = false;
                }
                else
                {
                    Product selectedProduct = store.GetProductByName(productName);
                    if (selectedProduct != null)
                    {
                        cart.AddProduct(selectedProduct);
                        store.RemoveProduct(selectedProduct);
                        Console.WriteLine($"{selectedProduct.Name} has been added to your cart.");
                    }
                    else
                    {
                        Console.WriteLine("Product not available in the store.");
                    }
                }
            }
        }

        static void GenerateBill(ShoppingCart cart)
        {
            Console.WriteLine("\n--- Bill Summary ---");
            foreach (var item in cart.Items)
            {
                Console.WriteLine($"{item.Name} - ${item.Price}");
            }
            Console.WriteLine("---------------------");
            Console.WriteLine($"Total Cost: ${cart.CalculateTotalCost()}");
            Console.WriteLine("---------------------");
        }
    }
}
