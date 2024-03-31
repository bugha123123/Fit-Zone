using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Instagram_Clone.Migrations
{
    /// <inheritdoc />
    public partial class changingBuyDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BuyData",
                table: "Subscriptions",
                newName: "BuyDate");

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BuyDate", "ExpireDate" },
                values: new object[] { new DateTime(2024, 3, 31, 16, 14, 12, 910, DateTimeKind.Local).AddTicks(4011), new DateTime(2024, 4, 30, 16, 14, 12, 910, DateTimeKind.Local).AddTicks(4023) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BuyDate",
                table: "Subscriptions",
                newName: "BuyData");

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BuyData", "ExpireDate" },
                values: new object[] { new DateTime(2024, 3, 31, 11, 53, 19, 494, DateTimeKind.Local).AddTicks(9810), new DateTime(2024, 4, 30, 11, 53, 19, 494, DateTimeKind.Local).AddTicks(9819) });
        }
    }
}
