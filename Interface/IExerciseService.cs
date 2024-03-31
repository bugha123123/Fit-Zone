using Instagram_Clone.Models;

namespace Instagram_Clone.Interface
{
    public interface IExerciseService
    {

        Task<List<Exercise>> GetExerciseListAsync();

        Task<Exercise> GetExerciseByIdAsync(int id);

        Task<List<Subscription>> GetSubscriptionsAsync();

        Task<Subscription> GetSubscriptionByIdAsync(int id);

        Task RemoveSubscription();
    }
}
