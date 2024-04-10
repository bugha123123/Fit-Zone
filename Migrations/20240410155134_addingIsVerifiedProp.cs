using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Instagram_Clone.Migrations
{
    /// <inheritdoc />
    public partial class addingIsVerifiedProp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsVerified",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BuyDate", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 10, 19, 51, 34, 452, DateTimeKind.Local).AddTicks(7932), new DateTime(2024, 5, 10, 19, 51, 34, 452, DateTimeKind.Local).AddTicks(7943) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsVerified",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BuyDate", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 8, 21, 11, 58, 254, DateTimeKind.Local).AddTicks(5130), new DateTime(2024, 5, 8, 21, 11, 58, 254, DateTimeKind.Local).AddTicks(5144) });
        }
    }
}
