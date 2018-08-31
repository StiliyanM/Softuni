namespace GameStore.Application.Services.Contracts
{
    using System;
    using System.Collections.Generic;
    using ViewModels.Admin;
    using ViewModels.Home;
    using ViewModels.Games;
    using ViewModels.Shopping;
    public interface IGameService
    {
        void Create(
            string title,
            string description,
            string image,
            decimal price,
            double size,
            string videoId,
            DateTime releaseDate);

        IEnumerable<AdminListGameViewModel> All();

        IEnumerable<GameInCartViewModel> All(IEnumerable<int> ids);

        AdminGameViewModel Find(int id);

        void Edit(int id, AdminGameViewModel model);

        GameDetailsViewModel Details(int id);

        IList<HomeGameListViewModel> AllGames();

        IList<HomeGameListViewModel> Owned(string email);

        void Delete(int id);
    }
}
