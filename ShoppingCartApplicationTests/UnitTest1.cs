using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using ShoppingCartApplication;

namespace ShoppingCartApplicationTests
{
    public class ShoppingCartTests
    {
        [Fact]
        public void AddProduct_ShouldAddProductToCart()
        {
            // Arrange
            var cart = new ShoppingCart();
            var product = new Product("Test Product", 10.99m, ProductCategory.Food);

            // Act
            cart.AddProduct(product);

            // Assert
            Assert.Contains(product, cart.Items);
        }

        [Fact]
        public void RemoveProduct_ShouldRemoveProductFromCart()
        {
            // Arrange
            var cart = new ShoppingCart();
            var product = new Product("Test Product", 10.99m, ProductCategory.Food);
            cart.AddProduct(product);

            // Act
            cart.RemoveProduct(product);

            // Assert
            Assert.DoesNotContain(product, cart.Items);
        }

        [Fact]
        public void CalculateTotalCost_ShouldReturnSumOfProductPrices()
        {
            // Arrange
            var cart = new ShoppingCart();
            var product1 = new Product("Test Product 1", 10.99m, ProductCategory.Food);
            var product2 = new Product("Test Product 2", 20.50m, ProductCategory.Clothing);
            cart.AddProduct(product1);
            cart.AddProduct(product2);

            // Act
            var totalCost = cart.CalculateTotalCost();

            // Assert
            Assert.Equal(31.49m, totalCost);
        }
    }
}
