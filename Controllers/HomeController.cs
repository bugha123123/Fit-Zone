using Instagram_Clone.Interface;
using Instagram_Clone.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Instagram_Clone.Controllers
{
    public class HomeController : Controller
    {
        private readonly IExerciseService _exerciseService;

        public HomeController(IExerciseService exerciseService)
        {
            _exerciseService = exerciseService;
        }

        [Authorize]
        public async Task<IActionResult> Index()
        {
            var exerciseList = await _exerciseService.GetExerciseListAsync();
            return View(exerciseList);
        }





    }
}
