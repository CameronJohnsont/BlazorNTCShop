using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorNTCShop.Server.Services.CategoryService;
using BlazorNTCShop.Shared;

namespace BlazorNTCShop.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        public List<Product> Products { get; set; } = new List<Product>
			{
				new Product
				{
					Id = 1,
					CategoryId = 1,
					Title = "Neighborhood Tennis Club",
					Description = "this album is fye af",
					Image = "/css/ntc-pics/Album_Cover.png",
					Price = 9.99m,
					OriginalPrice = 19.99m,
				},
				new Product
				{
					Id = 2,
					CategoryId = 2,
					Title = "Blossom Sweatshirt",
					Description = "this shirt is fye af",
					Image = "/css/ntc-pics/blossomback.png",
					Price = 29.99m,
					OriginalPrice = 39.99m,
				},
				new Product
				{
					Id = 3,
					CategoryId = 1,
					Title = "Rocketman",
					Description = "this album is fye af",
					Image = "/css/ntc-pics/ASTROBOYS_jp.png",
					Price = 9.99m,
					OriginalPrice = 19.99m,
				},
				new Product
				{
					Id = 4,
					CategoryId = 2,
					Title = "Chambray Sweatshirt",
					Description = "this shirt is fye af",
					Image = "/css/ntc-pics/chambrayback.png",
					Price = 29.99m,
					OriginalPrice = 39.99m,
				},
				new Product
				{
					Id = 5,
					CategoryId = 2,
					Title = "RIP $trap Tee",
					Description = "RIP to him. This shirt is fye tho",
					Image = "/css/ntc-pics/lil-strap-tee.png",
					Price = 24.99m,
					OriginalPrice = 29.99m,
				},
				new Product
				{
					Id = 6,
					CategoryId = 3,
					Title = "Falling Rocketman",
					Description = "a NTC original NFT",
					Image = "/css/ntc-pics/COVER-ART.png",
					Price = 4.99m,
					OriginalPrice = 9.99m,
				},

				new Product
				{
					Id = 7,
					CategoryId = 3,
					Title = "ServAce",
					Description = "a NTC original NFT",
					Image = "/css/ntc-pics/NASCAR-ServAce.png",
					Price = 4.99m,
					OriginalPrice = 9.99m,
				},
				new Product
				{
					Id = 8,
					CategoryId = 3,
					Title = "SUNRISEXSUNSET",
					Description = "a NTC original NFT",
					Image = "/css/ntc-pics/SUNRISExSUNSET_b.png",
					Price = 4.99m,
					OriginalPrice = 9.99m,
				},
				new Product
				{
					Id = 9,
					CategoryId = 3,
					Title = "The Fall",
					Description = "a NTC original NFT",
					Image = "/css/ntc-pics/SUNRISExSUNSET.png",
					Price = 4.99m,
					OriginalPrice = 9.99m,
				},
				new Product
				{
					Id = 10,
					CategoryId = 3,
					Title = "The Fall Star Wars Collab",
					Description = "a NTC original NFT",
					Image = "/css/ntc-pics/THEFALL.png",
					Price = 4.99m,
					OriginalPrice = 9.99m,
				},
				new Product
				{
					Id = 11,
					CategoryId = 3,
					Title = "SCARS",
					Description = "a NTC original NFT",
					Image = "/css/ntc-pics/SUNRISExSUNSET_cc.png",
					Price = 4.99m,
					OriginalPrice = 9.99m,
				},
				new Product
				{
					Id = 12,
					CategoryId = 3,
					Title = "Vertigo",
					Description = "a NTC original NFT",
					Image = "/css/ntc-pics/VERTIGO.png",
					Price = 4.99m,
					OriginalPrice = 9.99m,
				},
				new Product
				{
					Id = 13,
					CategoryId = 1,
					Title = "Blur",
					Description = "The Beginning",
					Image = "/css/ntc-pics/NTC-real.png",
					Price = 4.99m,
					OriginalPrice = 9.99m,
				},
				new Product
				{
					Id = 14,
					CategoryId = 1,
					Title = "December Summer",
					Description = "this song is fye af",
					Image = "/css/ntc-pics/Screen_Shot_2018-12-06_at_6113.png",
					Price = 4.99m,
					OriginalPrice = 9.99m,
				},
				new Product
				{
					Id = 15,
					CategoryId = 3,
					Title = "Pioneers",
					Description = "a NTC original NFT",
					Image = "/css/ntc-pics/pioneers.jpg",
					Price = 9.99m,
					OriginalPrice = 9.99m,
				},
				new Product
				{
					Id = 16,
					CategoryId = 3,
					Title = "JUMPMAN",
					Description = "a NTC original NFT",
					Image = "/css/ntc-pics/jumpman.jpg",
					Price = 9.99m,
					OriginalPrice = 9.99m,
				},
				new Product
				{
					Id = 17,
					CategoryId = 3,
					Title = "Game",
					Description = "a NTC original NFT",
					Image = "/css/ntc-pics/game.jpg",
					Price = 9.99m,
					OriginalPrice = 9.99m,
				},
				new Product
				{
					Id = 18,
					CategoryId = 3,
					Title = "Official Ball",
					Description = "a NTC original NFT",
					Image = "/css/ntc-pics/NTC_tennis_ball.png",
					Price = 4.99m,
					OriginalPrice = 9.99m,
				},
				new Product
				{
					Id = 19,
					CategoryId = 1,
					Title = "Velcro Icon",
					Description = "this album is trash",
					Image = "/css/ntc-pics/boroboyz.jpg",
					Price = 0.00m,
					OriginalPrice = 9.99m,
				},
				new Product
				{
					Id = 20,
					CategoryId = 1,
					Title = "Strapped Up",
					Description = "this song is mid",
					Image = "/css/ntc-pics/lil-strap.jfif",
					Price = 0.00m,
					OriginalPrice = 9.99m,
				},
			};

		private readonly ICategoryService _categoryService;
        public ProductService(ICategoryService categoryService)
        {
			_categoryService = categoryService;

        }
		public async Task<List<Product>> GetAllProducts()
        {
			return Products;
        }

        public async Task<Product> GetProduct(int id)
        {
			Product product = Products.FirstOrDefault(p => p.Id == id);
			return product;
        }

        public async Task<List<Product>> GetProductsByCategory(string categoryUrl)
        {
			Category category = await _categoryService.GetCategoryByUrl(categoryUrl);
			return Products.Where(p => p.CategoryId == category.Id).ToList();
        }
    }
}
