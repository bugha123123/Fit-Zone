using Instagram_Clone.Models;

namespace Instagram_Clone.Interface
{
    public interface IExerciseService
    {

        // this returns only 4 exercise
        Task<List<Exercise>> GetExerciseListAsync();

        Task<Exercise> GetExerciseByIdAsync(int id);

        Task<List<Subscription>> GetSubscriptionsAsync();

        Task<Subscription> GetSubscriptionByIdAsync(int id);

        Task RemoveSubscription();


        // this returns all of the exercises
        Task<List<Exercise>> GetExercisesAsync(string muscleGroup = null,
            bool? equipmentRequired = null,
            ExerciseCategory? exerciseCategory = null,
            ExerciseMainFocus? exerciseMainFocus = null, int pageNumber = 1,
        int pageSize = 10);


        Task<List<Exercise>> GetSimilarExercises(int excludedExerciseId);

        Task SaveExercise(int exerciseId, string exerciseName);

        Task<bool> IsExerciseAlreadySaved(string exerciseName, string userId);

        Task<List<SavedExercise>> GetSavedExercises();

        Task RemoveExercise(int savedexerciseid);

    }
}
