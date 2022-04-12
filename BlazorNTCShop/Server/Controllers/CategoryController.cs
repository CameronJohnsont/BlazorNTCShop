using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorNTCShop.Server.Services.CategoryService;
using BlazorNTCShop.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorNTCShop.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Category>>> GetCategories()
        {
            return Ok(await _categoryService.GetCategories());

        }
    }
}
