using KSPort.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KSPort.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }


        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> SignUp(UserRegisterViewModel p)
        {
            var user = new IdentityUser()
            {
                UserName = p.Username
            };

            var result = await _userManager.CreateAsync(user, p.Password);

            if (result.Succeeded)
            {
                RedirectToAction("SignIn");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
            }

            return View(p);
        }

        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(UserLoginViewModel p)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(p.Username, p.Password, false, true);

                if (result.Succeeded)
                {
                    return Redirect("/Member/Home/Index");
                }
                else
                {
                    return View();
                }
            }

            return View();

        }
    }
}
