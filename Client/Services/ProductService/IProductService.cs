using BlazorAppShop.Shared;

namespace BlazorAppShop.Client.Services.ProductService
{
    public interface IProductService
    {
        List<Product> Products { get; set; }

        void LoadProducts();
    }
}
