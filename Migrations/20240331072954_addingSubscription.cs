using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Instagram_Clone.Migrations
{
    /// <inheritdoc />
    public partial class addingSubscription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BoughtSubscriptionName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "HasSubscription",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "Subscriptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlanType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlanPrice = table.Column<double>(type: "float", nullable: false),
                    BuyData = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpireDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscriptions", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Subscriptions",
                columns: new[] { "Id", "BuyData", "ExpireDate", "PlanPrice", "PlanType" },
                values: new object[] { 1, new DateTime(2024, 3, 31, 11, 29, 54, 624, DateTimeKind.Local).AddTicks(4703), new DateTime(2024, 4, 30, 11, 29, 54, 624, DateTimeKind.Local).AddTicks(4714), 9.9900000000000002, "Basic" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Subscriptions");

            migrationBuilder.DropColumn(
                name: "BoughtSubscriptionName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "HasSubscription",
                table: "AspNetUsers");
        }
    }
}
