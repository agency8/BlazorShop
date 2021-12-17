using BlazorShop.Shared.Models;
using System.Collections.Generic;

namespace BlazorShop.Client.Services.ProductService
{
    public interface IProductService
    {
        List<Product> Products { get; set; }
        void LoadProducts();
    }
}
