using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Instagram_Clone.Migrations
{
    /// <inheritdoc />
    public partial class REMOVINGSTATEUPDATEFORNOW : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exercises_AspNetUsers_UserId",
                table: "Exercises");

            migrationBuilder.DropIndex(
                name: "IX_Exercises_UserId",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "ExerciseState",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "FinishedByUserId",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "UserProgressInPercentsForParticularExercise",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BuyDate", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 7, 17, 45, 37, 69, DateTimeKind.Local).AddTicks(642), new DateTime(2024, 5, 7, 17, 45, 37, 69, DateTimeKind.Local).AddTicks(651) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ExerciseState",
                table: "Exercises",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "FinishedByUserId",
                table: "Exercises",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Exercises",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserProgressInPercentsForParticularExercise",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ExerciseState", "FinishedByUserId", "UserId" },
                values: new object[] { 0, null, null });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ExerciseState", "FinishedByUserId", "UserId" },
                values: new object[] { 0, null, null });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ExerciseState", "FinishedByUserId", "UserId" },
                values: new object[] { 0, null, null });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ExerciseState", "FinishedByUserId", "UserId" },
                values: new object[] { 0, null, null });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ExerciseState", "FinishedByUserId", "UserId" },
                values: new object[] { 0, null, null });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ExerciseState", "FinishedByUserId", "UserId" },
                values: new object[] { 0, null, null });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ExerciseState", "FinishedByUserId", "UserId" },
                values: new object[] { 0, null, null });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ExerciseState", "FinishedByUserId", "UserId" },
                values: new object[] { 0, null, null });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ExerciseState", "FinishedByUserId", "UserId" },
                values: new object[] { 0, null, null });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ExerciseState", "FinishedByUserId", "UserId" },
                values: new object[] { 0, null, null });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ExerciseState", "FinishedByUserId", "UserId" },
                values: new object[] { 0, null, null });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ExerciseState", "FinishedByUserId", "UserId" },
                values: new object[] { 0, null, null });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ExerciseState", "FinishedByUserId", "UserId" },
                values: new object[] { 0, null, null });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ExerciseState", "FinishedByUserId", "UserId" },
                values: new object[] { 0, null, null });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ExerciseState", "FinishedByUserId", "UserId" },
                values: new object[] { 0, null, null });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ExerciseState", "FinishedByUserId", "UserId" },
                values: new object[] { 0, null, null });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ExerciseState", "FinishedByUserId", "UserId" },
                values: new object[] { 0, null, null });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ExerciseState", "FinishedByUserId", "UserId" },
                values: new object[] { 0, null, null });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ExerciseState", "FinishedByUserId", "UserId" },
                values: new object[] { 0, null, null });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ExerciseState", "FinishedByUserId", "UserId" },
                values: new object[] { 0, null, null });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BuyDate", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 7, 17, 41, 12, 847, DateTimeKind.Local).AddTicks(202), new DateTime(2024, 5, 7, 17, 41, 12, 847, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_UserId",
                table: "Exercises",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Exercises_AspNetUsers_UserId",
                table: "Exercises",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
