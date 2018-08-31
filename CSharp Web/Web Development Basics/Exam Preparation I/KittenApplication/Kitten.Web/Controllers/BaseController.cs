namespace KittenApp.Web.Controllers
{
    using SimpleMvc.Framework.Controllers;

    public abstract class BaseController : Controller
    {
        public override void OnAuthentication()
        {
            this.Model.Data["topMenu"] = this.User.IsAuthenticated ?
                @"<li class=""nav-item active"">
	                <a class=""nav-link"" href=""/"">Home</a>
                </li>
                <li class=""nav-item active"">
	                <a class=""nav-link"" href=""/kittens/all"">All Kittens</a>
                </li>
                <li class=""nav-item active"">
	                <a class=""nav-link"" href=""/kittens/add"">Add Kitten</a>
                </li>
                <li class=""nav-item active"">
	                <a class=""nav-link"" href=""/account/logout"">Logout</a>
                </li>" :
                @"<li class=""nav-item active"">
	                <a class=""nav-link"" href=""/"">Home</a>
                </li>
                <li class=""nav-item active"">
	                <a class=""nav-link"" href=""/account/login"">Login</a>
                </li>
                <li class=""nav-item active"">
	                <a class=""nav-link"" href=""/account/register"">Register</a>
                </li>";

            base.OnAuthentication();
        }

    }
}
