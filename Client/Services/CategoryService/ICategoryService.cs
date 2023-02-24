using BlazorAppShop.Shared;

namespace BlazorAppShop.Client.Services.CategoryService
{
    public interface ICategoryService
    {
         List<Category> Categories { get; set; }
        void LoadCategories();

    }
}
