using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Instagram_Clone.Migrations
{
    /// <inheritdoc />
    public partial class trackinglimit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "DailyLimitExceeded",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastAddedAt",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BuyDate", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 8, 16, 14, 25, 253, DateTimeKind.Local).AddTicks(3061), new DateTime(2024, 5, 8, 16, 14, 25, 253, DateTimeKind.Local).AddTicks(3070) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DailyLimitExceeded",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastAddedAt",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BuyDate", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 8, 16, 5, 0, 882, DateTimeKind.Local).AddTicks(1209), new DateTime(2024, 5, 8, 16, 5, 0, 882, DateTimeKind.Local).AddTicks(1220) });
        }
    }
}
