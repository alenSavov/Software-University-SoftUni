using Eventures.Services.Contracts;
using Eventures.Web.Models.Users;
using Microsoft.AspNetCore.Mvc;

namespace Eventures.Web.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUsersService userService;

        public UsersController(IUsersService userService)
        {
            this.userService = userService;
        }

        public IActionResult Register()
        {
            var model = new RegisterViewModel();
            return this.View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return this.View();
            }

            var result = this.userService.Register(model.Username,
                model.Password,
                model.ConfirmPassword,
                model.Email,
                model.FirstName,
                model.LastName,
                model.Ucn);

            if (!result.Result)
            {
                return this.View();
            }

            return this.RedirectToAction(nameof(Login));
        }

        public IActionResult Login()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return this.View();
            }

            var result = this.userService.Login(model.Username, model.Password);

            if (!result.Result)
            {
                return this.View();
            }

            return this.Redirect("/");
        }

        public IActionResult Logout()
        {
            this.userService.Logout();

            return this.Redirect("/");
        }
    }
       
}
