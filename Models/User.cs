using Microsoft.AspNetCore.Identity;

namespace Instagram_Clone.Models
{
    public class User :IdentityUser
    {

        public string FitnessLevel { get; set; } = "Beginner";
        public bool HasSubscription { get; set; } = false;

        public string? BoughtSubscriptionName { get; set; }

        public string? ProfileImageFileName { get; set; }
    }
}
