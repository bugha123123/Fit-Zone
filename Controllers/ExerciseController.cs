using Instagram_Clone.Interface;
using Instagram_Clone.Models;
using Microsoft.AspNetCore.Mvc;

namespace Instagram_Clone.Controllers
{
    public class ExerciseController : Controller
    {
        private readonly IExerciseService _exerciseService;
        private readonly IAccountService _accountService;
        public ExerciseController(IExerciseService exerciseService, IAccountService accountService)
        {
            _exerciseService = exerciseService;
            _accountService = accountService;
        }

        public async Task<ActionResult> ExerciseDetailsPage(int ExerciseId)
        {
            var ExerciseById = await _exerciseService.GetExerciseByIdAsync(ExerciseId);  
            return View(ExerciseById);
        }

        [HttpPost]

        public async Task<IActionResult> SaveUserFitnessLevel(Exercise exercise)
        {
            await _accountService.SaveUserFitnessLevel(exercise);
            return RedirectToAction("Index", "Home");
        }
    }
}
