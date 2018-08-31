namespace SimpleMvc.App.Controllers
{
    using Framework.Controllers;
    using Framework.Contracts;
    using Framework.Attributes.Methods;
    using Services;
    using Services.Contracts;
    using BindingModels;
    using ViewModels;
    using System.Linq;
    using System;

    public class UsersController : Controller
    {
        private readonly IUserService userService;
        private readonly INoteService noteService;
        public UsersController()
        {
            this.userService = new UserService();
            this.noteService = new NoteService();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(UserBindingModel model)
        {
            if (!this.IsValidModel(model))
            {
                return View();
            }

            userService.Create(model.Username, model.Password);

            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(UserBindingModel model)
        {
           var exists = userService.Exists(model.Username, model.Password);

            if (!exists)
            {
                return this.RedirectToAction("/users/login");
            }

            this.SignIn(model.Username);

            return RedirectToAction("/home/index");
        }

        [HttpPost]
        public IActionResult Logout()
        {
            this.SignOut();

            return RedirectToAction("/home/index");
        }

        public IActionResult All()
        {
            var all = userService.All()
                .Select(u => new AllUsersViewModel
                {
                    Id = u.Id,
                    Username = u.Username
                    
                });

            var results = all.Select(u => $@"<li><a href=""/users/profile?id={u.Id}"">{u.Username}</a></li>");

            this.Model["users"] = string.Join(Environment.NewLine, results);

            return View();
        }

        public IActionResult Profile(int id)
        {
            var user = this.userService.ById(id);

            if(user == null)
            {
                return RedirectToAction("/");
            }

            var profile = new UserProfileViewModel
            {
                UserId = user.Id,
                Username = user.Username,
                Notes = userService.GetNotes(user.Id)
                        .Select(n => new NoteViewModel
                        {
                            Title = n.Title,
                            Content = n.Content
                        })
            };

            this.Model["userId"] = profile.UserId.ToString();
            this.Model["username"] = profile.Username;
            this.Model["notes"] = string.Join(
                Environment.NewLine,
                profile.Notes
                .Select(n => $@"<li><strong>{n.Title}</strong> - {n.Content}</li>"));

            return View();
        }

        [HttpPost]
        public IActionResult Profile(AddNoteBindingModel model)
        {
            noteService.Create(model.Title, model.Content, model.UserId);

            return this.Profile(model.UserId);
        }
    }
}
