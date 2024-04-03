using Instagram_Clone.ApplicationDBContext;
using Instagram_Clone.Interface;
using Instagram_Clone.Models;

namespace Instagram_Clone.Service
{
    public class VoteService : IVoteService
    {
        private readonly AppDbContext _dbcontext;

        public VoteService(AppDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task AddVoteForExercise(ExerciseVotes exerciseVotes)
        {
            var NewVote = new ExerciseVotes()
            {
                DownVote
                = exerciseVotes.DownVote,
                UpVote = exerciseVotes.UpVote,
                DownVoteCount = exerciseVotes.DownVote,
                UpVoteCount = exerciseVotes.UpVote,
            };

            await _dbcontext.AddAsync(NewVote);
            await _dbcontext.SaveChangesAsync();
        }
    }
}
