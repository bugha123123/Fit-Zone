﻿namespace Instagram_Clone.Models
{
    public class SavedExercise
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

        public string MuscleGroup { get; set; } 
        public bool EquipmentRequired { get; set; }

        public  string SavedBy { get; set; }
    }
}
