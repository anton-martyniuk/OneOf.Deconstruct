# OneOf.Deconstruct

Easily deconstruct and use OneOf options without the need for matching. This library offers extension methods for OneOf deconstruction to simplify its usage and make code cleaner.

## Installation

[Install a OneOf.Deconstruct nuget package](https://www.nuget.org/packages/OneOf.Deconstruct)

## Features

- Deconstruction extension methods for `OneOf` objects.
- Easy and clean handling of different OneOf outcomes.
- No need for lengthy matching syntax.

## Example of usage

Consider a `ProductService` which can either create or update a product:

### Creating a Product

[See full example here](https://github.com/anton-martyniuk/OneOf.Deconstruct/tree/main/src/Example)

```csharp
using Example;
using Example.Models;
using OneOf;

var service = new ProductService();

var (product, alreadyExists) = service.Create(new Product(Guid.NewGuid(), "Product 1", 1000.00m));

if (product is not null)
{
    Console.WriteLine("Product 1 created");
}
else if (alreadyExists is not null)
{
    Console.WriteLine("Product 1 already exists");
}
```

### Updating a product

```csharp
product = product! with
{
    Price = -100m
};

var (updatedProduct, notFound, error) = service.Update(product.Id, product);
if (updatedProduct is not null)
{
    Console.WriteLine("Product updated");
}
else if (notFound is not null)
{
    Console.WriteLine("Product not found for update");
}
else if (error is not null)
{
    Console.WriteLine($"Error updating. Code: {error.Code}, description: {error.Description}");
}
```

### Interface & Models

```csharp
public interface IProductService
{
    OneOf<Product, ProductAlreadyExists> Create(Product product);
    OneOf<Product, ProductNotFound, ProductError> Update(Guid id, Product product);
}

public record Product(Guid Id, string Name, decimal Price);
public record ProductAlreadyExists;
public record ProductNotFound;
public record ProductError(string Code, string Description);
```

## Acknowledgments

A big shoutout to the original [OneOf](https://github.com/mcintyre321/OneOf) library and its author for creating such a fantastic library. This package is built upon the foundation laid by the original library, and I am very grateful for the inspiration and the work put into it. Thank you!
