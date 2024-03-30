using Microsoft.AspNetCore.Identity;

namespace Instagram_Clone.Models
{
    public class User :IdentityUser
    {

        public string FitnessLevel { get; set; } = "Beginner";
    }
}
