using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Instagram_Clone.Models
{
    public class User : IdentityUser
    {
        public string FitnessLevel { get; set; } = "Beginner";
        public bool HasSubscription { get; set; } = false;
        public string? BoughtSubscriptionName { get; set; }
        public string? ProfileImageFileName { get; set; }

        // New property to hold exercise names
        public List<string> ExerciseNames { get; set; } = new List<string>();
    }
}
