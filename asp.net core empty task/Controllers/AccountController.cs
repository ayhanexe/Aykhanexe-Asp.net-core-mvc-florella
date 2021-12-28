using asp.net_core_empty_task.Models;
using asp.net_core_empty_task.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace asp.net_core_empty_task.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;

        public AccountController(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Login()
        {
            return View();
        }
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }

            var dbUser = await _userManager.FindByNameAsync(model.Username);

            if(dbUser != null)
            {
                ModelState.AddModelError(
                    nameof(RegisterViewModel.Username),
                    "The user with this username is already exists!"
                );

                return View();
            }

            User user = new User
            {
                FullName = model.FullName,
                UserName = model.Username,
                Email = model.Email
            };

            var identityResult = await _userManager.CreateAsync(user, model.Password);

            if(!identityResult.Succeeded)
            {
                foreach(var item in identityResult.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
                return View();
            }

            return RedirectToAction(nameof(HomeController.Index), "Home");
        }
    }
}
