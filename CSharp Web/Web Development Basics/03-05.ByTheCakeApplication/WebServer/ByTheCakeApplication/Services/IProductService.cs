namespace WebServer.ByTheCakeApplication.Services
{
    using System.Collections.Generic;
    using ViewModels.Products;

    public interface IProductService
    {
        void Create(string name, decimal price, string PictureUrl);

        IEnumerable<ProductListingViewModel> All(string searchTerm = null);

        IEnumerable<ProductInCartViewModel> ProductsInCart(IEnumerable<int> ids);

        ProductDetailsViewModel Find(int id);

        bool Exists(int id);
    }
}
