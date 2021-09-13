using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DemoMovies.BL.Services;
using DemoMovies.Commons.Model;

namespace DemoMovies.Api.Controllers
{
    [Route("api")]
    [ApiController]
    [Produces("application/json")]

    public class ProductController : ControllerBase
    {
       
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        /// <summary>
        /// Get available product list
        /// </summary> 
        /// <returns>product list</returns>
        /// <response code="200">Returns product list</response> 
        /// <response code="404">No product found</response>   
        [HttpGet]
        [Route("featuredproducts")]
        [ProducesResponseType(200, Type = typeof(List<ProductModel>))]
        [ProducesResponseType(404, Type = typeof(List<ApiError>))]
        public async Task<IActionResult> GetAvailableProducts()
        {

            try
            {
                var products = await _productService.GetProductsAsync();

                if (products == null)
                {
                    var error = new ApiError { Message = "No product found" };
                    return StatusCode(404, error);
                }
                return StatusCode(200, products);


            }
            catch (Exception ex)
            {
                var error = new ApiError { Message = ex.Message };

                return StatusCode(500, error);
            }

        }

        /// <summary>
        /// Get available product list by category
        /// </summary> 
        /// <returns>product list</returns>
        /// <response code="200">Returns product list by category id</response> 
        /// <response code="404">No product found</response>   
        [HttpGet]
        [Route("products/{categoryId}")]
        [ProducesResponseType(200, Type = typeof(List<ProductModel>))]
        [ProducesResponseType(404, Type = typeof(List<ApiError>))]
        public async Task<IActionResult> GetProductByCategory(int CategoryId)
        {

            try
            {
                var products = await _productService.GetProductsByCategory(CategoryId);
                if (products == null)
                {
                    var error = new ApiError { Message = "No product found" };
                    return StatusCode(404, error);
                }
                return StatusCode(200, products);


            }
            catch (Exception ex)
            {
                var error = new ApiError { Message = ex.Message };

                return StatusCode(500, error);
            }

        }

    }
}
