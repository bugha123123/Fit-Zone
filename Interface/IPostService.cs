using Instagram_Clone.Models;

namespace Instagram_Clone.Interface
{
    public interface IPostService
    {

        Task CreatePost(Post post, IFormFile MainImage);
    }
}
