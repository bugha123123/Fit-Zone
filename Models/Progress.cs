namespace Instagram_Clone.Models
{
    public class Progress
    {
        public enum ExerciseState
        {
            JustStarted,
            Finished,
            Halfway
        }

        public int Id { get; set; }
        public string UserId { get; set; }
        public string ExerciseName { get; set; }
        public double? Points { get; set; } = 0;
        public ExerciseState exerciseState { get; set; } = ExerciseState.JustStarted;
    }
}
