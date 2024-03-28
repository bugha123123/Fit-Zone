using Instagram_Clone.DTO;
using Instagram_Clone.Models;

namespace Instagram_Clone.Interface
{
    public interface IAccountService
    {

        Task LogInUser(LogInUserDTO logInUserDTO);

        Task RegisterUser(CreateUserDTO CreateUserDTO);

        Task LogOutUser();

        Task<List<User>> GetUsers();

        Task<User> GetLoggedInUserAsync();
    }
}
