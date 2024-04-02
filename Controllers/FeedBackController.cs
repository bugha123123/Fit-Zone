using Instagram_Clone.Interface;
using Instagram_Clone.Models;
using Microsoft.AspNetCore.Mvc;

namespace Instagram_Clone.Controllers
{
    public class FeedBackController : Controller
    {
        private readonly IFeedBackService _feedBackService;

        public FeedBackController(IFeedBackService feedBackService)
        {
            _feedBackService = feedBackService;
        }

        public IActionResult FeedBackPage()
        {
            return View();
        }


        [HttpPost("addfeedback")]

        public async Task<IActionResult> AddFeedBack(FeedBack feedBack)
        {
            if (ModelState.IsValid)
            {
                await _feedBackService.AddFeedBack(feedBack);
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("FeedBackPage", "FeedBack");

        }


    }
}
