using Instagram_Clone.Models;
using Microsoft.EntityFrameworkCore;

namespace Instagram_Clone.wwwroot.SeedExerciseData
{
    public class ExerciseData
    {
        public static void Seed(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Subscription>().HasData(
      new Subscription
      {
          Id = 1,
          BuyDate = DateTime.Now,
          PlanPrice = 9.99,
          PlanType = "Basic",
          ExpireDate = DateTime.Now.AddMonths(1) 
      }
  );

            modelBuilder.Entity<Exercise>().HasData(
      new Exercise
      {
          Id = 1,
          ExerciseName = "Push-up",
          ExerciseTime = "30",
          RestBetweenExercises = "10",
          ExerciseReps = "15 reps",
          ExerciseImage = "/ExerciseImages/PushUp.jpg",
          ExerciseCategory = ExerciseCategory.Beginner,
          ExerciseMainFocus = ExerciseMainFocus.LoseWeight,
          ExclusiveContent = true,
          MuscleGroup = "Chest",
          EquipmentRequired = false,
          
      },
      new Exercise
      {
          Id = 2,
          ExerciseName = "Squats",
          ExerciseTime = "45",
          RestBetweenExercises = "15",
          ExerciseReps = "20 reps",
          ExerciseImage = "/ExerciseImages/BodyWeightSquat.jpg",
          ExerciseCategory = ExerciseCategory.Beginner,
          ExerciseMainFocus = ExerciseMainFocus.GainWeight,
          ExclusiveContent = false,
          MuscleGroup = "Legs",
          EquipmentRequired = false,
          
      },
      new Exercise
      {
          Id = 3,
          ExerciseName = "Plank",
          ExerciseTime = "60",
          RestBetweenExercises = "10",
          ExerciseReps = "3",
          ExerciseImage = "/ExerciseImages/Plank.png",
          ExerciseCategory = ExerciseCategory.Beginner,
          ExerciseMainFocus = ExerciseMainFocus.LoseWeight,
          ExclusiveContent = true,
          MuscleGroup = "Core",
          EquipmentRequired = false,
          
      },
      new Exercise
      {
          Id = 4,
          ExerciseName = "Lunges",
          ExerciseTime = "45",
          RestBetweenExercises = "10",
          ExerciseReps = "12 reps per leg",
          ExerciseImage = "/ExerciseImages/Lunges.jpg",
          ExerciseCategory = ExerciseCategory.Beginner,
          ExerciseMainFocus = ExerciseMainFocus.LoseWeight,
          ExclusiveContent = false,
          MuscleGroup = "Legs",
          EquipmentRequired = false,
          
      },
      new Exercise
      {
          Id = 5,
          ExerciseName = "Burpees",
          ExerciseTime = "45",
          RestBetweenExercises = "15",
          ExerciseReps = "12 reps",
          ExerciseImage = "/ExerciseImages/Burpees.jpg",
          ExerciseCategory = ExerciseCategory.Intermediate,
          ExerciseMainFocus = ExerciseMainFocus.LoseWeight,
          ExclusiveContent = true,
          MuscleGroup = "Full Body",
          EquipmentRequired = false,
          
      },
      new Exercise
      {
          Id = 6,
          ExerciseName = "Mountain Climbers",
          ExerciseTime = "45",
          RestBetweenExercises = "10",
          ExerciseReps = "20 reps",
          ExerciseImage = "/ExerciseImages/MountainClimbers.jpg",
          ExerciseCategory = ExerciseCategory.Intermediate,
          ExerciseMainFocus = ExerciseMainFocus.LoseWeight,
          ExclusiveContent = false,
          MuscleGroup = "Core",
          EquipmentRequired = false,
          
      },
      new Exercise
      {
          Id = 7,
          ExerciseName = "Sit-ups",
          ExerciseTime = "60",
          RestBetweenExercises = "10",
          ExerciseReps = "20 reps",
          ExerciseImage = "/ExerciseImages/Sit-ups.jpg",
          ExerciseCategory = ExerciseCategory.Intermediate,
          ExerciseMainFocus = ExerciseMainFocus.GainWeight,
          ExclusiveContent = true,
          MuscleGroup = "Core",
          EquipmentRequired = false,
          
      },
      new Exercise
      {
          Id = 8,
          ExerciseName = "Jumping Jacks",
          ExerciseTime = "60",
          RestBetweenExercises = "10",
          ExerciseReps = "30 reps",
          ExerciseImage = "/ExerciseImages/JumpingJacks.jpg",
          ExerciseCategory = ExerciseCategory.Intermediate,
          ExerciseMainFocus = ExerciseMainFocus.LoseWeight,
          ExclusiveContent = false,
          MuscleGroup = "Full Body",
          EquipmentRequired = false,
          
      },
      new Exercise
      {
          Id = 9,
          ExerciseName = "High Knees",
          ExerciseTime = "45",
          RestBetweenExercises = "10",
          ExerciseReps = "30 reps",
          ExerciseImage = "/ExerciseImages/HighKnees.jpg",
          ExerciseCategory = ExerciseCategory.Intermediate,
          ExerciseMainFocus = ExerciseMainFocus.LoseWeight,
          ExclusiveContent = true,
          MuscleGroup = "Cardio",
          EquipmentRequired = false,
          
      },
      new Exercise
      {
          Id = 10,
          ExerciseName = "Plank Jacks",
          ExerciseTime = "30",
          RestBetweenExercises = "10",
          ExerciseReps = "20 reps",
          ExerciseImage = "/ExerciseImages/PlankJacks.jpg",
          ExerciseCategory = ExerciseCategory.Intermediate,
          ExerciseMainFocus = ExerciseMainFocus.LoseWeight,
          ExclusiveContent = false,
          MuscleGroup = "Core",
          EquipmentRequired = false,
          
      },
      new Exercise
      {
          Id = 11,
          ExerciseName = "Russian Twists",
          ExerciseTime = "60",
          RestBetweenExercises = "10",
          ExerciseReps = "20 reps",
          ExerciseImage = "/ExerciseImages/RussianTwists.jpg",
          ExerciseCategory = ExerciseCategory.Advanced,
          ExerciseMainFocus = ExerciseMainFocus.LoseWeight,
          ExclusiveContent = true,
          MuscleGroup = "Core",
          EquipmentRequired = false,
          
      },
      new Exercise
      {
          Id = 12,
          ExerciseName = "Wall Sit",
          ExerciseTime = "60",
          RestBetweenExercises = "10",
          ExerciseReps = "N/A",
          ExerciseImage = "/ExerciseImages/WallSit.jpg",
          ExerciseCategory = ExerciseCategory.Advanced,
          ExerciseMainFocus = ExerciseMainFocus.GainWeight,
          ExclusiveContent = false,
          MuscleGroup = "Legs",
          EquipmentRequired = false,
          
      },
      new Exercise
      {
          Id = 13,
          ExerciseName = "Tricep Dips",
          ExerciseTime = "45",
          RestBetweenExercises = "10",
          ExerciseReps = "15 reps",
          ExerciseImage = "/ExerciseImages/TricepDips.jpg",
          ExerciseCategory = ExerciseCategory.Advanced,
          ExerciseMainFocus = ExerciseMainFocus.GainWeight,
          ExclusiveContent = true,
          MuscleGroup = "Arms",
          EquipmentRequired = true,
          
      },
      new Exercise
      {
          Id = 14,
          ExerciseName = "Bicycle Crunches",
          ExerciseTime = "60",
          RestBetweenExercises = "10",
          ExerciseReps = "20 reps",
          ExerciseImage = "/ExerciseImages/BicycleCrunches.jpg",
          ExerciseCategory = ExerciseCategory.Advanced,
          ExerciseMainFocus = ExerciseMainFocus.LoseWeight,
          ExclusiveContent = false,
          MuscleGroup = "Core",
          EquipmentRequired = false,
          
      },
      new Exercise
      {
          Id = 15,
          ExerciseName = "Calf Raises",
          ExerciseTime = "45",
          RestBetweenExercises = "10",
          ExerciseReps = "20 reps",
          ExerciseImage = "/ExerciseImages/CalfRaises.jpg",
          ExerciseCategory = ExerciseCategory.Advanced,
          ExerciseMainFocus = ExerciseMainFocus.GainWeight,
          ExclusiveContent = true,
          MuscleGroup = "Legs",
          EquipmentRequired = false,
          
      },
      new Exercise
      {
          Id = 16,
          ExerciseName = "Shoulder Press",
          ExerciseTime = "45",
          RestBetweenExercises = "10",
          ExerciseReps = "12 reps",
          ExerciseImage = "/ExerciseImages/ShoulderPress.jpg",
          ExerciseCategory = ExerciseCategory.Advanced,
          ExerciseMainFocus = ExerciseMainFocus.GainWeight,
          ExclusiveContent = false,
          MuscleGroup = "Shoulders",
          EquipmentRequired = true,
          
      },
      new Exercise
      {
          Id = 17,
          ExerciseName = "Dead Bug",
          ExerciseTime = "60",
          RestBetweenExercises = "10",
          ExerciseReps = "20 reps",
          ExerciseImage = "/ExerciseImages/DeadBug.jpg",
          ExerciseCategory = ExerciseCategory.Advanced,
          ExerciseMainFocus = ExerciseMainFocus.LoseWeight,
          ExclusiveContent = true,
          MuscleGroup = "Core",
          EquipmentRequired = false,
          
      },
      new Exercise
      {
          Id = 18,
          ExerciseName = "Superman",
          ExerciseTime = "60",
          RestBetweenExercises = "10",
          ExerciseReps = "10",
          ExerciseImage = "/ExerciseImages/Superman.jpg",
          ExerciseCategory = ExerciseCategory.Advanced,
          ExerciseMainFocus = ExerciseMainFocus.GainWeight,
          ExclusiveContent = false,
          MuscleGroup = "Back",
          EquipmentRequired = false,
          
      },
      new Exercise
      {
          Id = 19,
          ExerciseName = "Reverse Crunches",
          ExerciseTime = "45",
          RestBetweenExercises = "10",
          ExerciseReps = "15 reps",
          ExerciseImage = "/ExerciseImages/ReverseCrunches.jpg",
          ExerciseCategory = ExerciseCategory.Advanced,
          ExerciseMainFocus = ExerciseMainFocus.LoseWeight,
          ExclusiveContent = true,
          MuscleGroup = "Core",
          EquipmentRequired = false,
          
      },
      new Exercise
      {
          Id = 20,
          ExerciseName = "Jump Rope",
          ExerciseTime = "60",
          RestBetweenExercises = "10",
          ExerciseReps = "3",
          ExerciseImage = "/ExerciseImages/JumpRope.jpg",
          ExerciseCategory = ExerciseCategory.Advanced,
          ExerciseMainFocus = ExerciseMainFocus.LoseWeight,
          ExclusiveContent = false,
          MuscleGroup = "Cardio",
          EquipmentRequired = false,
          
      }
  );




        }
    }
}
