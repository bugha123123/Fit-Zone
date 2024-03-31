using Instagram_Clone.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Instagram_Clone.Controllers
{
    public class ProfileController : Controller
    {
        private readonly IAccountService _accountService;

        public ProfileController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        public async Task<IActionResult> ProfilePage()
        {

            var user = await _accountService.GetLoggedInUserAsync();
            return View(user);
        }
    }
}
