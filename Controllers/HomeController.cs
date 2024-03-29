using Instagram_Clone.Interface;
using Instagram_Clone.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Instagram_Clone.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPostService _postService;

        public HomeController(IPostService postService)
        {
            _postService = postService;
        }

        [Authorize]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost("createnewpost")]
        public async Task<IActionResult> CreateNewPost(Post post, IFormFile MainImage)
        {
           
                await _postService.CreatePost(post, MainImage);
                return RedirectToAction("Index", "Home");
            

        }



    }
}
