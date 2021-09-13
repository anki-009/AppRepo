using DemoMovies.Commons.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DemoMovies.BL.Services
{
    public interface ICategoryService
    {
        Task<List<CategoryModel>> GetCategoriesAsync();

    }
}
