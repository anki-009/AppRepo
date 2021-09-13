using DemoMovies.Commons.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DemoMovies.DL.Repository
{
    public interface ICategoryRepository
    {
        public Task<List<CategoryModel>> GetCategoriesAsync();

    }
}
