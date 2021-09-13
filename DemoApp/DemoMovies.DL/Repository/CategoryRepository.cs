using Microsoft.EntityFrameworkCore;
using DemoMovies.Commons.Model;
using DemoMovies.DL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMovies.DL.Repository
{
    public class CategoryRepository : BaseDbRepository, ICategoryRepository
    {

        public CategoryRepository(AppDBContext context) : base(context) { }

        public async Task<List<CategoryModel>> GetCategoriesAsync()
        {
            var result = await DemoMoviesDBContext.Categories.FromSqlRaw("Sp_GetCategories").ToListAsync();

            var r = result.Select(a => new CategoryModel
            {
                CategoryId = a.CategoryId,
                CategoryName = a.CategoryName
            }).ToList();
            return r;
        }
    }
}
