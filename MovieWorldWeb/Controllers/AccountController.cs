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
		public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
		{
			_userManager = userManager;

			_signInManager = signInManager;

		}

		public IActionResult Index()
		{
			return View();
		}

		[HttpGet]
		public IActionResult Register()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Register(RegisterViewModels model)
		{
			try
			{
				if (!ModelState.IsValid)
				{
					return View(model);
				}

				// aynı username'den varsa hata versin
				var sameUser = _userManager.FindByNameAsync(model.Username).Result; // async bir metodun sonuna .Result yazarsak metod senkron çalışır
				if (sameUser != null)
				{
					ModelState.AddModelError("", "Bu kullanıcı ismi sistemde mevcuttur! Farklı kullanıcı adı deneyiniz!");
				}


				sameUser = _userManager.FindByEmailAsync(model.Email).Result;
				if (sameUser != null)
				{
					ModelState.AddModelError("", "Bu email ile sistemde mevcuttur! Farklı email deneyiniz!");
				}


				AppUser user = new AppUser()
				{
					UserName = model.Username,
					Name = model.Name,
					Surname = model.Surname,
					Email = model.Email,
					EmailConfirmed = true,


				};

				var result = _userManager.CreateAsync(user, model.Password).Result;
				if (result.Succeeded)
				{				
					return RedirectToAction("Login", "Account");
				}
				else
				{
					ModelState.AddModelError("", "Ekleme başarısız!");
					foreach (var item in result.Errors)
					{
						ModelState.AddModelError("", item.Description);

					}
					return View(model);
				}
			}
			catch (Exception ex)
			{
				ModelState.AddModelError("", "Beklenmedik hata oluştu!");
				return View(model);

			}
		}


		[HttpGet]
		public IActionResult Login()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Login(LoginViewModels model)
		{
			try
			{
				if (!ModelState.IsValid)
				{
					return View(model);
				}

				var user = _userManager.FindByEmailAsync(model.UserNameOrEmail).Result;

				if (user == null)
				{
					ModelState.AddModelError("", "Email ya da şifre hatalidir!");
					return View(model);
				}
				var signinResult =
				 _signInManager.PasswordSignInAsync(user, model.Password, true, true).Result;
				TempData["LoggedInUsername"] = user.UserName; //username sayisal deger olarak geliyor.
				TempData["LoggedInNameSurname"] = $"{user.Name} {user.Surname}";

				if (!signinResult.Succeeded)
				{
					ModelState.AddModelError("", "Giris BASARISIZDIR!");
					return View(model);
				}
				if (_userManager.IsEmailConfirmedAsync(user).Result)
				{
					return RedirectToAction("Index", "HomeUser");
				}
				else
				{
					return RedirectToAction("Index", "HomeUser");
				}
				return View();
			}
			catch (Exception ex)
			{
				ModelState.AddModelError("", "Beklenmedik bir hata olustu!");
				return View(model);
			}
		}


	}
}
