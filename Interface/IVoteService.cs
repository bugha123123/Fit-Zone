using Instagram_Clone.Models;

namespace Instagram_Clone.Interface
{
    public interface IVoteService
    {

        Task AddVoteForExercise(ExerciseVotes exerciseVotes);
    }
}
