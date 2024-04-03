using Instagram_Clone.ApplicationDBContext;
using Instagram_Clone.DTO;
using Instagram_Clone.Interface;
using Instagram_Clone.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing;

namespace Instagram_Clone.Service
{
    public class AccountService : IAccountService
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly AppDbContext _appDbContext;
        private readonly IWebHostEnvironment _hostingEnvironment;
        public AccountService(UserManager<User> userManager, SignInManager<User> signInManager, IHttpContextAccessor httpContextAccessor, AppDbContext appDbContext, IWebHostEnvironment hostingEnvironment)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _httpContextAccessor = httpContextAccessor;
            _appDbContext = appDbContext;
            _hostingEnvironment = hostingEnvironment;
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
                await _signInManager.SignInAsync(user, isPersistent: true,TimeSpan.FromHours(2).ToString());
            }
        }

        public async Task SaveUserFitnessLevel(Exercise exercise)
        {
         var user = await GetLoggedInUserAsync();
            user.FitnessLevel = exercise.ExerciseCategory.ToString();

          await  _appDbContext.SaveChangesAsync();
            
        }

        public async Task UploadUserProfileImage(User user, IFormFile profileImage)
        {
            var authenticatedUser = await GetLoggedInUserAsync();

            if (profileImage != null && profileImage.Length > 0)
            {
                string uniqueFileName = await ProcessUploadedFile(profileImage);
                authenticatedUser.ProfileImageFileName = uniqueFileName;
            }

            await _appDbContext.SaveChangesAsync();
        }

        private async Task<string> ProcessUploadedFile(IFormFile profileImage)
        {
            if (profileImage != null && profileImage.Length > 0)
            {
                var uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "ProfileImages");
                var uniqueFileName = Guid.NewGuid().ToString() + "_" + Path.GetFileName(profileImage.FileName);
                var filePath = Path.Combine(uploadsFolder, uniqueFileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await profileImage.CopyToAsync(stream);
                }

                return uniqueFileName;
            }
            else
            {
                throw new ArgumentNullException(nameof(profileImage), "Profile image is null.");
            }
        }





    }
}
