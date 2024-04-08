using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Instagram_Clone.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FitnessLevel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HasSubscription = table.Column<bool>(type: "bit", nullable: false),
                    BoughtSubscriptionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfileImageFileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DailyLimit = table.Column<int>(type: "int", nullable: false),
                    DailyLimitExceeded = table.Column<bool>(type: "bit", nullable: false),
                    LastAddedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Exercises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExerciseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExerciseTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RestBetweenExercises = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExerciseReps = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExerciseImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExerciseCategory = table.Column<int>(type: "int", nullable: false),
                    ExerciseMainFocus = table.Column<int>(type: "int", nullable: false),
                    ExclusiveContent = table.Column<bool>(type: "bit", nullable: false),
                    MuscleGroup = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EquipmentRequired = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercises", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FeedBacks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserFeedBack = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeedBacks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Progresss",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExerciseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Points = table.Column<double>(type: "float", nullable: true),
                    exerciseState = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Progresss", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SavedExercises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExerciseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExerciseTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RestBetweenExercises = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExerciseReps = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExerciseImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExerciseCategory = table.Column<int>(type: "int", nullable: false),
                    ExerciseMainFocus = table.Column<int>(type: "int", nullable: false),
                    ExclusiveContent = table.Column<bool>(type: "bit", nullable: false),
                    MuscleGroup = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EquipmentRequired = table.Column<bool>(type: "bit", nullable: false),
                    SavedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SavedExercises", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subscriptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlanType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlanPrice = table.Column<double>(type: "float", nullable: false),
                    BuyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpireDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscriptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "EquipmentRequired", "ExclusiveContent", "ExerciseCategory", "ExerciseImage", "ExerciseMainFocus", "ExerciseName", "ExerciseReps", "ExerciseTime", "MuscleGroup", "RestBetweenExercises" },
                values: new object[,]
                {
                    { 1, false, true, 0, "/ExerciseImages/PushUp.jpg", 0, "Push-up", "15 reps", "30", "Chest", "10" },
                    { 2, false, false, 0, "/ExerciseImages/BodyWeightSquat.jpg", 1, "Squats", "20 reps", "45", "Legs", "15" },
                    { 3, false, true, 0, "/ExerciseImages/Plank.png", 0, "Plank", "3", "60", "Core", "10" },
                    { 4, false, false, 0, "/ExerciseImages/Lunges.jpg", 0, "Lunges", "12 reps per leg", "45", "Legs", "10" },
                    { 5, false, true, 1, "/ExerciseImages/Burpees.jpg", 0, "Burpees", "12 reps", "45", "Full Body", "15" },
                    { 6, false, false, 1, "/ExerciseImages/MountainClimbers.jpg", 0, "Mountain Climbers", "20 reps", "45", "Core", "10" },
                    { 7, false, true, 1, "/ExerciseImages/Sit-ups.jpg", 1, "Sit-ups", "20 reps", "60", "Core", "10" },
                    { 8, false, false, 1, "/ExerciseImages/JumpingJacks.jpg", 0, "Jumping Jacks", "30 reps", "60", "Full Body", "10" },
                    { 9, false, true, 1, "/ExerciseImages/HighKnees.jpg", 0, "High Knees", "30 reps", "45", "Cardio", "10" },
                    { 10, false, false, 1, "/ExerciseImages/PlankJacks.jpg", 0, "Plank Jacks", "20 reps", "30", "Core", "10" },
                    { 11, false, true, 2, "/ExerciseImages/RussianTwists.jpg", 0, "Russian Twists", "20 reps", "60", "Core", "10" },
                    { 12, false, false, 2, "/ExerciseImages/WallSit.jpg", 1, "Wall Sit", "N/A", "60", "Legs", "10" },
                    { 13, true, true, 2, "/ExerciseImages/TricepDips.jpg", 1, "Tricep Dips", "15 reps", "45", "Arms", "10" },
                    { 14, false, false, 2, "/ExerciseImages/BicycleCrunches.jpg", 0, "Bicycle Crunches", "20 reps", "60", "Core", "10" },
                    { 15, false, true, 2, "/ExerciseImages/CalfRaises.jpg", 1, "Calf Raises", "20 reps", "45", "Legs", "10" },
                    { 16, true, false, 2, "/ExerciseImages/ShoulderPress.jpg", 1, "Shoulder Press", "12 reps", "45", "Shoulders", "10" },
                    { 17, false, true, 2, "/ExerciseImages/DeadBug.jpg", 0, "Dead Bug", "20 reps", "60", "Core", "10" },
                    { 18, false, false, 2, "/ExerciseImages/Superman.jpg", 1, "Superman", "10", "60", "Back", "10" },
                    { 19, false, true, 2, "/ExerciseImages/ReverseCrunches.jpg", 0, "Reverse Crunches", "15 reps", "45", "Core", "10" },
                    { 20, false, false, 2, "/ExerciseImages/JumpRope.jpg", 0, "Jump Rope", "3", "60", "Cardio", "10" }
                });

            migrationBuilder.InsertData(
                table: "Subscriptions",
                columns: new[] { "Id", "BuyDate", "ExpireDate", "PlanPrice", "PlanType" },
                values: new object[] { 1, new DateTime(2024, 4, 8, 20, 10, 10, 267, DateTimeKind.Local).AddTicks(3355), new DateTime(2024, 5, 8, 20, 10, 10, 267, DateTimeKind.Local).AddTicks(3369), 9.9900000000000002, "Basic" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Exercises");

            migrationBuilder.DropTable(
                name: "FeedBacks");

            migrationBuilder.DropTable(
                name: "Progresss");

            migrationBuilder.DropTable(
                name: "SavedExercises");

            migrationBuilder.DropTable(
                name: "Subscriptions");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
