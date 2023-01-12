using WebApi_Oracle.Models;

namespace WebApi_Oracle.AccessData.Repositories
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAllProducts();
        Task CreateProduct(Product product);
    }
}
