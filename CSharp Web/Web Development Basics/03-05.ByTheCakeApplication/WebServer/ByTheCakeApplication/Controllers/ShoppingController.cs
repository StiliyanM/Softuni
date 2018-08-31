namespace WebServer.ByTheCakeApplication.Controllers
{
    using Infrastructure;
    using Server.Http.Contracts;
    using Server.Http.Response;
    using System.Linq;
    using ViewModels;
    using ViewModels.Shopping;
    using Services;
    using Server.Http;
    using System;

    public class ShoppingController : Controller
    {
        private readonly IProductService products;
        private readonly IUserService users;
        private readonly IShoppingService shopping;

        public ShoppingController()
        {
            this.products = new ProductService();
            this.users = new UserService();
            this.shopping = new ShoppingService();
        }

        public IHttpResponse AddToCart(IHttpRequest req)
        {
            var id = int.Parse(req.UrlParameters["id"]);

            bool productExists = this.products.Exists(id);

            if (!productExists)
            {
                return new NotFoundResponse();
            }

            var shoppingCart = req.Session.Get<ShoppingCart>(ShoppingCart.SessionKey);
            shoppingCart.ProductIds.Add(id);

            var redirectUrl = "/search";

            const string searchTermKey = "searchTerm";

            if (req.UrlParameters.ContainsKey(searchTermKey))
            {
                redirectUrl = $"{redirectUrl}?{searchTermKey}={req.UrlParameters[searchTermKey]}";
            }

            return new RedirectResponse(redirectUrl);
        }

        public IHttpResponse ShowCart(IHttpRequest req)
        {
            var shoppingCart = req.Session.Get<ShoppingCart>(ShoppingCart.SessionKey);

            if (!shoppingCart.ProductIds.Any())
            {
                this.ViewData["cartItems"] = "No items in your cart";
                this.ViewData["totalCost"] = "0.00";
            }
            else
            {
                var items = products
                    .ProductsInCart(shoppingCart.ProductIds)
                    .ToList();

                var totalPrice = items
                    .Sum(i => i.Price);
                
                this.ViewData["cartItems"] = string.Join(string.Empty, 
                        items.Select(i => $"<div>{i.Name} - ${i.Price:F2}</div><br />"));
                this.ViewData["totalCost"] = $"{totalPrice:F2}";
            }

            return this.FileViewResponse(@"shopping\cart");
        }

        public IHttpResponse Orders(IHttpRequest req)
        {
            var username = req.Session.Get<string>(SessionStore.CurrentUserKey);

            var userId = users.GetUserId(username);

            if(userId == null)
            {
                return new NotFoundResponse();
            }

            var orders = shopping.OrdersByUser((int)userId)
                            .Select(o => $"<tr><td><a href=\"/orderDetails/{o.Id}\">{o.Id}</a></td><td>{o.CreatedOn}</td><td>${o.Sum:f2}</td></tr>");

            var results = string.Join(Environment.NewLine, orders);

            this.ViewData["orders"] = results;
            return this.FileViewResponse("shopping/orders");
        }

        public IHttpResponse OrderDetails(int id)
        {
            var order = shopping.GetOrderDetails(id);

            if(order == null)
            {
                return new NotFoundResponse();
            }

            var createdOn = order.CreatedOn.ToShortDateString();

            var products = order.Products
                .Select(p => $"<tr><td><a href=\"/productDetails/{p.Id}\">{p.Name}</a></td><td>${p.Price:f2}</td></tr>");

            this.ViewData["id"] = id.ToString();
            this.ViewData["createdOn"] = createdOn;
            this.ViewData["products"] = string.Join(Environment.NewLine, products);

            return this.FileViewResponse("/shopping/orderDetails");
        }

        public IHttpResponse FinishOrder(IHttpRequest req)
        {
            var shoppingCart = req.Session.Get<ShoppingCart>(ShoppingCart.SessionKey);

            var username = req.Session.Get<string>(SessionStore.CurrentUserKey);

            int? userId = this.users.GetUserId(username);
            var productIds = shoppingCart.ProductIds;

            if(userId == null)
            {
                throw new InvalidOperationException($"User {username} does not exist!");
            }

            shopping.CreateOrder((int)userId, productIds);

            shoppingCart.ProductIds.Clear();

            return this.FileViewResponse(@"shopping\finish-order");
        }
    }
}
