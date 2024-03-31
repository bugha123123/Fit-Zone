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
                await _signInManager.SignInAsync(user, isPersistent: false);
            }
        }

        public async Task SaveUserFitnessLevel(Exercise exercise)
        {
         var user = await GetLoggedInUserAsync();
            user.FitnessLevel = exercise.ExerciseCategory.ToString();

          await  _appDbContext.SaveChangesAsync();
            
        }

        public async Task UploadUserProfileImage(IFormFile ProfileImage)
        {
            var user = await GetLoggedInUserAsync();   

            if (ProfileImage != null && ProfileImage.Length > 0)
            {

                string uniqueFileName = ProcessUploadedFile(ProfileImage);

                user.ProfileImageFileName = uniqueFileName;
            }

            await _appDbContext.SaveChangesAsync();
        }

        //image process logic 
        private string ProcessUploadedFile(IFormFile profileImage)
        {
            var uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "ProfileImage");
            var uniqueFileName = Guid.NewGuid().ToString() + "_" + profileImage.FileName;
            var filePath = Path.Combine(uploadsFolder, uniqueFileName);

            using (var image = System.Drawing.Image.FromStream(profileImage.OpenReadStream()))
            {
                // Resize the image if needed (adjust dimensions accordingly)
                var resizedImage = ResizeImage(image, 200, 200);

                // Save the resized image to the file system
                resizedImage.Save(filePath, ImageFormat.Png);
            }

            return uniqueFileName;
        }

        private System.Drawing.Image ResizeImage(System.Drawing.Image image, int width, int height)
        {
            var destRect = new System.Drawing.Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

    }
}
