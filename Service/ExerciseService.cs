using Instagram_Clone.ApplicationDBContext;
using Instagram_Clone.Interface;
using Instagram_Clone.Models;
using Microsoft.EntityFrameworkCore;

namespace Instagram_Clone.Service
{
    public class ExerciseService : IExerciseService
    {
        private readonly AppDbContext _appDbContext;

        public ExerciseService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<Exercise>> GetExerciseListAsync()
        {
            var exerciseList = await _appDbContext.Exercises.Take(4).ToListAsync();
            return exerciseList;
        }
    }
}
