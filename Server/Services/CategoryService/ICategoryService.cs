using BlazorAppShop.Shared;

namespace BlazorAppShop.Server.Services.CategoryService
{
    public interface ICategoryService
    {
        Task <List<Category>> GetCategoriesAsync();

        Task <Category?> GetCategoryByUrl(string categoryUrl);
    }
}
