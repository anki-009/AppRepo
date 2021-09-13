using DemoMovies.Commons.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DemoMovies.DL.Repository
{
    public interface IProductRepository
    {
        public Task<List<ProductModel>> GetProductsAsync();
        public Task<List<ProductModel>> GetProductsByCategoryAsync(int categoryId);

    }
}

