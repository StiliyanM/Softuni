namespace Library.Services.Models.Directors
{
    using System.Collections.Generic;

    public class DirectorDetailsViewModel
    {
        public string Name { get; set; }

        public List<MovieByDirectorModel> Movies { get; set; } = new List<MovieByDirectorModel>();
    }

    public class MovieByDirectorModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Status { get; set; }
    }

}
