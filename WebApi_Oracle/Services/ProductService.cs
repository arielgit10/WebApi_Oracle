using WebApi_Oracle.AccessData.Repositories;
using WebApi_Oracle.Models;

namespace WebApi_Oracle.Services
{
    public class ProductService: IProductService
    {
        private readonly IProductRepository _productinfoRepository;
        public ProductService(IProductRepository productinfoRepository)
        {
            _productinfoRepository = productinfoRepository;
        }
        public async Task<List<Product>> GetAllProducts()
        {
            var result = await _productinfoRepository.GetAllProducts();
            return result;
        }
        public async Task CreateProduct(Product product)
        {
            await _productinfoRepository.CreateProduct(product);
        }
    }
}
