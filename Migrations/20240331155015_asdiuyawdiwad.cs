using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Instagram_Clone.Migrations
{
    /// <inheritdoc />
    public partial class asdiuyawdiwad : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "websiteReviews");

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BuyDate", "ExpireDate" },
                values: new object[] { new DateTime(2024, 3, 31, 19, 50, 14, 838, DateTimeKind.Local).AddTicks(5133), new DateTime(2024, 4, 30, 19, 50, 14, 838, DateTimeKind.Local).AddTicks(5145) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "websiteReviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserRating = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_websiteReviews", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BuyDate", "ExpireDate" },
                values: new object[] { new DateTime(2024, 3, 31, 19, 37, 43, 739, DateTimeKind.Local).AddTicks(6745), new DateTime(2024, 4, 30, 19, 37, 43, 739, DateTimeKind.Local).AddTicks(6755) });
        }
    }
}
