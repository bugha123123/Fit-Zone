using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Instagram_Clone.Migrations
{
    /// <inheritdoc />
    public partial class addingprops : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DownVote",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "UpVote",
                table: "Exercises");

            migrationBuilder.AddColumn<bool>(
                name: "EquipmentRequired",
                table: "Exercises",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ExerciseMainFocus",
                table: "Exercises",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "MuscleGroup",
                table: "Exercises",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EquipmentRequired", "ExerciseMainFocus", "MuscleGroup" },
                values: new object[] { false, 0, "Chest" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EquipmentRequired", "ExerciseMainFocus", "MuscleGroup" },
                values: new object[] { false, 1, "Legs" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EquipmentRequired", "ExerciseMainFocus", "MuscleGroup" },
                values: new object[] { false, 0, "Core" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EquipmentRequired", "ExerciseMainFocus", "MuscleGroup" },
                values: new object[] { false, 0, "Legs" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EquipmentRequired", "ExerciseMainFocus", "MuscleGroup" },
                values: new object[] { false, 0, "Full Body" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EquipmentRequired", "ExerciseMainFocus", "MuscleGroup" },
                values: new object[] { false, 0, "Core" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EquipmentRequired", "ExerciseMainFocus", "MuscleGroup" },
                values: new object[] { false, 1, "Core" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EquipmentRequired", "ExerciseImage", "ExerciseMainFocus", "MuscleGroup" },
                values: new object[] { false, "/ExerciseImages/JumpingJacks.jpg", 0, "Full Body" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EquipmentRequired", "ExerciseMainFocus", "MuscleGroup" },
                values: new object[] { false, 0, "Cardio" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EquipmentRequired", "ExerciseMainFocus", "MuscleGroup" },
                values: new object[] { false, 0, "Core" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "EquipmentRequired", "ExerciseMainFocus", "MuscleGroup" },
                values: new object[] { false, 0, "Core" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "EquipmentRequired", "ExerciseMainFocus", "MuscleGroup" },
                values: new object[] { false, 1, "Legs" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "EquipmentRequired", "ExerciseMainFocus", "MuscleGroup" },
                values: new object[] { true, 1, "Arms" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "EquipmentRequired", "ExerciseMainFocus", "MuscleGroup" },
                values: new object[] { false, 0, "Core" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "EquipmentRequired", "ExerciseMainFocus", "MuscleGroup" },
                values: new object[] { false, 1, "Legs" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "EquipmentRequired", "ExerciseMainFocus", "MuscleGroup" },
                values: new object[] { true, 1, "Shoulders" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "EquipmentRequired", "ExerciseMainFocus", "MuscleGroup" },
                values: new object[] { false, 0, "Core" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "EquipmentRequired", "ExerciseMainFocus", "MuscleGroup" },
                values: new object[] { false, 1, "Back" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "EquipmentRequired", "ExerciseMainFocus", "MuscleGroup" },
                values: new object[] { false, 0, "Core" });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "EquipmentRequired", "ExerciseMainFocus", "MuscleGroup" },
                values: new object[] { false, 0, "Cardio" });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BuyDate", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 4, 15, 19, 16, 36, DateTimeKind.Local).AddTicks(4933), new DateTime(2024, 5, 4, 15, 19, 16, 36, DateTimeKind.Local).AddTicks(4943) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EquipmentRequired",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "ExerciseMainFocus",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "MuscleGroup",
                table: "Exercises");

            migrationBuilder.AddColumn<string>(
                name: "DownVote",
                table: "Exercises",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpVote",
                table: "Exercises",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DownVote", "UpVote" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DownVote", "UpVote" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DownVote", "UpVote" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DownVote", "UpVote" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DownVote", "UpVote" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DownVote", "UpVote" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DownVote", "UpVote" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DownVote", "ExerciseImage", "UpVote" },
                values: new object[] { null, "/ExerciseImages/Jumping Jacks.jpg", null });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DownVote", "UpVote" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DownVote", "UpVote" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DownVote", "UpVote" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DownVote", "UpVote" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DownVote", "UpVote" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DownVote", "UpVote" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DownVote", "UpVote" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DownVote", "UpVote" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DownVote", "UpVote" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DownVote", "UpVote" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DownVote", "UpVote" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DownVote", "UpVote" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BuyDate", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 4, 12, 44, 35, 183, DateTimeKind.Local).AddTicks(9385), new DateTime(2024, 5, 4, 12, 44, 35, 183, DateTimeKind.Local).AddTicks(9395) });
        }
    }
}
