using Example.Models;
using OneOf;

namespace Example;

public class ProductService : IProductService
{
    private readonly List<Product> _products = new();
    
    public OneOf<Product, ProductAlreadyExists> Create(Product product)
    {
        if (_products.Exists(x => x.Name == product.Name))
        {
            return new ProductAlreadyExists();
        }

        _products.Add(product);
        return product;
    }

    public OneOf<Product, ProductNotFound, ProductError> Update(Guid id, Product product)
    {
        if (product.Price < 0)
        {
            return new ProductError("Product.Price", "Price should be greater than zero");
        }
        
        var existingProduct = _products.FirstOrDefault(x => x.Id == id);
        if (existingProduct is null)
        {
            return new ProductNotFound();
        }

        existingProduct = existingProduct with
        {
            Name = product.Name,
            Price = product.Price
        };

        return existingProduct;
    }
}