namespace Instagram_Clone.Models
{
    public class Exercise
    {

        public int Id { get; set; }

        public string ExerciseName { get; set; }

        public string ExerciseTime { get; set; }

        public string RestBetweenExercises { get; set; }


            public string ExerciseReps { get; set; }

        public string? ExerciseImage { get; set; }

        public ExerciseCategory ExerciseCategory { get; set; }

        public bool ExclusiveContent { get; set; }


    }
}
