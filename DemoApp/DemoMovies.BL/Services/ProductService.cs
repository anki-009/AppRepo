using DemoMovies.Commons.Model;
using DemoMovies.DL.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DemoMovies.BL.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Task<List<ProductModel>> GetProductsAsync()
        {
            return _productRepository.GetProductsAsync();
        }

        public Task<List<ProductModel>> GetProductsByCategory(int categoryId)
        {
            return _productRepository.GetProductsByCategoryAsync(categoryId);
        }
    }
}
