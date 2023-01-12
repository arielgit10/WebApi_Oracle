using Microsoft.EntityFrameworkCore;
using WebApi_Oracle.AccessData.Persistence;
using WebApi_Oracle.Models;

namespace WebApi_Oracle.AccessData.Repositories
{
    public class ProductRepository: IProductRepository
    {
        private readonly AppDbContext _context;

        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<Product>> GetAllProducts()
        {
            var result = await _context.Products.ToListAsync();
            return result;
        }
        public async Task CreateProduct(Product product)
        {
            var result = await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
        }
    }
}
