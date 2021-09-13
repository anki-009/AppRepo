using DemoMovies.Commons.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DemoMovies.BL.Services
{
    public interface IProductService
    {
        public Task<List<ProductModel>> GetProductsAsync();
        public Task<List<ProductModel>> GetProductsByCategory(int categoryId);
    }
}
