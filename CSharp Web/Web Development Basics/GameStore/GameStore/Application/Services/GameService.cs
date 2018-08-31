namespace GameStore.Application.Services
{
    using Contracts;
    using System;
    using Data;
    using Data.Models;
    using System.Collections.Generic;
    using System.Linq;
    using ViewModels.Admin;
    using ViewModels.Home;
    using ViewModels.Games;
    using System.Globalization;
    using ViewModels.Shopping;

    public class GameService : IGameService
    {
        public void Create(
            string title,
            string description,
            string image,
            decimal price,
            double size,
            string videoId,
            DateTime releaseDate)
        {
            using (var db = new GameStoreDbContext())
            {
                var game = new Game
                {
                    Title = title,
                    Description = description,
                    Image = image,
                    Price = price,
                    Size = size,
                    VideoId = videoId,
                    ReleaseDate = releaseDate
                };

                db.Add(game);
                db.SaveChanges();
            }
        }

        public IEnumerable<AdminListGameViewModel> All()
        {
            using (var db = new GameStoreDbContext())
            {
                return db
                    .Games
                    .Select(g => new AdminListGameViewModel
                    {
                        Id = g.Id,
                        Name = g.Title,
                        Price = g.Price,
                        Size = g.Size
                    })
                    .ToList();
            }
        }

        public IEnumerable<GameInCartViewModel> All(IEnumerable<int> ids)
        {
            using (var db = new GameStoreDbContext())
            {
                return db.Games
                        .Where(g => ids.Contains(g.Id))
                        .Select(g => new GameInCartViewModel
                        {
                            Id = g.Id,
                            Image = g.Image,
                            Description = g.Description,
                            Price = g.Price,
                            Title = g.Title
                        }).ToList();
            }
        }


        public IList<HomeGameListViewModel> AllGames()
        {
            using (var db = new GameStoreDbContext())
            {
                return db
                    .Games
                    .Select(g => new HomeGameListViewModel
                    {
                        Id = g.Id,
                        Title = g.Title,
                        Price = g.Price,
                        Size = g.Size,
                        Description = g.Description,
                        Image = g.Image,
                        VideoId = g.VideoId
                    })
                    .ToList();
            }

        }

        public IList<HomeGameListViewModel> Owned(string email)
        {
            using (var db = new GameStoreDbContext())
            {
                return db
                .Games
                .Where(g => g.Users.Any(ug => ug.User.Email == email))
                .Select(g => new HomeGameListViewModel
                {
                    Id = g.Id,
                    Title = g.Title,
                    Price = g.Price,
                    Size = g.Size,
                    Description = g.Description,
                    Image = g.Image,
                    VideoId = g.VideoId
                })
                .ToList();
            }
          
    }

    public AdminGameViewModel Find(int id)
        {
            using (var db = new GameStoreDbContext())
            {
                var game = db.Games.FirstOrDefault(g => g.Id == id);

                return new AdminGameViewModel
                {
                    Title = game.Title,
                    Description = game.Description,
                    Image = game.Image,
                    Price = game.Price,
                    Size = game.Size,
                    VideoId = game.VideoId,
                    ReleaseDate = game.ReleaseDate
                };
            }
        }

        public void Edit(int id, AdminGameViewModel model)
        {
            using (var db = new GameStoreDbContext())
            {
                var game = db.Games.FirstOrDefault(g => g.Id == id);

                game.Title = model.Title;
                game.Description = model.Description;
                game.Image = model.Image;
                game.Price = model.Price;
                game.Size = model.Size;
                game.VideoId = model.VideoId;
                game.ReleaseDate = model.ReleaseDate.Value;

                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new GameStoreDbContext())
            {
                var game = db.Games.FirstOrDefault(g => g.Id == id);
                db.Games.Remove(game);

                db.SaveChanges();
            }
        }


        public GameDetailsViewModel Details(int id)
        {
            using (var db = new GameStoreDbContext())
            {
                var game = db.Games.FirstOrDefault(g => g.Id == id);

                return new GameDetailsViewModel
                {
                    Id = game.Id,
                    Title = game.Title,
                    Description = game.Description,
                    Price = game.Price,
                    Size = game.Size,
                    VideoId = game.VideoId,
                    ReleaseDate = game.ReleaseDate
                };
            }
        }

    }
}
