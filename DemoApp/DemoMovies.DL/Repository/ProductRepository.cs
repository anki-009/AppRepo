using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using DemoMovies.Commons.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoMovies.DL.Repository
{
    public class ProductRepository : BaseDbRepository, IProductRepository
    {
        public ProductRepository(AppDBContext context) : base(context) { }

        public async Task<List<ProductModel>> GetProductsByCategoryAsync(int categoryId)
        {
            
            var result = await DemoMoviesDBContext.Products.FromSqlRaw("Sp_GetProductByCategory @CategoryId", new SqlParameter("@CategoryId", categoryId)).ToListAsync();

            var products = result.Select(a => new ProductModel
            {
                
                Discription = a.Description,
                Name = a.Name,
                Price = a.Price,
                ProductId = a.ProductId,
                Sku = a.Sku
            }).ToList();

            return products;
        }

        public async Task<List<ProductModel>> GetProductsAsync()
        {
            var result = await DemoMoviesDBContext.Products.FromSqlRaw("Sp_GetFeaturedProducts").ToListAsync();

            var products = result.Select(a => new ProductModel
            {
                Sku = a.Sku,
                Discription = a.Description,
                Name = a.Name,
                Price = a.Price 
               
            }).ToList();

            return products;
        }
    }
}
