using System.Security.Claims;
using LibrarySystemWeb.Models;
using LibrarySystemWeb.Models.Auth;
using LibrarySystemWeb.Utils.Classes;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;

namespace LibrarySystemWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserService _userService;
        private readonly CustomAuthStateProvider _authStateProvider;

        public HomeController(IUserService userService, CustomAuthStateProvider authStateProvider)
        {
            _userService = userService;
            _authStateProvider = authStateProvider;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            // Return the login view with an empty model
            return View(new LoginViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Message = "Please fill in all required fields.";
                return View(model);
            }

            try
            {
                User user = await _userService.ValidateUserAsync(model.Email, model.Password);

                if (user == null)
                {
                    model.Message = "Invalid username or password.";
                    return View(model);
                }

                UserInfo info = new()
                {
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    UserId = user.UserId,
                    UserType = user.Type
                };
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, model.Email),
                    new Claim(ClaimTypes.Role, "Individual"),
                    new Claim("FirstName", user.FirstName),
                    new Claim("LastName", user.LastName),
                    new Claim("UserType", user.Type.ToString()),
                    new Claim("UserId", user.UserId.ToString())
                };

                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(identity);

                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    principal,
                    new AuthenticationProperties
                    {
                        IsPersistent = true,
                        ExpiresUtc = DateTime.UtcNow.AddHours(1)
                    });

                // Notify Blazor immediately about auth state change
                _authStateProvider.NotifyAuthenticationStateChangedManually();

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                // Log the exception
                Console.WriteLine($"Error during login: {ex.Message}");
                model.Message = "An error occurred during login.";
                return View(model);
            }
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index");
        }
    }
}