using Instagram_Clone.Models;

namespace Instagram_Clone.Interface
{
    public interface IFeedBackService
    {

        Task AddFeedBack(FeedBack feedBack);

        Task<List<FeedBack>> GetAllFeedBacks();
    }
}
