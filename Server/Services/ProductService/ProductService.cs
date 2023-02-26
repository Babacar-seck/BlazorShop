using BlazorAppShop.Server.Services.CategoryService;
using BlazorAppShop.Shared;
using System.Threading.Tasks;

namespace BlazorAppShop.Server.Services.ProductService
{
    public class ProductService : IProductService
    {

        private readonly ICategoryService _categoryService;
        public List<Product> Products { get; set; } = new List<Product>
        {
                new Product
                {
                    Id = 1,
                    Title = "Mémoires d'outre-tombe",
                    Description = "Autobiographie de François-René de Chateaubriand",
                    Image = "https://upload.wikimedia.org/wikipedia/commons/c/cf/Anne-Louis_Girodet-Trioson_006.jpg",
                    Price = 22.99M,
                    OriginalPrice = 28.99M,
                    IsPublic = true,
                    IsDeleted = false,
                    //Category = Category.Biography,
                    CategoryId = 1,
                    DateCreated = new DateTime(1848, 1, 1),
                    DateUpdated = DateTime.Now
                },
                new Product
                {
                    Id = 2,
                    Title = "Une vie",
                    Description = "Roman de Guy de Maupassant",
                    Image = "https://imgs.search.brave.com/3RCOU56sJ1MeZcRT6MT7kt7DbtH9I19QS8TiwdBGcnw/rs:fit:560:320:1/g:ce/aHR0cHM6Ly91cGxv/YWQud2lraW1lZGlh/Lm9yZy93aWtpcGVk/aWEvY29tbW9ucy90/aHVtYi82LzZjL1Vu/ZVZpZTEuanBnLzUx/MnB4LVVuZVZpZTEu/anBn",
                    Price = 15.99M,
                    OriginalPrice = 19.99M,
                    IsPublic = true,
                    IsDeleted = false,
                    //Category = Category.Fiction,
                    CategoryId = 2,
                    DateCreated = new DateTime(1883, 1, 1),
                    DateUpdated = DateTime.Now
                },
                new Product
                {
                    Id = 3,
                    Title = "Le Journal d'Anne Frank",
                    Description = "Journal intime d'Anne Frank",
                    Image = "https://static.fnac-static.com/multimedia/Images/FR/NR/c2/7f/4e/5144514/1540-1/tsp20220713064934/Le-Journal-d-Anne-Frank-Nouvelle-edition.jpg",
                    Price = 10.99M,
                    OriginalPrice = 12.99M,
                    IsPublic = true,
                    IsDeleted = false,
                    //Category = Category.Biography,
                    CategoryId = 3,
                    DateCreated = new DateTime(1947, 1, 1),
                    DateUpdated = DateTime.Now
                },
                new Product
                {
                    Id = 4,
                    Title = "Les Mémoires de Saint-Simon",
                    Description = "Mémoires de Louis de Rouvroy, duc de Saint-Simon",
                    Image = "https://upload.wikimedia.org/wikipedia/commons/c/ca/Saint-Simon_portrait_officiel_1728_d%C3%A9tail.png",
                    Price = 25.99M,
                    OriginalPrice = 32.99M,
                    IsPublic = true,
                    IsDeleted = false,
                    //Category = Category.Biography,
                    CategoryId = 4,
                    DateCreated = new DateTime(1739, 1, 1),
                    DateUpdated = DateTime.Now
                },
                new Product
                {
                    Id = 5,
                    Title = "Les Confessions",
                    Description = "Autobiographie de Jean-Jacques Rousseau",
                    Image = "https://upload.wikimedia.org/wikipedia/commons/b/b7/Jean-Jacques_Rousseau_%28painted_portrait%29.jpg",
                    Price = 14.99M,
                    OriginalPrice = 19.99M,
                    IsPublic = true,
                    IsDeleted = false,
                    //Category = Category.Biography,
                    CategoryId = 1,
                    DateCreated = new DateTime(1782, 1, 1),
                    DateUpdated = DateTime.Now
                },
                new Product
                {
                    Id = 6,
                    Title = "Les Confessions de Saint-Augustin",
                    Description = "Autobiographie de Saint-Augustin",
                    Image = "https://via.placeholder.com/300x300",
                    Price = 16.99M,
                    OriginalPrice = 21.99M,
                    IsPublic = true,
                    IsDeleted = false,
                    //Category = Category.Biography,
                    CategoryId = 5,
                    DateCreated = new DateTime(397, 1, 1),
                    DateUpdated = DateTime.Now
                },
                new Product
                {
                    Id = 7,
                    Title = "Les Pensées",
                    Description = "Essai philosophique de Blaise Pascal",
                    Image = "https://via.placeholder.com/300x300",
                    Price = 12.99M,
                    OriginalPrice = 15.99M,
                    IsPublic = true,
                    IsDeleted = false,
                    //Category = Category.Philosophy,
                    CategoryId = 3,
                    DateCreated = new DateTime(1670, 1, 1),
                    DateUpdated = DateTime.Now
                }

        };

        public ProductService(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public Task<List<Product>> GetAllProducts()
        {
            return Task.FromResult(Products);
        }

        public Task<List<Product>> GetProductsByCategory(string categoryUrl)
        {
            var category = _categoryService.GetCategoryByUrl(categoryUrl);

            return Task.FromResult(Products.Where(p => p.CategoryId == category.Result.Id).ToList());
        }

        public Task<Product?> GetProductById(int id)
        {
            return Task.FromResult(Products.FirstOrDefault(p => p.Id == id));
        }

        public Task<Product?> GetProductByName(string name)
        {
            return Task.FromResult(Products.FirstOrDefault(p => p.Title.ToLower().Equals(name.ToLower())));
        }
    }
}
