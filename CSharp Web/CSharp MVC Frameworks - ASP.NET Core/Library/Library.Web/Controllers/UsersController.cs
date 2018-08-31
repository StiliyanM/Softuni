namespace Library.Web.Controllers
{
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Models.BindingModels;
    using Services.Contracts;

    public class UsersController : Controller
    {
        private readonly IUserService users;

        public UsersController(IUserService users)
        {
            this.users = users;
        }
        private const string UserSessionKey = "__User__";

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(UserLoginBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (this.users.Exists(model.Username, model.Password))
            {
                this.ModelState.AddModelError("username", "User already exists!");
                return View(model);
            }

            this.HttpContext.Session.SetString(UserSessionKey, model.Username);
            return RedirectToPage("/Index");
        }

        public IActionResult Logout()
        {
            this.HttpContext.Session.Remove(UserSessionKey);

            return RedirectToPage("/Index");
        }
    }
}
