using DTO;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Repository;
using System.Security.Claims;

namespace PE_PRN221_FA24_000466_BuiManhCuong_MVC.Controllers
{
    public class AuthController : Controller
    {
        private readonly IAccountRepository _accountRepo;

        public AuthController(IAccountRepository accountRepo)
        {
            _accountRepo = accountRepo;
        }

        public IActionResult Login()
        {
            return View(new AccountLogin());
        }

        [HttpPost]
        public async Task<IActionResult> Login(AccountLogin model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var user = _accountRepo.Login(model.AccountEmail, model.AccountPassword);
            if (user == null)
            {
                ModelState.AddModelError(string.Empty, "Invalid email or password.");
                return View(model);
            }

            var claims = new List<Claim>
                        {
                            new Claim(ClaimTypes.NameIdentifier, user.StoreAccountId.ToString()),
                            new Claim(ClaimTypes.Email, user.EmailAddress),
                            new Claim(ClaimTypes.Role, user.Role.ToString())
                        };

            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var authProperties = new AuthenticationProperties();

            HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
               new ClaimsPrincipal(claimsIdentity), authProperties);

            if (user.Role == 2 || user.Role == 3)
            {
                return RedirectToAction("Index", "MedicineInformations");
            }

            return RedirectToAction("AccessDenied", "Home");
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login");
        }

        
    }
}
