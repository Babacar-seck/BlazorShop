using BlazorAppShop.Shared;

namespace BlazorAppShop.Server.Services.ProductService
{
    public interface IProductService
    {
        Task<List<Product>> GetAllProducts();
        Task<List<Product>> GetProductsByCategory(string categoryUrl);

        Task<Product> GetProductById(int id);

        Task<Product> GetProductByName(string name);
    }
}
