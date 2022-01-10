using asp.net_core_empty_task.Data;
using asp.net_core_empty_task.Models;
using asp.net_core_empty_task.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace asp.net_core_empty_task.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<User> _signInManager;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }

            var user = await _userManager.FindByEmailAsync(model.Email);

            if (user == null)
            {
                ModelState.AddModelError("", "Invalid Credentials");
                return View();
            }

            if (user.isBlocked)
            {
                ModelState.AddModelError("", "User is blocked!");
                return View();
            }

            var signinResult = await _signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, true);

            if (!signinResult.Succeeded)
            {
                ModelState.AddModelError("", "Invalid Credentials");
                return View();

            }

            return RedirectToAction("Index", "Home");
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
            await _userManager.AddToRoleAsync(user, RoleConstants.User);

            if (!identityResult.Succeeded)
            {
                foreach(var item in identityResult.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
                return View();
            }

            await _signInManager.SignInAsync(user, true);

            return RedirectToAction(nameof(HomeController.Index), "Home");
        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
