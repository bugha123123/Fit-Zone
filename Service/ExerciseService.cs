using Instagram_Clone.ApplicationDBContext;
using Instagram_Clone.Interface;
using Instagram_Clone.Models;
using Microsoft.EntityFrameworkCore;

namespace Instagram_Clone.Service
{
    public class ExerciseService : IExerciseService
    {
        private readonly AppDbContext _appDbContext;
        private readonly IAccountService _accountService;
        public ExerciseService(AppDbContext appDbContext, IAccountService accountService)
        {
            _appDbContext = appDbContext;
            _accountService = accountService;
        }

        public async Task<Exercise> GetExerciseByIdAsync(int id)
        {
            var exercise = await _appDbContext.Exercises.FirstOrDefaultAsync(e => e.Id == id);

            if (exercise == null)
            {
                throw new Exception("Excercise not found");
            }

            return exercise;
        }

        public async Task<List<Exercise>> GetExerciseListAsync()
        {
            var user = await _accountService.GetLoggedInUserAsync();
            var fitnessLevel = Enum.Parse<ExerciseCategory>(user.FitnessLevel);

            var exerciseList = await _appDbContext.Exercises
                .Where(e => e.ExerciseCategory == fitnessLevel)
                .Take(4)
                .ToListAsync();

            return exerciseList;
        }



        public async Task<List<Exercise>> GetExercisesAsync(
            string muscleGroup = null,
            bool? equipmentRequired = null,
            ExerciseCategory? exerciseCategory = null,
            ExerciseMainFocus? exerciseMainFocus = null,
            int pageNumber = 1,
            int pageSize = 10) // Default page size is 10
        {
            IQueryable<Exercise> query = _appDbContext.Exercises.AsQueryable();

            if (muscleGroup != null)
            {
                query = query.Where(e => e.MuscleGroup == muscleGroup);
            }

            if (equipmentRequired.HasValue)
            {
                query = query.Where(e => e.EquipmentRequired == equipmentRequired.Value);
            }

            if (exerciseCategory.HasValue)
            {
                query = query.Where(e => e.ExerciseCategory == exerciseCategory.Value);
            }

            if (exerciseMainFocus.HasValue)
            {
                query = query.Where(e => e.ExerciseMainFocus == exerciseMainFocus.Value);
            }

            int itemsToSkip = (pageNumber - 1) * pageSize;

            // Apply pagination
            query = query.Skip(itemsToSkip).Take(pageSize);

            return await query.ToListAsync();
        }
        public async Task<List<Exercise>> GetSimilarExercises(int excludedExerciseId)
        {
            var exercisesList = await _appDbContext.Exercises
                                                  .Where(e => e.Id != excludedExerciseId)
                                                  .Take(4)
                                                  .ToListAsync();
            return exercisesList;
        }




        public async Task<Subscription> GetSubscriptionByIdAsync(int id)
        {
            var subscription = await _appDbContext.Subscriptions.FirstOrDefaultAsync(e => e.Id == id);
            if (subscription == null)
            {
                throw new Exception("Excercise not found");
            }
            return subscription;

        }

        public async Task<List<Subscription>> GetSubscriptionsAsync()
        {
            var subs = await _appDbContext.Subscriptions.ToListAsync();
            return subs;
        }

        public async Task RemoveSubscription()
        {
            var user = await _accountService.GetLoggedInUserAsync();

            if (user == null)
            {
                throw new Exception("User not found");
            }

            user.HasSubscription = false;

            await _appDbContext.SaveChangesAsync();
        }
    }
}
