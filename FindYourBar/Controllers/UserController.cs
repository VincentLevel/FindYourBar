using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FindYourBar.Data;
using FindYourBar.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using FindYourBar.ViewModels;

namespace FindYourBar.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public UserController(ApplicationDbContext dbContext, UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _context = dbContext;
            _userManager = userManager;
            _signInManager = signInManager;
        }

       [HttpGet]
        public IActionResult Register()
        {
            return View();

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                User user = new User {
                    UserName = viewModel.UserName,
                    PhoneNumber = viewModel.PhoneNumber,
                    Email = viewModel.Email,
                };
                var result = await _userManager.CreateAsync(user, viewModel.Password);
                if(result.Succeeded)
                {
                    return Redirect("/");
                }
                else
                {
                    return View();
                }

            }
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}