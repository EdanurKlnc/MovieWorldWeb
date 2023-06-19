using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MovieWorldWeb.Models;
using MovieWorldWebEL.IdentityModels;

namespace MovieWorldWeb.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager )
        {
            _userManager = userManager;
    
            _signInManager = signInManager;
            
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Register(RegisterViewModels model)
        {
            return View();
        }
        public IActionResult Login(LoginViewModels model)
        {
            return View();
        }
       

    }
}
