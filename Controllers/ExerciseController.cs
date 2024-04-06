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

        public async Task<IActionResult> ExercisePage(string muscleGroup = null, bool? equipmentRequired = null, ExerciseCategory? exerciseCategory = null, ExerciseMainFocus? exerciseMainFocus = null, int pageNumber = 1, int pageSize = 10)
        {
            var exercises = await _exerciseService.GetExercisesAsync(muscleGroup, equipmentRequired, exerciseCategory, exerciseMainFocus, pageNumber, pageSize);
            return View(exercises);
        }


        [HttpPost]

        public async Task<IActionResult> SaveUserFitnessLevel(Exercise exercise)
        {
            await _accountService.SaveUserFitnessLevel(exercise);
            return RedirectToAction("Index", "Home");
        }

        [HttpPost("saveexercise")]
        public async Task<IActionResult> SaveExercise(int exerciseId, string exerciseName)
        {
            try
            {
                await _exerciseService.SaveExercise(exerciseId, exerciseName);
                return RedirectToAction("Index", "Home");
            }
            catch (ArgumentException)
            {
                TempData["ErrorMessage"] = "You have already saved this exercise.";
                return RedirectToAction("Index", "Home");
            }
        }
        [HttpPost("deleteexercise")]
        public async Task<IActionResult> DeleteExercise(int savedExerciseId)
        {
            await _exerciseService.RemoveExercise(savedExerciseId);
            return RedirectToAction("Index", "Home");
        }



    }
}
