using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorNTCShop.Shared;

namespace BlazorNTCShop.Client.Services.CategoryService
{
    interface ICategoryService
    {
        List<Category> Categories { get; set; }

        Task LoadCategories();
    }
}
