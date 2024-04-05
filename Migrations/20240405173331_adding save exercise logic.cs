using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Instagram_Clone.Migrations
{
    /// <inheritdoc />
    public partial class addingsaveexerciselogic : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SavedExercises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExerciseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExerciseTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RestBetweenExercises = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExerciseReps = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExerciseImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExerciseCategory = table.Column<int>(type: "int", nullable: false),
                    ExerciseMainFocus = table.Column<int>(type: "int", nullable: false),
                    ExclusiveContent = table.Column<bool>(type: "bit", nullable: false),
                    MuscleGroup = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EquipmentRequired = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SavedExercises", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BuyDate", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 5, 21, 33, 30, 834, DateTimeKind.Local).AddTicks(5877), new DateTime(2024, 5, 5, 21, 33, 30, 834, DateTimeKind.Local).AddTicks(5890) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SavedExercises");

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BuyDate", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 4, 15, 19, 16, 36, DateTimeKind.Local).AddTicks(4933), new DateTime(2024, 5, 4, 15, 19, 16, 36, DateTimeKind.Local).AddTicks(4943) });
        }
    }
}
