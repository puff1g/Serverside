using System.Collections.Generic;
using Store.DomainModels;

namespace Store.Repositories
{
    public interface IProductRepository
    {
        List<Product> GetAllProducts();
        Product GetProduct(long id);
        Product CreateProduct(Product product);
        void UpdateProduct(long id, Product product);
        void DeleteProduct(long id);
    }
}