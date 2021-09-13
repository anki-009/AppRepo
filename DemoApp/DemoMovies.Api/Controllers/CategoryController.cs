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
    [ApiController]
    [Route("api")]
    [Produces("application/json")]
    public class CategoryController : ControllerBase
    {

        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        /// <summary>
        /// Get available category list
        /// </summary> 
        /// <returns>category list</returns>
        /// <response code="200">Returns category list</response> 
        /// <response code="404">No category found</response>   
        [HttpGet]
        [Route("categories")]
        [ProducesResponseType(200, Type = typeof(List<CategoryModel>))]
        [ProducesResponseType(404, Type = typeof(List<ApiError>))]
        public async Task<IActionResult> GetCategories()
        {

            try
            {
                var categories = await _categoryService.GetCategoriesAsync();

                if (categories == null)
                {
                    var error = new ApiError { Message = "No category found" };
                    return StatusCode(404, error);
                }
                return StatusCode(200, categories);
            }
            catch (Exception ex)
            {
                var error = new ApiError { Message = ex.Message };

                return StatusCode(500, error);
            }

        }
    }
}
