using System.ComponentModel.DataAnnotations;

namespace LibrarySystemWeb.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Username is required")]
        public string Email { get; set; } = string.Empty;
        public int? UserId{ get; set; } = null;
        public string? UserType{ get; set; } = "USER";

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;

        public string Message { get; set; } = string.Empty;
    }
}



//using LibrarySystemWeb.Models.Auth;
//using Microsoft.AspNetCore.Authentication.Cookies;
//using Microsoft.AspNetCore.Authentication;
//using Microsoft.AspNetCore.Mvc.RazorPages;
//using Microsoft.AspNetCore.Mvc;
//using System.Security.Claims;


//namespace LibrarySystemWeb.Models
//{
//    public class LoginModel : PageModel
//    {
//        private readonly IUserService _userService;
//        private readonly CustomAuthStateProvider _authStateProvider;

//        public LoginModel(IUserService userService, CustomAuthStateProvider authStateProvider)
//        {
//            _userService = userService;
//            _authStateProvider = authStateProvider;
//            Message = string.Empty;
//        }

//        [BindProperty]
//        public LoginInputModel Input { get; set; } = new LoginInputModel();

//        public string Message { get; set; }

//        public class LoginInputModel
//        {
//            public string Username { get; set; } = string.Empty;
//            public string Password { get; set; } = string.Empty;
//        }

//        public async Task<IActionResult> OnPostAsync()
//        {
//            // Add debugging to see if we get here
//            Console.WriteLine($"Login attempt for user: {Input.Username}");

//            try
//            {
//                var user = await _userService.ValidateUserAsync(Input.Username, Input.Password);
//                Console.WriteLine($"User validation result: {(user != null ? "Success" : "Failed")}");

//                if (user == null)
//                {
//                    Message = "Invalid username or password.";
//                    return Page();
//                }

//                var claims = new List<Claim>
//            {
//                new Claim(ClaimTypes.Name, Input.Username),
//                new Claim(ClaimTypes.Role, "Individual")
//            };

//                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
//                var principal = new ClaimsPrincipal(identity);

//                await HttpContext.SignInAsync(
//                    CookieAuthenticationDefaults.AuthenticationScheme,
//                    principal,
//                    new AuthenticationProperties
//                    {
//                        IsPersistent = true,
//                        ExpiresUtc = DateTime.UtcNow.AddHours(1)
//                    });

//                // Notify Blazor immediately about auth state change
//                _authStateProvider.NotifyAuthenticationStateChangedManually();

//                return RedirectToPage("/");
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"Exception during login: {ex.Message}");
//                Message = "An error occurred during login. Please try again.";
//                return Page();
//            }
//        }

//        public void OnGet()
//        {
//            // Add debugging to see if the page is being loaded
//            Console.WriteLine("Login page GET request received");
//        }
//    }
//}
