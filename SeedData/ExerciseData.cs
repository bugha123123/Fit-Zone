using Instagram_Clone.Models;
using Microsoft.EntityFrameworkCore;

namespace Instagram_Clone.wwwroot.SeedExerciseData
{
    public class ExerciseData
    {

        public static void Seed(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Exercise>().HasData(
 new Exercise
 {
     Id = 1,
     ExerciseName = "Push-up",
     ExerciseTime = "30 seconds",
     RestBetweenExercises = "10 seconds",
     ExerciseReps = "15 reps",
     ExerciseImage = "/ExerciseImages/PushUp.jpg"
 },
 new Exercise
 {
     Id = 2,
     ExerciseName = "Squats",
     ExerciseTime = "45 seconds",
     RestBetweenExercises = "15 seconds",
     ExerciseReps = "20 reps",
     ExerciseImage = "/ExerciseImages/BodyWeightSquat.jpg"
 },
 new Exercise
 {
     Id = 3,
     ExerciseName = "Plank",
     ExerciseTime = "1 minute",
     RestBetweenExercises = "10 seconds",
     ExerciseReps = "3",
     ExerciseImage = "/ExerciseImages/Plank.png"
 },
 new Exercise
 {
     Id = 4,
     ExerciseName = "Lunges",
     ExerciseTime = "45 seconds",
     RestBetweenExercises = "10 seconds",
     ExerciseReps = "12 reps per leg",
     ExerciseImage = "/ExerciseImages/Lunges.jpg"
 },
 new Exercise
 {
     Id = 5,
     ExerciseName = "Burpees",
     ExerciseTime = "45 seconds",
     RestBetweenExercises = "15 seconds",
     ExerciseReps = "12 reps",

 },
 new Exercise
 {
     Id = 6,
     ExerciseName = "Mountain Climbers",
     ExerciseTime = "45 seconds",
     RestBetweenExercises = "10 seconds",
     ExerciseReps = "20 reps"
 },
 new Exercise
 {
     Id = 7,
     ExerciseName = "Sit-ups",
     ExerciseTime = "1 minute",
     RestBetweenExercises = "10 seconds",
     ExerciseReps = "20 reps"
 },
 new Exercise
 {
     Id = 8,
     ExerciseName = "Jumping Jacks",
     ExerciseTime = "1 minute",
     RestBetweenExercises = "10 seconds",
     ExerciseReps = "30 reps"
 },
 new Exercise
 {
     Id = 9,
     ExerciseName = "High Knees",
     ExerciseTime = "45 seconds",
     RestBetweenExercises = "10 seconds",
     ExerciseReps = "30 reps"
 },
 new Exercise
 {
     Id = 10,
     ExerciseName = "Plank Jacks",
     ExerciseTime = "30 seconds",
     RestBetweenExercises = "10 seconds",
     ExerciseReps = "20 reps"
 },
 new Exercise
 {
     Id = 11,
     ExerciseName = "Russian Twists",
     ExerciseTime = "1 minute",
     RestBetweenExercises = "10 seconds",
     ExerciseReps = "20 reps"
 },
 new Exercise
 {
     Id = 12,
     ExerciseName = "Wall Sit",
     ExerciseTime = "1 minute",
     RestBetweenExercises = "10 seconds",
     ExerciseReps = "N/A"
 },
 new Exercise
 {
     Id = 13,
     ExerciseName = "Tricep Dips",
     ExerciseTime = "45 seconds",
     RestBetweenExercises = "10 seconds",
     ExerciseReps = "15 reps"
 },
 new Exercise
 {
     Id = 14,
     ExerciseName = "Bicycle Crunches",
     ExerciseTime = "1 minute",
     RestBetweenExercises = "10 seconds",
     ExerciseReps = "20 reps"
 },
 new Exercise
 {
     Id = 15,
     ExerciseName = "Calf Raises",
     ExerciseTime = "45 seconds",
     RestBetweenExercises = "10 seconds",
     ExerciseReps = "20 reps"
 },
 new Exercise
 {
     Id = 16,
     ExerciseName = "Shoulder Press",
     ExerciseTime = "45 seconds",
     RestBetweenExercises = "10 seconds",
     ExerciseReps = "12 reps"
 },
 new Exercise
 {
     Id = 17,
     ExerciseName = "Dead Bug",
     ExerciseTime = "1 minute",
     RestBetweenExercises = "10 seconds",
     ExerciseReps = "20 reps"
 },
 new Exercise
 {
     Id = 18,
     ExerciseName = "Superman",
     ExerciseTime = "1 minute",
     RestBetweenExercises = "10 seconds",
     ExerciseReps = "10"
 },
 new Exercise
 {
     Id = 19,
     ExerciseName = "Reverse Crunches",
     ExerciseTime = "45 seconds",
     RestBetweenExercises = "10 seconds",
     ExerciseReps = "15 reps"
 },
 new Exercise
 {
     Id = 20,
     ExerciseName = "Jump Rope",
     ExerciseTime = "1 minute",
     RestBetweenExercises = "10 seconds",
     ExerciseReps = "N/A"
 }
);
            
        }

    }
}
