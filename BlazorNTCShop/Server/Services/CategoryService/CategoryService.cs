using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorNTCShop.Shared;

namespace BlazorNTCShop.Server.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        public List<Category> Categories { get; set; } = new List<Category>
            {
                new Category { Id = 1, Name = "Music", Url = "Music", Icon = "headphones"},
                new Category { Id = 2, Name = "Clothing", Url = "Clothing", Icon = "tag"},
                new Category { Id = 3, Name = "NFTs", Url = "NFTs", Icon = "brush"}
            };

        public async Task<List<Category>> GetCategories()
        {
            return Categories;
        }

        public async Task<Category> GetCategoryByUrl(string categoryUrl)
        {
            return Categories.FirstOrDefault(c => c.Url.ToLower().Equals(categoryUrl.ToLower()));
        }
    }
}
