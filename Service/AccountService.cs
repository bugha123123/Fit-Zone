using Instagram_Clone.DTO;
using Instagram_Clone.Interface;
using Instagram_Clone.Models;
using Microsoft.AspNetCore.Identity;

namespace Instagram_Clone.Service
{
    public class AccountService : IAccountService
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        public AccountService(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public async Task LogInUser(LogInUserDTO logInUserDTO)
        {
            await _signInManager.PasswordSignInAsync(logInUserDTO.Gmail, logInUserDTO.Password, isPersistent: false, lockoutOnFailure: false);
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
