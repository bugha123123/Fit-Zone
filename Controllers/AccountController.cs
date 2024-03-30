using Instagram_Clone.DTO;
using Instagram_Clone.Interface;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace Instagram_Clone.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        public IActionResult LogInPage()
        {
            return View();
        }

        public IActionResult RegisterPage()
        {
            return View();
        }

        public async Task<IActionResult> ProfilePage()
        {
          
            var user = await _accountService.GetLoggedInUserAsync();
            return View(user);
        }
        [HttpPost("registeruser")]
        public async Task<IActionResult> RegisterUser(CreateUserDTO createUserDTO)
        {
            await _accountService.RegisterUser(createUserDTO);

            // Set localStorage item after registering user
            HttpContext.Response.Cookies.Append("loggedIn", "true");
            return RedirectToAction("Index", "Home");
        }

        [HttpPost("signin")]
        public async Task<IActionResult> SignInUser(LogInUserDTO logInUserDTO)
        {
            await _accountService.LogInUser(logInUserDTO);

            // Set localStorage item after signing in
            HttpContext.Response.Cookies.Append("loggedIn", "true");
            return RedirectToAction("Index", "Home");
        }

        [HttpPost("LogOutUser")]
        public async Task<IActionResult> LogOutUser()
        {
            await _accountService.LogOutUser();

            HttpContext.Response.Cookies.Delete("loggedIn");
            return RedirectToAction("LogInPage", "Account");
        }


        public IActionResult FacebookLogin()
        {
            // Redirect the user to Facebook for authentication
            return Challenge(new AuthenticationProperties { RedirectUri = "/signin-facebook" }, "Facebook");
        }
    }
}
