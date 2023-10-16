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

var (product2, alreadyExists2) = service.Create(new Product(Guid.NewGuid(), "Product 1", 1000.00m));

if (product2 is not null)
{
    Console.WriteLine("Product 2 created");
}
else if (alreadyExists2 is not null)
{
    Console.WriteLine("Product 2 already exists");
}


product = product! with
{
    Price = -100m
};

var (product3, notFound, error) = service.Update(product.Id, product);
if (product3 is not null)
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