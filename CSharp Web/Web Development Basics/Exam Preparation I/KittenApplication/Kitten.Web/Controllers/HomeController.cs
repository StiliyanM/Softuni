namespace KittenApp.Web.Controllers
{
    using SimpleMvc.Framework.Interfaces;

    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            if (this.User.IsAuthenticated)
            {
                this.Model.Data["homeContent"] = this.Model.Data["homeContent"] = $@"        <h1>Welcome, {this.User.Name}</h1>
                                        <p>Fluffy Duffy Munchin Cats wishes you  a cute and awesome experience.</p>";

            }
            else
            {
                this.Model.Data["homeContent"] = $@"        <h1>Welcome to Fluffy Duffy Munchkin Cats</h1>
                                        <p>The simplest, cutest, most reliable website for trading cats.</p>
                                        <hr class=""my-2"">
                                        <p><a href=""/login"">Login</a> to trade or <a href=""/register"">Register</a> if you don't have an account.</p>";
            }

            return View();
        }
    }
}
