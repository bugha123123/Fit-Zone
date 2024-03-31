using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Instagram_Clone.Migrations
{
    /// <inheritdoc />
    public partial class aswdawhdawd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "BoughtSubscriptionName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BuyData", "ExpireDate" },
                values: new object[] { new DateTime(2024, 3, 31, 11, 53, 19, 494, DateTimeKind.Local).AddTicks(9810), new DateTime(2024, 4, 30, 11, 53, 19, 494, DateTimeKind.Local).AddTicks(9819) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "BoughtSubscriptionName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BuyData", "ExpireDate" },
                values: new object[] { new DateTime(2024, 3, 31, 11, 50, 15, 386, DateTimeKind.Local).AddTicks(986), new DateTime(2024, 4, 30, 11, 50, 15, 386, DateTimeKind.Local).AddTicks(997) });
        }
    }
}
