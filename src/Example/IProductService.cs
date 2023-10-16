using Example.Models;
using OneOf;

namespace Example;

public interface IProductService
{
    OneOf<Product, ProductAlreadyExists> Create(Product product);

    OneOf<Product, ProductNotFound, ProductError> Update(Guid id, Product product);
}