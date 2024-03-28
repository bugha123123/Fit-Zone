using Instagram_Clone.DTO;
using Instagram_Clone.Interface;
using Instagram_Clone.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Instagram_Clone.Service
{
    public class AccountService : IAccountService
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public AccountService(UserManager<User> userManager, SignInManager<User> signInManager, IHttpContextAccessor httpContextAccessor)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<User> GetLoggedInUserAsync()
        {
            // Get the username of the currently authenticated user
            string userName = _httpContextAccessor.HttpContext.User.Identity.Name!;

            // Find the user by username
            var user = await _userManager.FindByNameAsync(userName);

            return user;
        }
        public async Task<List<User>> GetUsers()
        {
            var users = await _userManager.Users.ToListAsync();  

            return users;   
        }

        public async Task LogInUser(LogInUserDTO logInUserDTO)
        {
            await _signInManager.PasswordSignInAsync(logInUserDTO.UserName, logInUserDTO.Password, isPersistent: false, lockoutOnFailure: false);
        }

        public async Task LogOutUser()
        {
            await _signInManager.SignOutAsync();
        }

        public async Task RegisterUser(CreateUserDTO createUserDTO)
        {
            var user = new User
            {
                UserName = createUserDTO.Username,
                Email = createUserDTO.Gmail
            };

            var result = await _userManager.CreateAsync(user, createUserDTO.Password);

            if (result.Succeeded)
            {
                await _signInManager.SignInAsync(user, isPersistent: false);
            }
        }
    }
}
