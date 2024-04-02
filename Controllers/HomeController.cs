using Instagram_Clone.ApplicationDBContext;
using Instagram_Clone.Interface;
using Instagram_Clone.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Instagram_Clone.Controllers
{
    public class HomeController : Controller
    {

        private readonly AppDbContext _dbContext;
        private readonly IExerciseService _exerciseService;
        public HomeController(IExerciseService exerciseService, AppDbContext dbContext)
        {
            _exerciseService = exerciseService;
            _dbContext = dbContext;
            
        }

        [Authorize]
        public async Task<IActionResult> Index()
        {
            var exerciseList = await _exerciseService.GetExerciseListAsync();
            return View(exerciseList);
        }
        public IActionResult SearchExercises(string query)
        {
            var exercises = _dbContext.Exercises
                .Where(e => e.ExerciseName.Contains(query))
                .ToList();

            return Json(exercises);
        }


    }
}
