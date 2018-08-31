namespace GameStore.Application
{
    using Controllers;
    using Data;
    using Microsoft.EntityFrameworkCore;
    using Server.Contracts;
    using Server.Routing.Contracts;
    using System;
    using System.Globalization;
    using ViewModels.Account;
    using ViewModels.Admin;
    using ViewModels.Games;
    public class GameStoreApp : IApplication
    {
        public void InitializeDatabase()
        {
            using (var db = new GameStoreDbContext())
            {
                db.Database.Migrate();
            }
        }

        public void Configure(IAppRouteConfig appRouteConfig)
        {
            appRouteConfig.AnonymousPaths.Add("/");
            appRouteConfig.AnonymousPaths.Add("/account/register");
            appRouteConfig.AnonymousPaths.Add("/account/login");

            appRouteConfig
                .Get("/", req => new HomeController(req).Index());

            appRouteConfig
                .Post("/", req => new HomeController(req).Index());

            appRouteConfig
                .Get(
                    "/account/register",
                    req => new AccountController(req).Register());

            appRouteConfig
                .Post(
                    "/account/register",
                    req => new AccountController(req).Register(
                        new RegisterViewModel
                        {
                            Email = req.FormData["email"],
                            FullName = req.FormData["full-name"],
                            Password = req.FormData["password"],
                            ConfirmPassword = req.FormData["confirm-password"]
                        }));

            appRouteConfig
                .Get(
                    "/account/login",
                    req => new AccountController(req).Login());

            appRouteConfig
                .Post(
                    "/account/login",
                    req => new AccountController(req).Login(
                        new LoginViewModel
                        {
                            Email = req.FormData["email"],
                            Password = req.FormData["password"]
                        }));

            appRouteConfig
                .Get(
                    "/account/logout",
                    req => new AccountController(req).Logout());

            appRouteConfig
                .Get(
                    "/admin/games/add",
                    req => new AdminController(req).Add());

            appRouteConfig
                .Post(
                    "/admin/games/add",
                    req => new AdminController(req).Add(
                        new AdminGameViewModel
                        {
                            Title = req.FormData["title"],
                            Description = req.FormData["description"],
                            Image = req.FormData["thumbnail"],
                            Price = decimal.Parse(req.FormData["price"]),
                            Size = double.Parse(req.FormData["size"]),
                            VideoId = req.FormData["video-id"],
                            ReleaseDate = DateTime.ParseExact(
                                req.FormData["release-date"],
                                "yyyy-MM-dd",
                                CultureInfo.InvariantCulture)
                        }));

            appRouteConfig.Get(
                    "/admin/games/edit/{(?<id>[0-9]+)}",
                    req => new AdminController(req).Edit());


            appRouteConfig
                .Post(
                    "/admin/games/edit/{(?<id>[0-9]+)}",
                    req => new AdminController(req).Edit(
                        new AdminGameViewModel
                        {
                            Title = req.FormData["title"],
                            Description = req.FormData["description"],
                            Image = req.FormData["thumbnail"],
                            Price = decimal.Parse(req.FormData["price"]),
                            Size = double.Parse(req.FormData["size"]),
                            VideoId = req.FormData["videoId"],
                            ReleaseDate = DateTime.ParseExact(
                                req.FormData["release-date"],
                                "yyyy-MM-dd",
                                CultureInfo.InvariantCulture)
            }));

            appRouteConfig.Get(
                        "/admin/games/delete/{(?<id>[0-9]+)}",
                        req => new AdminController(req).Delete());

            appRouteConfig.Post(
                        "/admin/games/delete/{(?<id>[0-9]+)}",
                        req => new AdminController(req).DeletePost());

            appRouteConfig
                .Get(
                    "/admin/games/list",
                    req => new AdminController(req).List());

            appRouteConfig
                .Get(
                    "games/{(?<id>[0-9]+)}",
                req => new GamesController(req).Details());

            appRouteConfig
                .Get(
                    "/shopping/add/{(?<id>[0-9]+)}",
                    req => new HomeController(req).AddToCart());

            appRouteConfig
                .Get(
                    "/shopping/cart",
                    req => new ShoppingController(req).Cart());

            appRouteConfig
                .Post(
                    "/shopping/cart",
                    req => new ShoppingController(req).Order());

            appRouteConfig
                .Get("/shopping/remove/{(?<id>[0-9]+)}",
                req => new ShoppingController(req).RemoveFromCart());

        }
    }
}
