using Instagram_Clone.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Instagram_Clone.Controllers
{
    public class ExerciseController : Controller
    {
        private readonly IExerciseService _exerciseService;

        public ExerciseController(IExerciseService exerciseService)
        {
            _exerciseService = exerciseService;
        }

        public async Task<ActionResult> ExerciseDetailsPage(int ExerciseId)
        {
            var ExerciseById = await _exerciseService.GetExerciseByIdAsync(ExerciseId);  
            return View(ExerciseById);
        }
    }
}
