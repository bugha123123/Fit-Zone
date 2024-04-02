using Instagram_Clone.ApplicationDBContext;
using Instagram_Clone.Interface;
using Instagram_Clone.Models;
using Microsoft.EntityFrameworkCore;

namespace Instagram_Clone.Service
{
    public class FeedBackService : IFeedBackService
    {

        private readonly AppDbContext _dbcontext;
public FeedBackService(AppDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task AddFeedBack(FeedBack feedBack)
        {
            var NewFeedBack = new FeedBack()
            {
                Email = feedBack.Email,
                Name = feedBack.Name,
                UserFeedBack = feedBack.UserFeedBack,
            };

            await _dbcontext.FeedBacks.AddAsync(NewFeedBack);
            await _dbcontext.SaveChangesAsync();
        }

        public async Task<List<FeedBack>> GetAllFeedBacks()
        {
           var FeedBackList = await _dbcontext.FeedBacks.ToListAsync();
            return FeedBackList;
        }
    }
}
