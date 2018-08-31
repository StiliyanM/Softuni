namespace MeTube.Web.ViewModels
{
    using System.Collections.Generic;

    public class ProfileViewModel
    {
        public string Username { get; set; }

        public string Email { get; set; }

        public List<ProfileTubeViewModel> Tubes { get; set; } = new List<ProfileTubeViewModel>();
    }

    public class ProfileTubeViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }
    }
}
