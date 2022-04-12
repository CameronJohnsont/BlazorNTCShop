using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorNTCShop.Shared;

namespace BlazorNTCShop.Server.Services.CategoryService
{
    public interface ICategoryService
    {
        Task<List<Category>> GetCategories();

        Task<Category> GetCategoryByUrl(string categoryUrl);
    }
}
