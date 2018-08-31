namespace WebServer.ByTheCakeApplication.Controllers
{
    using Infrastructure;
    using ViewModels;
    using ViewModels.Products;
    using Server.Http.Contracts;
    using System;
    using System.Linq;
    using Services;
    using Server.Http.Response;

    public class ProductsController : Controller
    {
        private readonly IProductService products;

        private const string AddView = @"products\add";

        public ProductsController()
        {
            this.products = new ProductService();
        }

        public IHttpResponse Add()
        {
            this.ViewData["showResult"] = "none";

            return this.FileViewResponse(AddView);
        }

        public IHttpResponse Add(AddProductViewModel model)
        {
            if (model.Name.Length < 3 ||
                model.Name.Length > 30 ||
                model.PictureUrl.Length < 3 ||
                model.PictureUrl.Length > 2000)
            {
                this.ViewData["showResult"] = "none";
                this.AddError("Invalid picture details.");

                return this.FileViewResponse(AddView);
            }

            this.ViewData["name"] = model.Name;
            this.ViewData["price"] = model.Price.ToString();
            this.ViewData["image-url"] = model.PictureUrl;
            this.ViewData["showResult"] = "block";

            this.products.Create(model.Name, model.Price, model.PictureUrl);

            return this.FileViewResponse(AddView);
        }

        public IHttpResponse Search(IHttpRequest req)
        {
            const string searchTermKey = "searchTerm";

            var urlParameters = req.UrlParameters;

            this.ViewData["results"] = string.Empty;
            this.ViewData["searchTerm"] = string.Empty;

            var searchTerm = urlParameters.ContainsKey(searchTermKey)
                ? urlParameters[searchTermKey] : null;

            var result = this.products.All(searchTerm);

            if (!result.Any())
            {
                this.ViewData["results"] = "No cakes found";
            }

            else
            {
                var allProducts = result
                    .Select(c => $@"<div><a href=""shopping/productDetails/{c.Id}"">{c.Name}</a> ${c.Price:F2} <a href=""/shopping/add/{c.Id}?searchTerm={searchTerm}"">Order</a></div>")
                    .ToList();

                this.ViewData["results"] = string.Join(Environment.NewLine, allProducts);
            }

            this.ViewData["searchTerm"] = searchTerm;

            this.ViewData["showCart"] = "none";

            var shoppingCart = req.Session.Get<ShoppingCart>(ShoppingCart.SessionKey);

            if (shoppingCart.ProductIds.Any())
            {
                var totalProducts = shoppingCart.ProductIds.Count;
                var totalProductsText = totalProducts != 1 ? "products" : "product";

                this.ViewData["showCart"] = "block";
                this.ViewData["products"] = $"{totalProducts} {totalProductsText}";
            }

            return this.FileViewResponse(@"products\search");
        }

        public IHttpResponse Details(int id)
        {
            var product = products.Find(id);

            if(product == null)
            {
                return new NotFoundResponse();
            }

            this.ViewData["name"] = product.Name;
            this.ViewData["image-url"] = product.ImageUrl;
            this.ViewData["price"] = product.Price.ToString("F2");

            return this.FileViewResponse($"/products/details");
        }
    }
}
