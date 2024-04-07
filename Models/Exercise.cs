using System;

namespace Instagram_Clone.Models
{
    public enum ExerciseMainFocus
    {
        LoseWeight,
        GainWeight,
    }


    public class Exercise
    {
        public int Id { get; set; }
        public string ExerciseName { get; set; }
        public string ExerciseTime { get; set; }
        public string RestBetweenExercises { get; set; }
        public string ExerciseReps { get; set; }
        public string? ExerciseImage { get; set; }
        public ExerciseCategory ExerciseCategory { get; set; }
        public ExerciseMainFocus ExerciseMainFocus { get; set; }
        public bool ExclusiveContent { get; set; }

        // Additional properties for filtering
        public string MuscleGroup { get; set; }
        public bool EquipmentRequired { get; set; }

        public int Progress { get; set; } = 0;

        public bool ExerciseFinished { get; set; } = false;
    }
}
