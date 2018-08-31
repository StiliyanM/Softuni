namespace GameStore.Application.ViewModels.Games
{
    using System;

    public class GameDetailsViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public decimal Price { get; set; }

        public double Size { get; set; }

        public string Description { get; set; }

        public string VideoId { get; set; }

        public DateTime ReleaseDate { get; set; }
    }
}
