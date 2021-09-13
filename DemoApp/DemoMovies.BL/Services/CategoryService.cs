using DemoMovies.Commons.Model;
using DemoMovies.DL.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DemoMovies.BL.Services
{
    public class CategoryService : ICategoryService
    {

        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public Task<List<CategoryModel>> GetCategoriesAsync()
        {
            return _categoryRepository.GetCategoriesAsync();
        }
    }
}
