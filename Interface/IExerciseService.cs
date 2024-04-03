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
        Task<List<Exercise>> GetExercisesAsync();


        Task<List<Exercise>> GetSimilarExercises(int excludedExerciseId);
    }
}
