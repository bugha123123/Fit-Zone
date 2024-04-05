using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Instagram_Clone.Migrations
{
    /// <inheritdoc />
    public partial class addingsavedby : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SavedBy",
                table: "SavedExercises",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BuyDate", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 5, 21, 40, 20, 670, DateTimeKind.Local).AddTicks(3751), new DateTime(2024, 5, 5, 21, 40, 20, 670, DateTimeKind.Local).AddTicks(3763) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SavedBy",
                table: "SavedExercises");

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BuyDate", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 5, 21, 33, 30, 834, DateTimeKind.Local).AddTicks(5877), new DateTime(2024, 5, 5, 21, 33, 30, 834, DateTimeKind.Local).AddTicks(5890) });
        }
    }
}
