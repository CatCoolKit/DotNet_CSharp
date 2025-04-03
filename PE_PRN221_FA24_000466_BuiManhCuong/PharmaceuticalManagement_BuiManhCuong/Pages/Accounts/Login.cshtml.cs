using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Repository;
using System.Security.Claims;

namespace PharmaceuticalManagement_BuiManhCuong.Pages.Accounts
{
    public class LoginModel : PageModel
    {
        private readonly IAccountRepository accountRepository;

        public LoginModel(IAccountRepository authService)
        {
            accountRepository = authService;
        }

        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public string ErrorMessage { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                var account = accountRepository.Login(Username, Password);
                if (account != null)
                {
                    var claims = new List<Claim>
                        {
                            new Claim(ClaimTypes.NameIdentifier, account.StoreAccountId.ToString()),
                            new Claim(ClaimTypes.Email, account.EmailAddress),
                            new Claim(ClaimTypes.Role, account.Role.ToString())
                        };

                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var authProperties = new AuthenticationProperties();

                    HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                       new ClaimsPrincipal(claimsIdentity), authProperties);

                    return RedirectToPage("/Medicines/Index");
                }
                else
                {
                    ErrorMessage = "Invalid username or password.";
                    return Page();
                }
            }
            return Page();
        }
    }
}
