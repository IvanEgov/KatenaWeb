using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Katena.Migrations
{
    /// <inheritdoc />
    public partial class createMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Action = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Weight = table.Column<double>(type: "double", nullable: false),
                    Weight1 = table.Column<double>(type: "double", nullable: false),
                    Weight2 = table.Column<double>(type: "double", nullable: false),
                    Weight3 = table.Column<double>(type: "double", nullable: false),
                    Weight4 = table.Column<double>(type: "double", nullable: false),
                    Weight5 = table.Column<double>(type: "double", nullable: false),
                    Weight6 = table.Column<double>(type: "double", nullable: false),
                    Weight7 = table.Column<double>(type: "double", nullable: false),
                    Weight8 = table.Column<double>(type: "double", nullable: false),
                    Weight9 = table.Column<double>(type: "double", nullable: false),
                    Weight10 = table.Column<double>(type: "double", nullable: false),
                    Weight11 = table.Column<double>(type: "double", nullable: false),
                    Weight12 = table.Column<double>(type: "double", nullable: false),
                    Weight13 = table.Column<double>(type: "double", nullable: false),
                    Weight14 = table.Column<double>(type: "double", nullable: false),
                    Weight15 = table.Column<double>(type: "double", nullable: false),
                    reasonsId = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedUserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedEmail = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SecurityStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Packs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Instructions = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    QuestionsIds = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ResaultsId = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Packs", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AnswerId = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Reasons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Reason = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Weight = table.Column<double>(type: "double", nullable: false),
                    Weight1 = table.Column<double>(type: "double", nullable: false),
                    Weight2 = table.Column<double>(type: "double", nullable: false),
                    Weight3 = table.Column<double>(type: "double", nullable: false),
                    Weight4 = table.Column<double>(type: "double", nullable: false),
                    Weight5 = table.Column<double>(type: "double", nullable: false),
                    Weight6 = table.Column<double>(type: "double", nullable: false),
                    Weight7 = table.Column<double>(type: "double", nullable: false),
                    Weight8 = table.Column<double>(type: "double", nullable: false),
                    Weight9 = table.Column<double>(type: "double", nullable: false),
                    Weight10 = table.Column<double>(type: "double", nullable: false),
                    Weight11 = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reasons", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Resaults",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Gender = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Style = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Type = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Resault = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resaults", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TextFields",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CodeWord = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Title = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Text = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DateAdded = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TextFields", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderKey = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderDisplayName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "Action", "Weight", "Weight1", "Weight10", "Weight11", "Weight12", "Weight13", "Weight14", "Weight15", "Weight2", "Weight3", "Weight4", "Weight5", "Weight6", "Weight7", "Weight8", "Weight9", "reasonsId" },
                values: new object[,]
                {
                    { new Guid("01786293-47e4-407e-9c24-66591aa9e099"), "Постараюсь, не привлекая внимания окружающих, удалить пятно подручными средствами, а если это не получится, продолжу веселиться вместе с пятном", 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, "[\"f70fca13-268b-4e2e-9906-066b455d2081\",\"c2ea7376-d1fb-466d-91b3-a6efb2fb0063\",\"661db458-5cea-431e-b8ba-6a91ed2854a6\"]" },
                    { new Guid("03b5d02c-aa7f-47b9-8b80-4bd984ce7906"), "Начну искать телефоны снабжающих организаций и выяснять причину отключения", 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, "[\"f70fca13-268b-4e2e-9906-066b455d2081\",\"c2ea7376-d1fb-466d-91b3-a6efb2fb0063\",\"661db458-5cea-431e-b8ba-6a91ed2854a6\"]" },
                    { new Guid("4c748f11-614c-4da8-97f2-eec8dc8ef989"), "Поеду домой переодеваться, а потом вернусь на вечеринку", 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, "[\"f70fca13-268b-4e2e-9906-066b455d2081\",\"c2ea7376-d1fb-466d-91b3-a6efb2fb0063\",\"661db458-5cea-431e-b8ba-6a91ed2854a6\"]" },
                    { new Guid("5ed2804d-bc6a-4296-b9a0-cf720271a18a"), "Накричу на него, заставлю извиняться", 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, "[\"f70fca13-268b-4e2e-9906-066b455d2081\",\"c2ea7376-d1fb-466d-91b3-a6efb2fb0063\",\"661db458-5cea-431e-b8ba-6a91ed2854a6\"]" },
                    { new Guid("6afb4539-1a1c-44d5-ab1e-c8b29fbc2ddc"), "Настроение испорчено, уеду с вечеринки", 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, "[\"f70fca13-268b-4e2e-9906-066b455d2081\",\"c2ea7376-d1fb-466d-91b3-a6efb2fb0063\",\"661db458-5cea-431e-b8ba-6a91ed2854a6\"]" },
                    { new Guid("9102a12d-2845-4224-939e-913ab96524ab"), "Плевать, не велика проблема", 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, "[\"f70fca13-268b-4e2e-9906-066b455d2081\",\"c2ea7376-d1fb-466d-91b3-a6efb2fb0063\",\"661db458-5cea-431e-b8ba-6a91ed2854a6\"]" },
                    { new Guid("cb83a258-54e1-4b2a-a58f-24fe95a357bc"), "Начну звонить соседям и выяснять у всех ли отключили", 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, "[\"f70fca13-268b-4e2e-9906-066b455d2081\",\"c2ea7376-d1fb-466d-91b3-a6efb2fb0063\",\"661db458-5cea-431e-b8ba-6a91ed2854a6\"]" },
                    { new Guid("e82f0359-d505-49f3-9292-f3877a9a844f"), "Это знак свыше, можно никуда сегодня не ходить, пойду спать дальше", 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, "[\"f70fca13-268b-4e2e-9906-066b455d2081\",\"c2ea7376-d1fb-466d-91b3-a6efb2fb0063\",\"661db458-5cea-431e-b8ba-6a91ed2854a6\"]" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e8ec6f61-f6d0-4b1d-bbe4-5910f862b2bd", null, "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ef37a3c2-7c96-4405-a971-7abcc91ac333", 0, "e1445e1a-1e58-4bb4-927a-73ad622ad27e", "my@email.com", true, false, null, "MY@EMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAEH0h2D9hA5rLo2ufr7ca8DfIJFFbdccY3a9qksBPWywn9NUinNdlFy8EsMOWeRyHJQ==", null, false, "", false, "admin" });

            migrationBuilder.InsertData(
                table: "Packs",
                columns: new[] { "Id", "Description", "Instructions", "Name", "QuestionsIds", "ResaultsId" },
                values: new object[] { new Guid("0ed29a4b-ea2d-426d-add2-22753c7bf8cb"), "A good test to get to know yourself", "Think", "Personality test", "[\"0dc6e45e-ba94-4f54-a59e-53caa1eea73c\",\"2b8ad992-d4aa-4c3f-a65e-aaf036260807\"]", "[\"959f07c9-5bd1-402c-9d29-c0cd3b5f954d\",\"cbed2409-359d-4425-9505-7434d6f75d79\",\"6662ee7c-34c8-4811-b3f3-ada6618dc47b\"]" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "AnswerId", "Name" },
                values: new object[,]
                {
                    { new Guid("0dc6e45e-ba94-4f54-a59e-53caa1eea73c"), "[\"cb83a258-54e1-4b2a-a58f-24fe95a357bc\",\"03b5d02c-aa7f-47b9-8b80-4bd984ce7906\",\"9102a12d-2845-4224-939e-913ab96524ab\",\"e82f0359-d505-49f3-9292-f3877a9a844f\"]", "Вы проснулись утром и поняли, что проспали сигнал будильника. Вы стремглав бежите в ванную и обнаруживаете, что в кране нет воды. Ни холодной, ни горячей. Ваши первые действия?" },
                    { new Guid("2b8ad992-d4aa-4c3f-a65e-aaf036260807"), "[\"5ed2804d-bc6a-4296-b9a0-cf720271a18a\",\"4c748f11-614c-4da8-97f2-eec8dc8ef989\",\"01786293-47e4-407e-9c24-66591aa9e099\",\"6afb4539-1a1c-44d5-ab1e-c8b29fbc2ddc\"]", "На корпоративе, к которому вы давно готовились, сосед случайно проливает на вас красное вино. Ваша первая реакция?" }
                });

            migrationBuilder.InsertData(
                table: "Reasons",
                columns: new[] { "Id", "Reason", "Weight", "Weight1", "Weight10", "Weight11", "Weight2", "Weight3", "Weight4", "Weight5", "Weight6", "Weight7", "Weight8", "Weight9" },
                values: new object[,]
                {
                    { new Guid("661db458-5cea-431e-b8ba-6a91ed2854a6"), "Third reason", 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 },
                    { new Guid("c2ea7376-d1fb-466d-91b3-a6efb2fb0063"), "Second reason", 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 },
                    { new Guid("f70fca13-268b-4e2e-9906-066b455d2081"), "Reason", 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Resaults",
                columns: new[] { "Id", "Gender", "Resault", "Style", "Type" },
                values: new object[,]
                {
                    { new Guid("6662ee7c-34c8-4811-b3f3-ada6618dc47b"), "Female", "Strongwomen", "Entrepreneur", "Guardian" },
                    { new Guid("959f07c9-5bd1-402c-9d29-c0cd3b5f954d"), "Male", "Megamen", "Producer", "Mentor" },
                    { new Guid("cbed2409-359d-4425-9505-7434d6f75d79"), "Female", "Megawomen", "Producer", "Mentor" }
                });

            migrationBuilder.InsertData(
                table: "TextFields",
                columns: new[] { "Id", "CodeWord", "DateAdded", "Text", "Title" },
                values: new object[,]
                {
                    { new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"), "PageAbilities", new DateTime(2024, 3, 22, 4, 12, 23, 465, DateTimeKind.Utc).AddTicks(7704), "Содержание заполняется администратором", "Возможности" },
                    { new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"), "PageIndex", new DateTime(2024, 3, 22, 4, 12, 23, 465, DateTimeKind.Utc).AddTicks(7451), "Содержание заполняется администратором", "Главная" },
                    { new Guid("708a31c5-8fb2-4b81-95f1-4f2775271c2a"), "Sidebar", new DateTime(2024, 3, 22, 4, 12, 23, 465, DateTimeKind.Utc).AddTicks(7851), "Содержание заполняется администратором", "Новости" },
                    { new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"), "PageTests", new DateTime(2024, 3, 22, 4, 12, 23, 465, DateTimeKind.Utc).AddTicks(7595), "Содержание заполняется администратором", "Тесты" },
                    { new Guid("8eae0a63-8f52-4160-a14e-b405e431a13b"), "PageContacts", new DateTime(2024, 3, 22, 4, 12, 23, 465, DateTimeKind.Utc).AddTicks(7774), "Содержание заполняется администратором", "Контакты" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e8ec6f61-f6d0-4b1d-bbe4-5910f862b2bd", "ef37a3c2-7c96-4405-a971-7abcc91ac333" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

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
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answers");

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
                name: "Packs");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Reasons");

            migrationBuilder.DropTable(
                name: "Resaults");

            migrationBuilder.DropTable(
                name: "TextFields");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
