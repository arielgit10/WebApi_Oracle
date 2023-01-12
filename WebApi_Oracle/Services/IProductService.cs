using WebApi_Oracle.Models;

namespace WebApi_Oracle.Services
{
    public interface IProductService
    {
        Task<List<Product>> GetAllProducts();
        Task CreateProduct(Product product);
    }
}
