using examm.DAL;
using examm.Models;
using examm.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace examm.Controllers
{
    public class AccountController : Controller

    {
        private readonly UserManager<AppDbContext> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<AppDbContext> _signInManager;

        public AccountController(UserManager<AppDbContext> userManager, RoleManager<IdentityRole> roleManager, SignInManager<AppDbContext> signInManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Registr()
        {
            return View();
        }
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Registr(RegistrVM registrVM)
        //{
        //   if (!ModelState.IsValid) return View(registrVM);
        // {
        //        AppUser appUser = new AppUser()
        //       {
        //             UserName = registrVM.UserName,
        //         Email = registrVM.Email,
        //        };
            

                
                
        //   }

        //}
        public IActionResult Login()
        {
            return View();

        }
       
       
        
    }
}
