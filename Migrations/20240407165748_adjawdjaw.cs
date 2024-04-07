using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Instagram_Clone.Migrations
{
    /// <inheritdoc />
    public partial class adjawdjaw : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BuyDate", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 7, 20, 57, 47, 921, DateTimeKind.Local).AddTicks(423), new DateTime(2024, 5, 7, 20, 57, 47, 921, DateTimeKind.Local).AddTicks(435) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BuyDate", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 7, 20, 57, 2, 697, DateTimeKind.Local).AddTicks(3106), new DateTime(2024, 5, 7, 20, 57, 2, 697, DateTimeKind.Local).AddTicks(3118) });
        }
    }
}
