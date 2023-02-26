using BlazorAppShop.Shared;

namespace BlazorAppShop.Server.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {

        public List<Category> Categories { get; set; } = new List<Category>
        {
                new Category { Id = 1, Name = "Biography", Icon = "biography", Url="biography"},
                new Category { Id = 2, Name = "Science-Fiction", Icon = "science-fiction", Url="science-fiction"},
                new Category { Id = 3, Name = "Philosophy", Icon = "philosophy", Url="philosophy"},
                new Category { Id = 4, Name = "Romance", Icon = "romance", Url="romance"},
                new Category { Id = 5, Name = "Religion", Icon = "religion", Url="religion"},
                new Category { Id = 6, Name = "Litterature", Icon = "litterature", Url="litterature"}
        };
        public Task<List<Category>> GetCategoriesAsync()
        {
            return Task.FromResult(Categories);
        }

        public Task<Category> GetCategoryByUrl(string categoryUrl)
        {
            return Task.FromResult(Categories.FirstOrDefault(c => c.Url.ToLower().Equals(categoryUrl.ToLower())));
        }
    }
}
