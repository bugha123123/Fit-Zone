using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Instagram_Clone.Migrations
{
    /// <inheritdoc />
    public partial class addingprofileimageupload : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProfileImageFileName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BuyDate", "ExpireDate" },
                values: new object[] { new DateTime(2024, 3, 31, 16, 37, 1, 457, DateTimeKind.Local).AddTicks(2303), new DateTime(2024, 4, 30, 16, 37, 1, 457, DateTimeKind.Local).AddTicks(2313) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfileImageFileName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BuyDate", "ExpireDate" },
                values: new object[] { new DateTime(2024, 3, 31, 16, 14, 12, 910, DateTimeKind.Local).AddTicks(4011), new DateTime(2024, 4, 30, 16, 14, 12, 910, DateTimeKind.Local).AddTicks(4023) });
        }
    }
}
