namespace MeTube.Web.Controllers
{
    using SimpleMvc.Framework.Attributes.Methods;
    using SimpleMvc.Framework.Interfaces;
    using System.Linq;
    using ViewModels;
    using Models;
    using System.Text;
    using SimpleMvc.Framework.Attributes.Security;

    public class UsersController : BaseController
    {
        public IActionResult Register()
        {
            this.Model.Data["error"] = string.Empty;
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterUserViewModel model)
        {
            if (!this.IsValidModel(model))
            {
                this.Model.Data["error"] = this.ParameterValidator.FirstErrorMessage;

                return View();
            }

            var user = new User
            {
                Email = model.Email,
                Password = model.Password,
                Username = model.Username
            };

            Db.Add(user);
            Db.SaveChanges();

            var userId = Db.Users.First(u => u.Username == model.Username).Id;

            this.SignIn(model.Username, userId);

            return this.RedirectToHome();
        }

        public IActionResult Login()
        {
            this.Model.Data["error"] = string.Empty;
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginUserViewModel model)
        {
            if (!this.IsValidModel(model) ||
                !this.Db.Users.Any(u => u.Username == model.Username && u.Password == model.Password))
            {
                this.Model.Data["error"] = "Invalid user details!";
                return View();
            }

            var userId = Db.Users.First(u => u.Username == model.Username).Id;

            this.SignIn(model.Username, userId);

            return this.RedirectToHome();
        }

        [PreAuthorize]
        public IActionResult Logout()
        {
            this.SignOut();

            return this.RedirectToHome();
        }

        [PreAuthorize]
        public IActionResult Profile()
        {
            ProfileViewModel profile = Db.Users
                .Where(u => u.Username == this.User.Name)
                .Select(u => new ProfileViewModel
                {
                    Email = u.Email,
                    Username = u.Username,
                    Tubes = u.Tubes.Select(t => new ProfileTubeViewModel
                    {
                        Id = t.Id,
                        Author = t.Author,
                        Title = t.Title
                    }).ToList()
                }).FirstOrDefault();

            this.Model.Data["username"] = profile.Username;
            this.Model.Data["email"] = profile.Email;

            var result = new StringBuilder();

            var counter = 1;
            foreach (var tube in profile.Tubes)
            {
                result.AppendLine(
                    $@" <tr>
                        <td>{counter}</td>
                        <td>{tube.Title}</td>
                        <td>{tube.Author}</td>
                        <td><a href=""/tubes/details?id={tube.Id}"">Details</a></td>
                        </tr>"
                    );
                counter++;
            }

            this.Model["tubes"] = result.ToString();

            return View();
        }

    }
}
