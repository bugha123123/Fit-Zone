using Microsoft.AspNetCore.Identity;
using System;

namespace Instagram_Clone.Models
{
    public class User : IdentityUser
    {
        public string FitnessLevel { get; set; } = "Beginner";
        public bool HasSubscription { get; set; } = false;
        public string? BoughtSubscriptionName { get; set; }
        public string? ProfileImageFileName { get; set; }

        public int DailyLimit { get; set; } = 5;
        public bool DailyLimitExceeded { get; set; } = false;
        public DateTime? LastAddedAt { get; set; }
    }
}
