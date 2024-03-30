using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Instagram_Clone.Migrations
{
    /// <inheritdoc />
    public partial class _12f1f1f12f : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExerciseImage",
                value: "/ExerciseImages/PushUp.jpg");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 2,
                column: "ExerciseImage",
                value: "/ExerciseImages/BodyWeightSquat.jpg");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 3,
                column: "ExerciseImage",
                value: "/ExerciseImages/Plank.png");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 4,
                column: "ExerciseImage",
                value: "/ExerciseImages/Lunges.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExerciseImage",
                value: "~/ExerciseImages/PushUp.jpg");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 2,
                column: "ExerciseImage",
                value: "~/ExerciseImages/BodyWeightSquat.jpg");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 3,
                column: "ExerciseImage",
                value: "~/ExerciseImages/Plank");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 4,
                column: "ExerciseImage",
                value: "~/ExerciseImages/Lunges");
        }
    }
}
