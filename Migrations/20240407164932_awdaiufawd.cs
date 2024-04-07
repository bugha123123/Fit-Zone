using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Instagram_Clone.Migrations
{
    /// <inheritdoc />
    public partial class awdaiufawd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BuyDate", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 7, 20, 49, 32, 324, DateTimeKind.Local).AddTicks(3813), new DateTime(2024, 5, 7, 20, 49, 32, 324, DateTimeKind.Local).AddTicks(3823) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BuyDate", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 7, 20, 41, 15, 783, DateTimeKind.Local).AddTicks(1302), new DateTime(2024, 5, 7, 20, 41, 15, 783, DateTimeKind.Local).AddTicks(1313) });
        }
    }
}
