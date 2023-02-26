using BlazorAppShop.Shared;
using System.Net.Http.Json;

namespace BlazorAppShop.Client.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        public List<Category> Categories { get; set; } = new List<Category>();

        private readonly HttpClient _httpClient;

        public CategoryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task LoadCategories()
        {
            Categories = await _httpClient.GetFromJsonAsync<List<Category>>("api/Category");
        }
    }
}
