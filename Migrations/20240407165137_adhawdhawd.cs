using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Instagram_Clone.Migrations
{
    /// <inheritdoc />
    public partial class adhawdhawd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FinishedExercises",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "UserExerciseState",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BuyDate", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 7, 20, 51, 37, 156, DateTimeKind.Local).AddTicks(4803), new DateTime(2024, 5, 7, 20, 51, 37, 156, DateTimeKind.Local).AddTicks(4946) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserExerciseState",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "FinishedExercises",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BuyDate", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 7, 20, 50, 35, 361, DateTimeKind.Local).AddTicks(4749), new DateTime(2024, 5, 7, 20, 50, 35, 361, DateTimeKind.Local).AddTicks(4764) });
        }
    }
}
