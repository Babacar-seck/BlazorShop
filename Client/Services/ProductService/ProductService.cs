using BlazorAppShop.Shared;
using System.Net.Http.Json;
using static System.Net.WebRequestMethods;

namespace BlazorAppShop.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;

        public event Action OnChange;

        public List<Product> Products { get; set; } = new List<Product>();

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task LoadProducts(string categoryUrl = null)
        {
            if (categoryUrl == null)
            {
                Products = await _httpClient.GetFromJsonAsync<List<Product>>($"api/Product");
            }
            else
            {
                Products = await _httpClient.GetFromJsonAsync<List<Product>>($"api/Product/Category/{categoryUrl}");
            }

            OnChange.Invoke();
        }

        public async Task<Product> GetProduct(int Id)
        {
            return  await _httpClient.GetFromJsonAsync<Product>($"api/Product/{Id}");
        }
    }
}
