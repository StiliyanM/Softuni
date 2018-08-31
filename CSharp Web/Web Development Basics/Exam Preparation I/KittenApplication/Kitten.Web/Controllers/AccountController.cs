namespace KittenApp.Web.Controllers
{
    using SimpleMvc.Framework.Interfaces;
    using Models;
    using Services.Contracts;
    using Services;
    using SimpleMvc.Framework.Attributes.Methods;

    public class AccountController : BaseController
    {
        private readonly IUserService userService = new UserService();

        public IActionResult Register() => View();

        [HttpPost]
        public IActionResult Register(RegisterBindingModel model)
        {
            if (!this.IsValidModel(model))
            {
                return View();
            }

            this.userService.Create(model.Username, model.Email, model.Password);

            return RedirectToAction("/home/index");
        }

        public IActionResult Login() => View();

        [HttpPost]
        public IActionResult Login(LoginBindingModel model)
        {
            if (!this.IsValidModel(model))
            {
                return View();
            }

            bool exists = this.userService.Exists(model.Username);

            if (!exists)
            {
                return RedirectToAction("/account/register");
            }

            this.SignIn(model.Username, model.Id);

            return RedirectToAction("/home/index");
        }

        public IActionResult Logout()
        {
            this.SignOut();

            return RedirectToAction("/home/index");
        }
    }
}
