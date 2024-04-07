using Instagram_Clone.ApplicationDBContext;
using Instagram_Clone.Interface;
using Instagram_Clone.Models;
using Microsoft.EntityFrameworkCore;
using static Instagram_Clone.Models.Progress;

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
            int pageSize = 10)
        {
            IQueryable<Exercise> query = _appDbContext.Exercises.AsQueryable();

            // Apply filters
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

            // Get total count before pagination
            int totalCount = await query.CountAsync();

            // Apply pagination
            int itemsToSkip = (pageNumber - 1) * pageSize;
            query = query.Skip(itemsToSkip).Take(pageSize);

            List<Exercise> result = await query.ToListAsync();
            return result;
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

        public async Task<bool> IsExerciseAlreadySaved(string exerciseName, string userId)
        {
            var existingSavedExercise = await _appDbContext.SavedExercises
                .FirstOrDefaultAsync(se => se.ExerciseName == exerciseName && se.SavedBy == userId);

            return existingSavedExercise != null;
        }

        public async Task SaveExercise(int exerciseId, string exerciseName)
        {
            var exercise = await _appDbContext.Exercises.FindAsync(exerciseId);
            var user = await _accountService.GetLoggedInUserAsync();

            if (exercise != null)
            {
                var isExerciseSaved = await IsExerciseAlreadySaved(exerciseName, user.Id);

                if (!isExerciseSaved)
                {
                    var savedExercise = new SavedExercise()
                    {
                        EquipmentRequired = exercise.EquipmentRequired,
                        ExclusiveContent = exercise.ExclusiveContent,
                        ExerciseCategory = exercise.ExerciseCategory,
                        ExerciseImage = exercise.ExerciseImage,
                        ExerciseMainFocus = exercise.ExerciseMainFocus,
                        ExerciseName = exercise.ExerciseName,
                        ExerciseReps = exercise.ExerciseReps,
                        ExerciseTime = exercise.ExerciseTime,
                        MuscleGroup = exercise.MuscleGroup,
                        RestBetweenExercises = exercise.RestBetweenExercises,
                        SavedBy = user.Id
                    };

                    await _appDbContext.SavedExercises.AddAsync(savedExercise);
                    await _appDbContext.SaveChangesAsync();
                }
                else
                {
                    
                    throw new ArgumentException("Exercise has already been saved by the user");
                }
            }
            else
            {
                throw new ArgumentException("Exercise with the specified ID not found");
            }
        }

        public async Task<List<SavedExercise>> GetSavedExercises()
        {
            var user = await _accountService.GetLoggedInUserAsync();
            var savedExercises = await _appDbContext.SavedExercises.Where(u => u.SavedBy == user.Id).ToListAsync();

            if (savedExercises == null)
            {
                throw new Exception("Exercises not found");
            }

            return savedExercises;
        }

        public async Task RemoveExercise(int savedexerciseid)
        {
            var foundExercise = _appDbContext.SavedExercises.FirstOrDefault(u => u.Id == savedexerciseid);

            if (foundExercise != null)
            {
                _appDbContext.SavedExercises.Remove(foundExercise);
                await _appDbContext.SaveChangesAsync();
            }
       
        }


        public async Task<List<Progress>> GetProgresses()
        {
            var user = await _accountService.GetLoggedInUserAsync();

            var ProgressList = await _appDbContext.Progresss.Where(p => p.UserId == user.Id).ToListAsync();

            return ProgressList;
        }

        public async Task TrackUserProgress(int ExerciseId, ExerciseState exerciseState)
        {
            var exercise = await _appDbContext.Exercises.FirstOrDefaultAsync(e => e.Id == ExerciseId);
            var user = await _accountService.GetLoggedInUserAsync();
            if (exercise == null)
            {
                throw new Exception("Exercise not found");
            }

            // Check the progress count for the user
            var progressCount = await _appDbContext.Progresss.CountAsync(p => p.UserId == user.Id);
            if (progressCount >= 5)
            {
                var progress2 = new Progress()
                {
                    ExerciseName = exercise.ExerciseName,
                    UserId = user.Id,
                    exerciseState = exerciseState,
                };
                // Allow the user to proceed without incrementing points if progress count is 5 or more
                await _appDbContext.Progresss.AddAsync(progress2);
                await _appDbContext.SaveChangesAsync();
                return;
            }

            var existingExercise = await _appDbContext.Progresss
                .FirstOrDefaultAsync(p => p.ExerciseName == exercise.ExerciseName && p.UserId == user.Id);

            if (existingExercise != null)
            {
                throw new Exception($"Exercise with name '{exercise.ExerciseName}' already exists for the user.");
            }

            double pointsEarned = 0;

            if (exerciseState == ExerciseState.Finished)
            {
                pointsEarned = 1;
            }
            else if (exerciseState == ExerciseState.Halfway)
            {
                pointsEarned = 0.5;
            }
            else if (exerciseState == ExerciseState.JustStarted)
            {
                pointsEarned = 0.5 / 2;
            }


            var progress = new Progress()
            {
                ExerciseName = exercise.ExerciseName,
                UserId = user.Id,
                exerciseState = exerciseState,
                Points = pointsEarned
            };

            await _appDbContext.Progresss.AddAsync(progress);
            await _appDbContext.SaveChangesAsync();
        }





    }
}
