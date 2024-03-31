using Instagram_Clone.Models;
using Instagram_Clone.wwwroot.SeedExerciseData;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Instagram_Clone.ApplicationDBContext
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }


        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Call the Seed method from ExerciseSeedData
            ExerciseData.Seed(modelBuilder);
        }


    }
}
