using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Instagram_Clone.Migrations
{
    /// <inheritdoc />
    public partial class addingExercises : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Exercises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExerciseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExerciseTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RestBetweenExercises = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExerciseReps = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercises", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "ExerciseName", "ExerciseReps", "ExerciseTime", "RestBetweenExercises" },
                values: new object[,]
                {
                    { 1, "Push-up", "15 reps", "30 seconds", "10 seconds" },
                    { 2, "Squats", "20 reps", "45 seconds", "15 seconds" },
                    { 3, "Plank", "N/A", "1 minute", "10 seconds" },
                    { 4, "Lunges", "12 reps per leg", "45 seconds", "10 seconds" },
                    { 5, "Burpees", "12 reps", "45 seconds", "15 seconds" },
                    { 6, "Mountain Climbers", "20 reps", "45 seconds", "10 seconds" },
                    { 7, "Sit-ups", "20 reps", "1 minute", "10 seconds" },
                    { 8, "Jumping Jacks", "30 reps", "1 minute", "10 seconds" },
                    { 9, "High Knees", "30 reps", "45 seconds", "10 seconds" },
                    { 10, "Plank Jacks", "20 reps", "30 seconds", "10 seconds" },
                    { 11, "Russian Twists", "20 reps", "1 minute", "10 seconds" },
                    { 12, "Wall Sit", "N/A", "1 minute", "10 seconds" },
                    { 13, "Tricep Dips", "15 reps", "45 seconds", "10 seconds" },
                    { 14, "Bicycle Crunches", "20 reps", "1 minute", "10 seconds" },
                    { 15, "Calf Raises", "20 reps", "45 seconds", "10 seconds" },
                    { 16, "Shoulder Press", "12 reps", "45 seconds", "10 seconds" },
                    { 17, "Dead Bug", "20 reps", "1 minute", "10 seconds" },
                    { 18, "Superman", "10", "1 minute", "10 seconds" },
                    { 19, "Reverse Crunches", "15 reps", "45 seconds", "10 seconds" },
                    { 20, "Jump Rope", "N/A", "1 minute", "10 seconds" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Exercises");
        }
    }
}
