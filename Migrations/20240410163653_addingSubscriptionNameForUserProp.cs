using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Instagram_Clone.Migrations
{
    /// <inheritdoc />
    public partial class addingSubscriptionNameForUserProp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SubscriptionName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BuyDate", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 10, 20, 36, 53, 238, DateTimeKind.Local).AddTicks(2230), new DateTime(2024, 5, 10, 20, 36, 53, 238, DateTimeKind.Local).AddTicks(2243) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SubscriptionName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BuyDate", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 10, 19, 51, 34, 452, DateTimeKind.Local).AddTicks(7932), new DateTime(2024, 5, 10, 19, 51, 34, 452, DateTimeKind.Local).AddTicks(7943) });
        }
    }
}
