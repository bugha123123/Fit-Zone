﻿// <auto-generated />
using System;
using Instagram_Clone.ApplicationDBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Instagram_Clone.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240408161010_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Instagram_Clone.Models.Exercise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("EquipmentRequired")
                        .HasColumnType("bit");

                    b.Property<bool>("ExclusiveContent")
                        .HasColumnType("bit");

                    b.Property<int>("ExerciseCategory")
                        .HasColumnType("int");

                    b.Property<string>("ExerciseImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ExerciseMainFocus")
                        .HasColumnType("int");

                    b.Property<string>("ExerciseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExerciseReps")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExerciseTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MuscleGroup")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RestBetweenExercises")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Exercises");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EquipmentRequired = false,
                            ExclusiveContent = true,
                            ExerciseCategory = 0,
                            ExerciseImage = "/ExerciseImages/PushUp.jpg",
                            ExerciseMainFocus = 0,
                            ExerciseName = "Push-up",
                            ExerciseReps = "15 reps",
                            ExerciseTime = "30",
                            MuscleGroup = "Chest",
                            RestBetweenExercises = "10"
                        },
                        new
                        {
                            Id = 2,
                            EquipmentRequired = false,
                            ExclusiveContent = false,
                            ExerciseCategory = 0,
                            ExerciseImage = "/ExerciseImages/BodyWeightSquat.jpg",
                            ExerciseMainFocus = 1,
                            ExerciseName = "Squats",
                            ExerciseReps = "20 reps",
                            ExerciseTime = "45",
                            MuscleGroup = "Legs",
                            RestBetweenExercises = "15"
                        },
                        new
                        {
                            Id = 3,
                            EquipmentRequired = false,
                            ExclusiveContent = true,
                            ExerciseCategory = 0,
                            ExerciseImage = "/ExerciseImages/Plank.png",
                            ExerciseMainFocus = 0,
                            ExerciseName = "Plank",
                            ExerciseReps = "3",
                            ExerciseTime = "60",
                            MuscleGroup = "Core",
                            RestBetweenExercises = "10"
                        },
                        new
                        {
                            Id = 4,
                            EquipmentRequired = false,
                            ExclusiveContent = false,
                            ExerciseCategory = 0,
                            ExerciseImage = "/ExerciseImages/Lunges.jpg",
                            ExerciseMainFocus = 0,
                            ExerciseName = "Lunges",
                            ExerciseReps = "12 reps per leg",
                            ExerciseTime = "45",
                            MuscleGroup = "Legs",
                            RestBetweenExercises = "10"
                        },
                        new
                        {
                            Id = 5,
                            EquipmentRequired = false,
                            ExclusiveContent = true,
                            ExerciseCategory = 1,
                            ExerciseImage = "/ExerciseImages/Burpees.jpg",
                            ExerciseMainFocus = 0,
                            ExerciseName = "Burpees",
                            ExerciseReps = "12 reps",
                            ExerciseTime = "45",
                            MuscleGroup = "Full Body",
                            RestBetweenExercises = "15"
                        },
                        new
                        {
                            Id = 6,
                            EquipmentRequired = false,
                            ExclusiveContent = false,
                            ExerciseCategory = 1,
                            ExerciseImage = "/ExerciseImages/MountainClimbers.jpg",
                            ExerciseMainFocus = 0,
                            ExerciseName = "Mountain Climbers",
                            ExerciseReps = "20 reps",
                            ExerciseTime = "45",
                            MuscleGroup = "Core",
                            RestBetweenExercises = "10"
                        },
                        new
                        {
                            Id = 7,
                            EquipmentRequired = false,
                            ExclusiveContent = true,
                            ExerciseCategory = 1,
                            ExerciseImage = "/ExerciseImages/Sit-ups.jpg",
                            ExerciseMainFocus = 1,
                            ExerciseName = "Sit-ups",
                            ExerciseReps = "20 reps",
                            ExerciseTime = "60",
                            MuscleGroup = "Core",
                            RestBetweenExercises = "10"
                        },
                        new
                        {
                            Id = 8,
                            EquipmentRequired = false,
                            ExclusiveContent = false,
                            ExerciseCategory = 1,
                            ExerciseImage = "/ExerciseImages/JumpingJacks.jpg",
                            ExerciseMainFocus = 0,
                            ExerciseName = "Jumping Jacks",
                            ExerciseReps = "30 reps",
                            ExerciseTime = "60",
                            MuscleGroup = "Full Body",
                            RestBetweenExercises = "10"
                        },
                        new
                        {
                            Id = 9,
                            EquipmentRequired = false,
                            ExclusiveContent = true,
                            ExerciseCategory = 1,
                            ExerciseImage = "/ExerciseImages/HighKnees.jpg",
                            ExerciseMainFocus = 0,
                            ExerciseName = "High Knees",
                            ExerciseReps = "30 reps",
                            ExerciseTime = "45",
                            MuscleGroup = "Cardio",
                            RestBetweenExercises = "10"
                        },
                        new
                        {
                            Id = 10,
                            EquipmentRequired = false,
                            ExclusiveContent = false,
                            ExerciseCategory = 1,
                            ExerciseImage = "/ExerciseImages/PlankJacks.jpg",
                            ExerciseMainFocus = 0,
                            ExerciseName = "Plank Jacks",
                            ExerciseReps = "20 reps",
                            ExerciseTime = "30",
                            MuscleGroup = "Core",
                            RestBetweenExercises = "10"
                        },
                        new
                        {
                            Id = 11,
                            EquipmentRequired = false,
                            ExclusiveContent = true,
                            ExerciseCategory = 2,
                            ExerciseImage = "/ExerciseImages/RussianTwists.jpg",
                            ExerciseMainFocus = 0,
                            ExerciseName = "Russian Twists",
                            ExerciseReps = "20 reps",
                            ExerciseTime = "60",
                            MuscleGroup = "Core",
                            RestBetweenExercises = "10"
                        },
                        new
                        {
                            Id = 12,
                            EquipmentRequired = false,
                            ExclusiveContent = false,
                            ExerciseCategory = 2,
                            ExerciseImage = "/ExerciseImages/WallSit.jpg",
                            ExerciseMainFocus = 1,
                            ExerciseName = "Wall Sit",
                            ExerciseReps = "N/A",
                            ExerciseTime = "60",
                            MuscleGroup = "Legs",
                            RestBetweenExercises = "10"
                        },
                        new
                        {
                            Id = 13,
                            EquipmentRequired = true,
                            ExclusiveContent = true,
                            ExerciseCategory = 2,
                            ExerciseImage = "/ExerciseImages/TricepDips.jpg",
                            ExerciseMainFocus = 1,
                            ExerciseName = "Tricep Dips",
                            ExerciseReps = "15 reps",
                            ExerciseTime = "45",
                            MuscleGroup = "Arms",
                            RestBetweenExercises = "10"
                        },
                        new
                        {
                            Id = 14,
                            EquipmentRequired = false,
                            ExclusiveContent = false,
                            ExerciseCategory = 2,
                            ExerciseImage = "/ExerciseImages/BicycleCrunches.jpg",
                            ExerciseMainFocus = 0,
                            ExerciseName = "Bicycle Crunches",
                            ExerciseReps = "20 reps",
                            ExerciseTime = "60",
                            MuscleGroup = "Core",
                            RestBetweenExercises = "10"
                        },
                        new
                        {
                            Id = 15,
                            EquipmentRequired = false,
                            ExclusiveContent = true,
                            ExerciseCategory = 2,
                            ExerciseImage = "/ExerciseImages/CalfRaises.jpg",
                            ExerciseMainFocus = 1,
                            ExerciseName = "Calf Raises",
                            ExerciseReps = "20 reps",
                            ExerciseTime = "45",
                            MuscleGroup = "Legs",
                            RestBetweenExercises = "10"
                        },
                        new
                        {
                            Id = 16,
                            EquipmentRequired = true,
                            ExclusiveContent = false,
                            ExerciseCategory = 2,
                            ExerciseImage = "/ExerciseImages/ShoulderPress.jpg",
                            ExerciseMainFocus = 1,
                            ExerciseName = "Shoulder Press",
                            ExerciseReps = "12 reps",
                            ExerciseTime = "45",
                            MuscleGroup = "Shoulders",
                            RestBetweenExercises = "10"
                        },
                        new
                        {
                            Id = 17,
                            EquipmentRequired = false,
                            ExclusiveContent = true,
                            ExerciseCategory = 2,
                            ExerciseImage = "/ExerciseImages/DeadBug.jpg",
                            ExerciseMainFocus = 0,
                            ExerciseName = "Dead Bug",
                            ExerciseReps = "20 reps",
                            ExerciseTime = "60",
                            MuscleGroup = "Core",
                            RestBetweenExercises = "10"
                        },
                        new
                        {
                            Id = 18,
                            EquipmentRequired = false,
                            ExclusiveContent = false,
                            ExerciseCategory = 2,
                            ExerciseImage = "/ExerciseImages/Superman.jpg",
                            ExerciseMainFocus = 1,
                            ExerciseName = "Superman",
                            ExerciseReps = "10",
                            ExerciseTime = "60",
                            MuscleGroup = "Back",
                            RestBetweenExercises = "10"
                        },
                        new
                        {
                            Id = 19,
                            EquipmentRequired = false,
                            ExclusiveContent = true,
                            ExerciseCategory = 2,
                            ExerciseImage = "/ExerciseImages/ReverseCrunches.jpg",
                            ExerciseMainFocus = 0,
                            ExerciseName = "Reverse Crunches",
                            ExerciseReps = "15 reps",
                            ExerciseTime = "45",
                            MuscleGroup = "Core",
                            RestBetweenExercises = "10"
                        },
                        new
                        {
                            Id = 20,
                            EquipmentRequired = false,
                            ExclusiveContent = false,
                            ExerciseCategory = 2,
                            ExerciseImage = "/ExerciseImages/JumpRope.jpg",
                            ExerciseMainFocus = 0,
                            ExerciseName = "Jump Rope",
                            ExerciseReps = "3",
                            ExerciseTime = "60",
                            MuscleGroup = "Cardio",
                            RestBetweenExercises = "10"
                        });
                });

            modelBuilder.Entity("Instagram_Clone.Models.FeedBack", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserFeedBack")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("FeedBacks");
                });

            modelBuilder.Entity("Instagram_Clone.Models.Progress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ExerciseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Points")
                        .HasColumnType("float");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("exerciseState")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Progresss");
                });

            modelBuilder.Entity("Instagram_Clone.Models.SavedExercise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("EquipmentRequired")
                        .HasColumnType("bit");

                    b.Property<bool>("ExclusiveContent")
                        .HasColumnType("bit");

                    b.Property<int>("ExerciseCategory")
                        .HasColumnType("int");

                    b.Property<string>("ExerciseImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ExerciseMainFocus")
                        .HasColumnType("int");

                    b.Property<string>("ExerciseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExerciseReps")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExerciseTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MuscleGroup")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RestBetweenExercises")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SavedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SavedExercises");
                });

            modelBuilder.Entity("Instagram_Clone.Models.Subscription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("BuyDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ExpireDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("PlanPrice")
                        .HasColumnType("float");

                    b.Property<string>("PlanType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Subscriptions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BuyDate = new DateTime(2024, 4, 8, 20, 10, 10, 267, DateTimeKind.Local).AddTicks(3355),
                            ExpireDate = new DateTime(2024, 5, 8, 20, 10, 10, 267, DateTimeKind.Local).AddTicks(3369),
                            PlanPrice = 9.9900000000000002,
                            PlanType = "Basic"
                        });
                });

            modelBuilder.Entity("Instagram_Clone.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("BoughtSubscriptionName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DailyLimit")
                        .HasColumnType("int");

                    b.Property<bool>("DailyLimitExceeded")
                        .HasColumnType("bit");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FitnessLevel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("HasSubscription")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastAddedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("ProfileImageFileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Instagram_Clone.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Instagram_Clone.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Instagram_Clone.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Instagram_Clone.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
