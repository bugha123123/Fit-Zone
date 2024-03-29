// PostService class
using System;
using System.IO;
using System.Threading.Tasks;
using Instagram_Clone.ApplicationDBContext;
using Instagram_Clone.Interface;
using Instagram_Clone.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace Instagram_Clone.Service
{
    public class PostService : IPostService
    {
        private readonly AppDbContext _dbContext;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public PostService(AppDbContext dbContext, IHttpContextAccessor httpContextAccessor, IWebHostEnvironment webHostEnvironment)
        {
            _dbContext = dbContext;
            _httpContextAccessor = httpContextAccessor;
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task CreatePost(Post post, IFormFile MainImage)
        {
            if (MainImage != null && MainImage.Length > 0)
            {
                // Get logged-in username
                string username = _httpContextAccessor.HttpContext.User.Identity.Name;

                // Save image to wwwroot/Images folder
                string uniqueFileName = Guid.NewGuid().ToString() + "_" + MainImage.FileName;
                string imagePath = Path.Combine(_webHostEnvironment.WebRootPath, "Images", uniqueFileName);
                using (FileStream stream = new FileStream(imagePath, FileMode.Create))
                {
                    await MainImage.CopyToAsync(stream);
                }

                // Save post information to database
                var newPost = new Post()
                {
                    CreateAt = DateTime.Now,
                    Description = post.Description,
                    AddedByUserName = username,
                    MainImagePath = uniqueFileName,
                };

                await _dbContext.Posts.AddAsync(newPost);
                await _dbContext.SaveChangesAsync();
            }
            else
            {
                // Handle case where MainImage is null or empty
                // For example, you could throw an exception or return an error message
                throw new ArgumentNullException("MainImage", "MainImage cannot be null or empty");
            }
        }

    }
}
