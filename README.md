# Smart Shopping Cart Application

This Smart Shopping Cart application allows users to add and remove items, view their cart contents, and calculate the total cost of their purchases. The application simulates shopping at a mall with different shops such as grocery stores and clothing stores.

## Features

- **Product Management**: Create and categorize products using the `Product` class.
- **Shopping Cart**: Manage items in the shopping cart, including adding, removing, and viewing items.
- **Store Integration**: Shop at different stores, browse available products, and add items to the cart.
- **Checkout**: Generate a detailed bill listing all items, their prices, and the total cost upon checkout.
- **Console-Based UI**: Interactive console-based user interface for seamless user interaction.
- **Unit Tests**: Test adding and removing items from the cart and validate the calculation of the total cost.

## Project Structure
```
Smart-Cart-Application/
|── ShoppingCartApplicationTests/ (1.5 marks)
| └── ShoppingCartTests.cs
├── ShoppingCartApplication/
| ├── Program.cs (1.5 mark)
| ├── Product.cs
| ├── ShoppingCart.cs (2 marks)
| ├── GroceryStore.cs (1 mark)
| ├── ClothingStore.cs (1 mark)
| └── ProductGenerator.cs (2 marks)
└── README.md (1 mark)
```

## Classes

### Product Class

Represents individual items available for purchase.

- **Properties**:
  - `Name`: The name of the product.
  - `Price`: The price of the product.
  - `Category`: The category of the product (e.g., Food, Clothing, Electronics).

### ShoppingCart Class

Manages the items added by the user.

- **Methods**:
  - `AddProduct(Product product)`: Adds a product to the cart.
  - `RemoveProduct(Product product)`: Removes a product from the cart.
  - `ViewCart()`: Displays the contents of the cart.
  - `CalculateTotalCost()`: Calculates the total cost of the items in the cart.

### ProductGenerator Class

Generates random products with varying attributes.

- **Methods**:
  - `GenerateProduct()`: Creates a product with random attributes such as name, price, and category.

### GroceryStore Class

Represents a grocery store with available products.

- **Methods**:
  - `DisplayProducts()`: Displays the available products in the store.
  - `GetProductByName(string name)`: Retrieves a product by name.
  - `RemoveProduct(Product product)`: Removes a product from the store.

### ClothingStore Class

Represents a clothing store with available products.

- **Methods**:
  - `DisplayProducts()`: Displays the available products in the store.
  - `GetProductByName(string name)`: Retrieves a product by name.
  - `RemoveProduct(Product product)`: Removes a product from the store.

## User Interface

Implemented in `Program.cs` with the following functionalities:

- **Menu Options**:
  - Shop at Grocery Store
  - Shop at Clothing Store
  - View Cart
  - Calculate Total Cost
  - Checkout and Exit

- **Shop at Store**: Allows users to browse products and add selected items to the cart.
- **Checkout**: Generates a detailed bill listing all items, their prices, and the total cost.

## Unit Tests

Located in the `ShoppingCartApplicationTests` project:

- **ShoppingCartTests.cs**:
  - `AddProduct_ShouldAddProductToCart()`: Tests adding a product to the cart.
  - `RemoveProduct_ShouldRemoveProductFromCart()`: Tests removing a product from the cart.
  - `CalculateTotalCost_ShouldReturnSumOfProductPrices()`: Tests calculating the total cost of items in the cart.

