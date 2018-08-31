namespace MeTube.Web.Controllers
{
    using SimpleMvc.Framework.Controllers;
    using Data;
    using SimpleMvc.Framework.Interfaces;

    public abstract class BaseController : Controller
    {
        protected MeTubeDbContext Db { get; set; }

        protected BaseController()
        {
            this.Db = new MeTubeDbContext();
        }

        protected IActionResult RedirectToHome() => this.RedirectToAction("/home/index");

        public override void OnAuthentication()
        {
            this.Model.Data["topMenu"] = this.User.IsAuthenticated ?
                @"<li class=""nav-item active col-md-3"">
	                <a class=""nav-link"" href=""/"">Home</a>
                </li>
                <li class=""nav-item active col-md-3"">
	                <a class=""nav-link"" href=""/users/profile"">Profile</a>
                </li>
                <li class=""nav-item active col-md-3"">
	                <a class=""nav-link"" href=""/tubes/upload"">Upload</a>
                </li>
                <li class=""nav-item active col-md-3"">
	                <a class=""nav-link"" href=""/users/logout"">Logout</a>
                </li>" :
                @"<li class=""nav-item active col-md-4"">
	                <a class=""nav-link"" href=""/"">Home</a>
                </li>
                <li class=""nav-item active col-md-4"">
	                <a class=""nav-link"" href=""/users/login"">Login</a>
                </li>
                <li class=""nav-item active col-md-4"">
	                <a class=""nav-link"" href=""/users/register"">Register</a>
                </li>";

            base.OnAuthentication();
        }
    }
}
