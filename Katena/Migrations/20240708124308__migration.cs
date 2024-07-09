using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Katena.Migrations
{
    /// <inheritdoc />
    public partial class _migration : Migration
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
                    Weight = table.Column<int>(type: "int", nullable: false),
                    Weight1 = table.Column<int>(type: "int", nullable: false),
                    Weight2 = table.Column<int>(type: "int", nullable: false),
                    Weight3 = table.Column<int>(type: "int", nullable: false),
                    Weight4 = table.Column<int>(type: "int", nullable: false),
                    Weight5 = table.Column<int>(type: "int", nullable: false),
                    Weight6 = table.Column<int>(type: "int", nullable: false),
                    Weight7 = table.Column<int>(type: "int", nullable: false),
                    Weight8 = table.Column<int>(type: "int", nullable: false),
                    Weight9 = table.Column<int>(type: "int", nullable: false),
                    Weight10 = table.Column<int>(type: "int", nullable: false),
                    Weight11 = table.Column<int>(type: "int", nullable: false),
                    Weight12 = table.Column<int>(type: "int", nullable: false),
                    Weight13 = table.Column<int>(type: "int", nullable: false),
                    Weight14 = table.Column<int>(type: "int", nullable: false),
                    Weight15 = table.Column<int>(type: "int", nullable: false),
                    typeWeight1 = table.Column<int>(type: "int", nullable: false),
                    typeWeight2 = table.Column<int>(type: "int", nullable: false),
                    typeWeight3 = table.Column<int>(type: "int", nullable: false),
                    typeWeight4 = table.Column<int>(type: "int", nullable: false),
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
                name: "News",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Title = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Text = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TitleImagePath = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Packs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Instructions = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TitleImagePath = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    QuestionsIds = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ResaultsId = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Background = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Pictures = table.Column<string>(type: "longtext", nullable: true)
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
                    AnswerId = table.Column<string>(type: "longtext", nullable: true)
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
                    Weight = table.Column<int>(type: "int", nullable: false),
                    Weight1 = table.Column<int>(type: "int", nullable: false),
                    Weight2 = table.Column<int>(type: "int", nullable: false),
                    Weight3 = table.Column<int>(type: "int", nullable: false),
                    Weight4 = table.Column<int>(type: "int", nullable: false),
                    Weight5 = table.Column<int>(type: "int", nullable: false),
                    Weight6 = table.Column<int>(type: "int", nullable: false),
                    Weight7 = table.Column<int>(type: "int", nullable: false),
                    Weight8 = table.Column<int>(type: "int", nullable: false),
                    Weight9 = table.Column<int>(type: "int", nullable: false),
                    Weight10 = table.Column<int>(type: "int", nullable: false),
                    Weight11 = table.Column<int>(type: "int", nullable: false),
                    Weight12 = table.Column<int>(type: "int", nullable: false),
                    Weight13 = table.Column<int>(type: "int", nullable: false),
                    Weight14 = table.Column<int>(type: "int", nullable: false),
                    typeWeight1 = table.Column<int>(type: "int", nullable: false),
                    typeWeight2 = table.Column<int>(type: "int", nullable: false),
                    typeWeight3 = table.Column<int>(type: "int", nullable: false),
                    typeWeight4 = table.Column<int>(type: "int", nullable: false),
                    typeWeight5 = table.Column<int>(type: "int", nullable: false),
                    typeWeight6 = table.Column<int>(type: "int", nullable: false),
                    typeWeight7 = table.Column<int>(type: "int", nullable: false),
                    typeWeight8 = table.Column<int>(type: "int", nullable: false),
                    typeWeight9 = table.Column<int>(type: "int", nullable: false),
                    typeWeight10 = table.Column<int>(type: "int", nullable: false)
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
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TrigerImage = table.Column<string>(type: "longtext", nullable: true)
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
                    TitleImagePath = table.Column<string>(type: "longtext", nullable: true)
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
                columns: new[] { "Id", "Action", "Weight", "Weight1", "Weight10", "Weight11", "Weight12", "Weight13", "Weight14", "Weight15", "Weight2", "Weight3", "Weight4", "Weight5", "Weight6", "Weight7", "Weight8", "Weight9", "reasonsId", "typeWeight1", "typeWeight2", "typeWeight3", "typeWeight4" },
                values: new object[,]
                {
                    { new Guid("0033a8fa-5096-4218-88b5-e982ae9cf885"), "Предложу ему свою помощь", 1, 0, 1, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 1, 1, 1, "[\"542c5b83-3d7a-4157-804a-fec7c7f32c17\",\"f8dfade8-1e5a-4b5b-b866-0b5c3953fd76\",\"0bfc79dd-5bb0-4817-ba21-0ba838c9b545\"]", 0, 0, 0, 0 },
                    { new Guid("01786293-47e4-407e-9c24-66591aa9e099"), "Постараюсь, не привлекая внимания окружающих, удалить пятно подручными средствами, а если это не получится, продолжу веселиться вместе с пятном", 1, 0, 0, 0, 0, 1, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1, "[\"0ba6f7c0-cd20-48dc-836c-f3ddc825605a\",\"c97493b0-9616-4f2d-8f24-773f51f60dd6\",\"ce8e5fbd-138c-4370-a9f1-bb5543f10bcf\"]", 0, 0, 0, 0 },
                    { new Guid("03b5d02c-aa7f-47b9-8b80-4bd984ce7906"), "Начну искать телефоны снабжающих организаций и выяснять причину отключения", 1, 0, 0, 1, 0, 1, 0, 0, 1, 1, 0, 0, 1, 0, 1, 1, "[\"97d69ebb-66ae-412c-8ccc-dfdc910e080b\",\"a3f7aa1a-fd06-48ba-9427-21f7e6503bab\",\"5127c013-8026-430c-9773-fffec765e49f\"]", 0, 0, 0, 0 },
                    { new Guid("0602c2f0-826b-499f-8248-68563ae32729"), "Напишу жалобу куда следует", 1, 0, 0, 1, 0, 1, 0, 0, 1, 1, 0, 0, 1, 0, 1, 1, "[\"b3d2b465-6c85-469e-831c-40c1317baa95\",\"89c19957-d134-48c4-a628-d4e8c9dae98c\",\"82fcd984-f475-42b2-bacc-2c948001c01c\"]", 0, 0, 0, 0 },
                    { new Guid("081ce27a-1ea3-4af4-8faf-57a4bbedb888"), "Вмешаюсь в процесс продажи и постараюсь не допустить инцидента", 1, 1, 1, 1, 0, 0, 1, 0, 0, 1, 0, 1, 0, 0, 1, 0, "[\"1ceb5f0e-363d-4eec-8c04-c9b078f3a8da\",\"000a06a1-4cd6-4d85-8347-8eb5f5f2aa85\",\"69114935-091c-4c7a-825f-bde4a2efd381\"]", 0, 0, 0, 0 },
                    { new Guid("0a3da123-ff86-4f54-9a96-83ed4258a4a7"), "Как много творится страшного в этом мире", 0, 0, 1, 1, 1, 1, 1, 0, 0, 1, 1, 0, 0, 0, 0, 1, "[\"f481437f-5d66-4183-b041-f60302ac0fa2\",\"bf265f0c-bdba-42e9-9d02-039ed2d98b2e\",\"256658ef-f816-48f7-a6bf-6a70ac079b47\"]", 0, 0, 0, 0 },
                    { new Guid("0c5ba408-6941-4f62-a216-1376625cad92"), "Я вкусный, свежий и душистый хлеб с красивой золотистой корочкой. И будь, что будет!", 1, 0, 0, 1, 0, 1, 0, 0, 1, 1, 0, 0, 1, 0, 1, 1, "[\"8502cde7-19a4-4535-b5f4-e1de7d85660e\",\"87313919-1f8e-4ccd-bf1f-ab86120fed88\",\"18e43e9d-eb02-4075-9076-b26b3803c963\"]", 0, 0, 0, 0 },
                    { new Guid("0e2bc63b-4249-438f-ab4c-ed52551de3f6"), "Я - не хлеб, и никогда им не буду!", 0, 1, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, "[\"6378221f-b3cc-478a-be4d-9aa76a443872\",\"5a3d67d7-08d3-4656-bc21-833842100b03\",\"f70515d3-c89c-42f1-81be-47de0db3143e\"]", 0, 0, 0, 0 },
                    { new Guid("0f3e9b80-9ca9-49d4-b825-526f99fa6177"), "Промолчу, но постараюсь как можно реже посещать данный магазин", 0, 0, 1, 0, 1, 1, 1, 1, 0, 0, 1, 0, 0, 1, 0, 1, "[\"770ae718-1ac8-4975-ad4e-5be8f0c747e0\",\"191565ba-f698-44eb-bf55-9db48c0ad9a7\",\"466a8851-1cd3-453f-89bf-d728ebc07d00\"]", 0, 0, 0, 0 },
                    { new Guid("0f6e2260-ef66-4da1-9e5a-c0c6802ab24b"), "Люди даже не представляют, какой ящик Пандоры они открывают!", 0, 0, 0, 1, 1, 1, 0, 0, 1, 1, 1, 0, 1, 0, 0, 1, "[\"60e556cd-e2f0-44e0-885a-37cf26e373bd\",\"a169eb49-7103-4eb9-b23c-1f8f5722550d\",\"7557a105-a89c-4420-9d90-4b51854c4a2d\"]", 0, 0, 0, 0 },
                    { new Guid("10fc872b-81ff-488b-a4e3-a83e20399575"), "Что-то новое всегда пробивается через череду ошибок", 1, 0, 0, 1, 0, 1, 0, 0, 1, 1, 0, 0, 1, 0, 1, 1, "[\"5e792610-baa6-4dc5-bc05-2a3bb131b0fd\",\"6f8f4142-33eb-4fe9-95e2-f73e7570671a\",\"7c151077-39a0-4ced-bd8c-9303de968ead\"]", 0, 0, 0, 0 },
                    { new Guid("1431e81d-95d2-4e75-98f2-583c0f42a2e9"), "Ничего не буду предпринимать. Это не моё дело", 1, 1, 1, 1, 0, 0, 1, 0, 0, 1, 0, 1, 0, 0, 1, 0, "[\"968de2eb-4bde-422c-8ce2-59a71b9b1936\",\"67a0d081-2b25-4db0-b150-1f1f3ad7dd9a\",\"d3568b6a-c200-476d-8292-a2d227b81320\"]", 0, 0, 0, 0 },
                    { new Guid("22db7305-82f0-4db2-8725-a02b8c63b263"), "Громко выругаюсь, но преследовать наглеца не буду", 1, 0, 1, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 1, 1, 1, "[\"15f35581-9ca5-4622-a5e6-d784925e7124\",\"3ef4e2c9-746e-4ec9-9ad7-a3023f8c51bd\",\"8eb4aedb-7de1-4b4d-b2fe-2298b08aca6b\"]", 0, 0, 0, 0 },
                    { new Guid("260ee899-5854-43c2-b1c0-a20161583216"), "Скорей всего, отвечу взаимностью, если человек мне симпатичен", 1, 0, 1, 1, 0, 1, 0, 1, 1, 1, 0, 0, 1, 0, 0, 0, "[\"cb9a9358-434f-4f99-ba79-78e5c9dc2953\",\"25dbf84c-5371-44b9-ba26-f6f17cb9f5fe\",\"f1e3ce54-dca2-4f95-a5d3-281107afef9e\"]", 0, 0, 0, 0 },
                    { new Guid("26cb16cd-0cd8-48b4-a13d-2551eead53cb"), "Все войны из-за больших денег", 1, 0, 0, 1, 0, 1, 0, 0, 1, 1, 0, 0, 1, 0, 1, 1, "[\"76548bc2-eaea-441d-85ab-8630e3a28646\",\"6087eac5-ac4e-41b0-a42b-158636cef8d9\",\"cac0e665-9992-4fc0-b98a-c4c2106a4e3f\"]", 0, 0, 0, 0 },
                    { new Guid("27a779a0-5338-4b62-bc46-93484d7164b5"), "Попробую мягко поговорить с ней, чтобы она так не делала", 0, 0, 0, 0, 1, 1, 0, 1, 1, 0, 1, 0, 1, 1, 0, 1, "[\"48b9f840-94b7-47c6-9af1-80284b5aa770\",\"c20b6825-163e-4b40-8624-5fbd491477a1\",\"67a8eb08-f9a9-4426-8e15-5b2f6f70d117\"]", 0, 0, 0, 0 },
                    { new Guid("2f008483-6354-4f50-a434-4cf925415568"), "Надо будет изучить этот вопрос подробнее", 0, 0, 0, 0, 1, 1, 0, 1, 1, 0, 1, 0, 1, 1, 0, 1, "[\"cd87c258-cf5e-4e0e-9f8b-cf01c82ec880\",\"6dd0cd41-c1a9-4c26-be6b-57391cadb830\",\"f83b28c3-c12c-4097-99d6-58da46f6bd9f\"]", 0, 0, 0, 0 },
                    { new Guid("352e1ae9-486c-4120-b397-00c61d7dc3d9"), "При удобном случае поставлю его на место перед руководством", 0, 0, 0, 1, 1, 1, 0, 0, 1, 1, 1, 0, 1, 0, 0, 1, "[\"9d2ca57a-ff4b-46d5-ad6b-14416412efcb\",\"a62254af-21fe-4cca-95cb-9cc5b5aced2b\",\"1d033778-3762-4c22-90a0-51c826dac17d\"]", 0, 0, 0, 0 },
                    { new Guid("35aaade3-98b1-4a06-9e0e-e0d729b623b7"), "Буду давить на руководство, чтоб они решили эту проблему в срочном порядке", 1, 0, 0, 1, 0, 1, 0, 0, 1, 1, 0, 0, 1, 0, 1, 1, "[\"b925a8e2-9ec2-43bb-b96c-8587d43b2068\",\"a72bf684-2ba3-4523-b398-2fbbd1b15bcb\",\"4714c535-2e82-4bf8-8ffe-aab2a7ebfabb\"]", 0, 0, 0, 0 },
                    { new Guid("4c748f11-614c-4da8-97f2-eec8dc8ef989"), "Поеду домой переодеваться, а потом вернусь на вечеринку", 1, 0, 0, 0, 0, 1, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1, "[\"da5ff667-d385-48fa-951d-6ce8e7fd08bf\",\"20cf563d-bfc5-4c15-aa70-ee91e0de167f\",\"e50ee429-61ab-42e3-99ff-4e7799e0510c\"]", 0, 0, 0, 0 },
                    { new Guid("56932023-6769-4dc2-8680-484b70e3939a"), "Сфотографирую этот бардак и, скорей всего, пожалуюсь куда следует", 1, 0, 0, 1, 0, 1, 0, 0, 1, 1, 0, 0, 1, 0, 1, 1, "[\"b2efdd67-6c98-49b0-9cc6-bf09b3b27bfa\",\"b1fa7309-783b-48b5-b68a-75bacb94d6a0\",\"ccb12853-2446-4b42-9581-16db2853f079\"]", 0, 0, 0, 0 },
                    { new Guid("5701ccd4-414d-4b9d-af8c-86deb1a56e45"), "Поищу другой контейнер", 1, 0, 1, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 1, 1, 1, "[\"4009ec61-081a-4cf1-ab46-f922edc46b1b\",\"01d2e676-63fd-4a93-8ee3-9c4841a23ad1\",\"4dd0651c-3029-4d51-8fcd-46728f49c125\"]", 0, 0, 0, 0 },
                    { new Guid("58a477c8-22e1-4a5a-8b7a-4ab38ef2c2a1"), "Сообщу о нарушении в компетентные органы и, возможно даже, направлю запись с видеорегистратора ", 0, 1, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, "[\"2735e1da-4808-4b2f-b49b-9121d9bc5417\",\"007daed2-2d3b-49a4-ad0c-d7040d4f7b7c\",\"1450b793-fcc6-4402-bcc0-c91b8631cbfc\"]", 0, 0, 0, 0 },
                    { new Guid("5cb42bbb-0248-4bfb-a42d-8525e2c3ad70"), "Останусь после работы и уберусь. Хотя бы вокруг своего рабочего места ", 1, 1, 0, 1, 0, 0, 0, 0, 1, 1, 0, 1, 1, 0, 1, 0, "[\"bffe1e1e-7921-4a17-81f8-bf30437b6ccc\",\"462fc8be-9bff-416e-b548-cb8f5b127268\",\"314814f8-f740-4e85-b86c-c2b08cc82679\"]", 0, 0, 0, 0 },
                    { new Guid("5ed2804d-bc6a-4296-b9a0-cf720271a18a"), "Накричу на него, заставлю извиняться", 1, 1, 1, 1, 0, 0, 1, 0, 0, 1, 0, 1, 0, 0, 1, 0, "[\"5127c013-8026-430c-9773-fffec765e49f\",\"eb49fb72-769c-4cc5-b38d-fa253263f73a\",\"22a4c268-78c2-4888-8680-e903f4419440\"]", 0, 0, 0, 0 },
                    { new Guid("6586fff5-1f69-4c6a-871a-5330011cd084"), "Не буду никак реагировать. Пусть все развивается само собой", 1, 1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 0, 0, 1, 0, "[\"7bd9eaa0-e33c-4f02-a022-5be616e79ce8\",\"f223da69-63f6-468d-b25e-279fd8f11d7b\",\"ca7cfe1e-332c-413a-8ddc-64db7a2642d2\"]", 0, 0, 0, 0 },
                    { new Guid("6afb4539-1a1c-44d5-ab1e-c8b29fbc2ddc"), "Настроение испорчено, уеду с вечеринки", 1, 1, 0, 1, 0, 0, 0, 0, 1, 1, 0, 1, 1, 0, 1, 0, "[\"d07501c8-e224-4500-87a9-2d1d75c3cc48\",\"4c594e6d-9108-481e-b0bf-2343970b731f\",\"1ca5ebc2-35ec-4784-8523-d62fcbbf2f4c\"]", 0, 0, 0, 0 },
                    { new Guid("6ca56951-b7c8-4fc5-ae95-d308cbb9606b"), "Прикинусь черствым и невкусным", 1, 1, 0, 0, 0, 0, 0, 1, 1, 0, 0, 1, 1, 1, 1, 0, "[\"eff0158e-f158-4e0f-81c9-5f5c62326cf3\",\"bb6d3939-359f-464a-af39-820c1cf5188a\",\"94141d88-aeb5-4c21-9d20-22e50879a756\"]", 0, 0, 0, 0 },
                    { new Guid("7cb16f18-ebd1-4835-ab50-92bedbe2e56c"), "Поеду дальше, как ни в чем не бывало", 1, 0, 1, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 1, 1, 1, "[\"cb49c8e2-ff11-4e2e-ac7d-181d9f588223\",\"852df161-1900-4e68-8445-9451296d2d67\",\"9f39e031-554e-4edb-a1c7-00216ce24cc5\"]", 0, 0, 0, 0 },
                    { new Guid("87b20356-54b0-4b72-9281-e5a300580f2b"), "Положу мусор рядом с контейнерами", 1, 1, 1, 1, 0, 0, 1, 0, 0, 1, 0, 1, 0, 0, 1, 0, "[\"ef3eff5f-9193-44fa-8ee4-95d8885d9cd5\",\"3ed7376c-35fb-41f8-a2ca-0778f6f8ba06\",\"9fe0df1f-8a80-4368-9150-852e4a5441dd\"]", 0, 0, 0, 0 },
                    { new Guid("9102a12d-2845-4224-939e-913ab96524ab"), "Плевать, не велика проблема", 0, 1, 1, 0, 1, 0, 1, 1, 0, 0, 1, 1, 0, 1, 0, 0, "[\"2f63ea8f-38e3-4e40-87aa-9cd1af13c882\",\"adc457f7-cb29-4fe1-838e-9a8038c0aa58\",\"56455b12-df9c-4db6-862f-577b05cf24e6\"]", 0, 0, 0, 0 },
                    { new Guid("a011f3b9-c355-43a7-8840-41d32b3cc0f5"), "Ну и пусть себе разгорается, ни первый и не последний", 1, 1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 0, 1, 1, 0, "[\"56bcf2b7-0f52-443e-a955-332832eb9e34\",\"df6d9cc1-5bb2-4271-b1b7-574c951840da\",\"38dc2cdc-59be-4676-9126-40afb29596a2\"]", 0, 0, 0, 0 },
                    { new Guid("ac212308-36a3-4810-8948-9c3b973838a2"), "Организую субботник, постараюсь вовлечь всех в этот процесс", 1, 0, 0, 1, 0, 1, 0, 0, 1, 1, 0, 0, 1, 0, 1, 1, "[\"b720be24-7f05-4b84-b916-615099596d71\",\"fdaff6ee-c481-45c5-bf2c-98fec53c8640\",\"a647e8f1-9eb2-46b0-a86b-8ecf338ba124\"]", 0, 0, 0, 0 },
                    { new Guid("bc99bedd-0c29-43a2-834e-b7cb53dfb462"), "Очень сильно напугаюсь. Надеюсь, что мокрый хлеб есть не будут", 0, 0, 1, 1, 1, 1, 1, 0, 0, 1, 1, 0, 0, 0, 0, 1, "[\"380c9dc0-f8fb-4b2e-8aa5-548c5ea43a67\",\"1b849154-df58-440b-a6f5-b1005e1b8483\",\"d4eb06ea-6c59-4a7a-8bbb-7adf041ce4c8\"]", 0, 0, 0, 0 },
                    { new Guid("c2c60436-e42c-440f-a0d5-9b2266655cdb"), "Брошу в багажник и выброшу в контейнер возле работы", 1, 0, 0, 1, 0, 1, 0, 0, 1, 1, 0, 0, 1, 0, 1, 1, "[\"4009ec61-081a-4cf1-ab46-f922edc46b1b\",\"01d2e676-63fd-4a93-8ee3-9c4841a23ad1\",\"4dd0651c-3029-4d51-8fcd-46728f49c125\"]", 0, 0, 0, 0 },
                    { new Guid("c8458104-a5f3-46bb-bda8-859f6826662e"), "Пусть все идет, как идет. Что, мне больше всех надо?", 0, 1, 1, 0, 1, 0, 1, 1, 0, 0, 1, 1, 0, 1, 0, 0, "[\"07c4753f-0e75-4516-b222-99ccf583cb1f\",\"d647ba58-9482-43ce-830f-7d8ce0f917ed\",\"a48abfe5-42c4-472a-b97e-f52dba9b6da6\"]", 0, 0, 0, 0 },
                    { new Guid("c9bbd0e8-b648-419b-8bc8-c8dc6d0f2732"), "Буду вспоминать, не живет ли кто поблизости из моих знакомых", 0, 0, 0, 0, 1, 1, 0, 1, 1, 0, 1, 0, 1, 1, 0, 1, "[\"3bed62f7-0488-4f66-9020-588d2d048f48\",\"f908af7a-2f84-4fdf-a400-1510a68c62b8\",\"7c2eb83e-5d2e-4f99-a34f-fb269d2dd482\"]", 0, 0, 0, 0 },
                    { new Guid("cb83a258-54e1-4b2a-a58f-24fe95a357bc"), "Начну звонить соседям и выяснять у всех ли отключили", 1, 0, 0, 0, 0, 1, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1, "[\"661db458-5cea-431e-b8ba-6a91ed2854a6\",\"c2ea7376-d1fb-466d-91b3-a6efb2fb0063\",\"f70fca13-268b-4e2e-9906-066b455d2081\"]", 0, 0, 0, 0 },
                    { new Guid("d33624b4-49b2-46c3-a2f0-b30a0abcb1e8"), "Догоню его и постараюсь поставить на место", 1, 1, 0, 1, 0, 0, 0, 0, 1, 1, 0, 1, 1, 0, 1, 0, "[\"1013fefd-d505-4b34-bef2-3c08e83f5030\",\"9b024278-7390-4678-9d0b-bdd93cc7d8a6\",\"800651bd-3270-4e0c-b65a-7fabdfbfb81f\"]", 0, 0, 0, 0 },
                    { new Guid("d518b8ae-1c2c-49fb-8053-b7dac72f60bb"), "Позлорадствую над происходящим, чувствуя своё превосходство", 1, 1, 1, 1, 0, 0, 1, 0, 0, 1, 0, 1, 0, 0, 1, 0, "[\"86f2026a-30bf-44b2-8483-12745611937d\",\"c325ad59-ce45-4225-b563-bcc74c529ced\",\"24673a02-eb1d-403d-9668-fe0187654b0d\"]", 0, 0, 0, 0 },
                    { new Guid("d9ca6c53-525c-4a1e-8d57-07b24a6f6655"), "Буду делать вид, что ничего не происходит", 0, 1, 1, 0, 1, 0, 1, 1, 0, 0, 1, 1, 0, 1, 0, 0, "[\"523db197-19ee-43a2-9438-0fffe55341fa\",\"c59dd14c-0cd9-4b38-9ac6-b2fc7e49ad45\",\"95b174c0-a5b3-4134-85f9-2f94467b23c1\"]", 0, 0, 0, 0 },
                    { new Guid("e82f0359-d505-49f3-9292-f3877a9a844f"), "Это знак свыше, можно никуда сегодня не ходить, пойду спать дальше", 0, 1, 1, 0, 1, 0, 1, 1, 0, 0, 1, 1, 0, 1, 0, 0, "[\"c5018ed3-8b72-4f59-8f82-0fcfe0dcdb91\",\"b56c26c6-2de6-468c-98e2-dfc5fc35c436\",\"9fe7069a-f8a9-48ae-b63e-68e0ad6e683a\"]", 0, 0, 0, 0 },
                    { new Guid("ecba0443-d733-4a15-9791-bc62cd6d2a7e"), "Меня это вообще никак не касается, я далёк от этого", 0, 1, 1, 1, 1, 0, 1, 0, 0, 1, 1, 1, 0, 0, 0, 0, "[\"d1078e15-f779-452e-b72c-fde1b835c639\",\"35035162-c41a-47c9-aa9f-0d6b7cf16b60\",\"ac770c37-03bc-40d4-9ac1-8067134763d9\"]", 0, 0, 0, 0 },
                    { new Guid("efb2240f-df9f-40da-bf19-c4da4a518034"), "Выскажу ей в резкой форме свое негодование и, возможно даже, пригрожу жалобой руководству", 1, 0, 0, 1, 0, 1, 0, 0, 1, 1, 0, 0, 1, 0, 1, 1, "[\"c5e88078-2957-4255-9f69-209868b59cbc\",\"d578a565-d33c-4f77-abad-d9a7b0c6f748\",\"4e0eb8ed-e5e7-4b4c-b2c8-3fc4dc68e74b\"]", 0, 0, 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e8ec6f61-f6d0-4b1d-bbe4-5910f862b2bd", null, "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ef37a3c2-7c96-4405-a971-7abcc91ac333", 0, "4da12655-adef-4b95-9546-5078f71eb0f7", "my@email.com", true, false, null, "MY@EMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAED9R0j0kX3vsOprvsxJopdpSFuFiwNzOacsl9HYhOUnq77qMcGRE1tMu/j0WU+k38Q==", null, false, "", false, "admin" });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "Text", "Title", "TitleImagePath" },
                values: new object[,]
                {
                    { new Guid("37854340-aff6-40ea-9dd6-94e9ad97cf55"), "Заполянем базу данных", "Новость дня 15.04,2024", "2f9a623372f47bb6a0fc9b42c87bde91.jpg" },
                    { new Guid("46e35b8c-a92b-49ef-b6d0-e37da788a11f"), "Курс молодого бойца. Наводнение продолжается!!!", "Новость дня 16.04.2024", "11c53ebb6fe575943e75dca3a72b0bf9.jpg" },
                    { new Guid("59373bbe-4b39-44da-88d7-ccb9f3903766"), "Очередное заполнение БД и тестирование новостей", "Новость дня 17.04.2024", "2f9a623372f47bb6a0fc9b42c87bde91.jpg" },
                    { new Guid("8b565c49-447f-45d2-91ed-26558438bad9"), "Теперь можно добавлять картинки!", "Новость дня", "" },
                    { new Guid("c602e649-6760-4721-ad34-aa32e4c7df63"), "Было собраноо уже 6 вопросов", "Новость полудня", "2f9a623372f47bb6a0fc9b42c87bde91.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Packs",
                columns: new[] { "Id", "Background", "Description", "Instructions", "Name", "Pictures", "QuestionsIds", "ResaultsId", "TitleImagePath" },
                values: new object[] { new Guid("eb79ddbd-e199-436d-a722-ee2e6e87b8c3"), "background1,background2,background3,background4,background5,background6,background7,background8,background9,background10,background11,background12", "Этот тест предназначен для лучшей  жизни ))", "Рекомендации по прохождению тестирования.\r\n1. Прохождение теста займет не более 15-20 минут. Постарайтесь найти время, чтобы вас никто не отвлекал от прохождения теста. По возможности, выключите телефон и минимизируйте посторонние шумы. \r\n2. Перед прохождением теста найдите 1-2 минуты, чтобы расслабиться и привести мысли в порядок.\r\n3. Если ни один из предлагаемых ответов на поставленные в тесте вопросы полностью не совпадает с вашим, то выбирайте ответ, наиболее близкий к вашему ощущению.\r\n4. Если вы ни разу не попадали в ситуацию, описанную в вопросе теста, то руководствуйтес своими ощущениями, как если бы вы в ней оказались.\r\n5. В целом, прохождение теста не должно вызывать сложности, но мы рекомендуем ознакомиться с нижеприведенным алгоритмом. \r\nАлгоритм прохождения теста.\r\n1. Если вы - женщина, то перейдите во вкладку \"Тест Женщины\". Если вы - мужчина, то, соответственно, перейдите во вкладку \"Тест Мужчины\"\r\n2. Прочитайте вопрос и выберите один из четырёх вариантов ответов, расположенных сразу под вопросом, справа от ячейки \"Действие\". Под выбранным ответом, в ячейке, окрашенной серым цветом поставьте \"1\" или выберите \"1\" из выпадающего списка, нажав на стрелочку в правом нижнем углу выбранной ячейки (примечание: ячейка запрограммирована таким образом, что другую цифру поставить не даст).\r\nЕсли вы ошиблись, просто кликните левой клавишей мыши на нужной ячейке и удалите ваш выбор кнопкой \"Delete\".\r\nВ случае, если вы выберете более одного ответа на вопрос, то строка ответов будет подсвечена красным цветом. В случае, если вы не выберете ни одного ответа, строка останется серой. В случае правильного заполнения, строка будет подсвечена зелёным цветом.\r\n3. После выбора одного из четырёх ответов, вам необходимо выбрать один из трёх мотивов, расположенных под ответом, которыми вы руководствовались. Важно выбирать мотив именно под нужным ответом (при ответе блок с мотивами для наглядности будет подсвечиваться желтым цветом), и так же поставить в нём \"1\". \r\nПринцип заполнения аналогичен п.2.\r\n4. При правильном прохождении теста, все строки, имеющие заливку, должны быть подсвечены зелёным цветом. Если вы видите, что присутствуют другие цвета, то это значит, что в ответе допущена ошибка.\r\n5. После прохождения теста внизу вы увидите ваши показатели по стилю управления и основному гендерному дистрибутиву.\r\n6. Ознакомиться с результатами тестирования можно на вкладке \"Результаты\". Ваш результат будет подсвечен зелёным цветом.\r\n\r\nСпасибо за прохождение теста!", "Тест начало", "picture1,picture2,picture3,picture4,picture5,picture6,picture7,picture8,picture9,picture10,picture11", "[\"0dc6e45e-ba94-4f54-a59e-53caa1eea73c\",\"2b8ad992-d4aa-4c3f-a65e-aaf036260807\",\"2a40bd98-2b1a-47ae-8e61-fe54352357e4\",\"856dc1f5-0d38-43d1-87b5-805c0a35aa2b\",\"d863f251-3f53-42b8-86b9-c24e868cba16\",\"91f9520e-caed-409a-b9de-4b6b31de6159\",\"c5fb7286-90d3-403d-a4b9-ffa775e32ec8\",\"6d6ffb66-cb93-421f-bb20-9b866482a037\",\"e4ece256-cc81-457d-8e8d-e12c7358c3b2\",\"4e2dd4fa-6422-4ac3-b5ae-8c2a4b0de52f\",\"4862fb3b-5603-4073-8aa4-29b4d324c266\"]", "[\"12a7faba-5904-4bcb-949a-f71224190e43\",\"13ebde4b-5e7e-44cf-834e-b6cdfa0ef02c\",\"363b07c0-5f2d-430a-8e96-7f9c700532c1\",\"39c860f6-b6bc-4c3e-b1fc-6f5dead8fe75\",\"6d981101-05f0-4e4f-b62a-f49a1e1edaa3\",\"6e071be6-3d6a-4f1d-adad-dcd1f77db403\",\"70baef4c-2aea-4b84-ad1b-3099dc968b86\",\"85430d7d-aa48-41d5-823d-625cdabbb7d9\",\"991c17b5-7165-46cc-96f2-3811798622c3\",\"b29b2152-b6f1-45d7-a49d-902ca3530268\",\"b72c0d38-0fe3-4a00-bef2-acb32789e086\",\"e2fb7ee4-614b-4cd5-b11e-e522a2d75e94\",\"0d6ba570-1721-4d51-83c4-fa990a69b728\",\"2da33b3a-e685-4dd9-a1a1-55121d31d136\",\"2e77f1b9-a436-4c15-be4b-b581c10bec2c\",\"46af2f80-adf6-4fa3-88a4-4c9d9703a914\",\"64552b30-4c93-4a69-b305-10f4d7db6cb4\",\"81393ae6-9b6f-462f-a189-bb421d430bff\",\"8bb5e5c9-14c4-4dd1-b695-d144aaa8f7d2\",\"a548a1f0-b437-41ad-b5ef-6e8e4e5064ed\",\"b1954ccf-f1d0-495a-928d-0099701a9518\",\"bc01dd89-601d-4c4e-969f-2082b6833ffc\",\"c299418c-9304-4fa0-a681-ec09a95b123c\",\"e6eb1f77-a620-488a-aea7-ec2dba777a66\"]", null });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "AnswerId", "Name" },
                values: new object[,]
                {
                    { new Guid("0dc6e45e-ba94-4f54-a59e-53caa1eea73c"), "[\"cb83a258-54e1-4b2a-a58f-24fe95a357bc\",\"03b5d02c-aa7f-47b9-8b80-4bd984ce7906\",\"9102a12d-2845-4224-939e-913ab96524ab\",\"e82f0359-d505-49f3-9292-f3877a9a844f\"]", "Вы проснулись утром и поняли, что проспали сигнал будильника. Вы стремглав бежите в ванную и обнаруживаете, что в кране нет воды. Ни холодной, ни горячей. Ваши первые действия?" },
                    { new Guid("2a40bd98-2b1a-47ae-8e61-fe54352357e4"), "[\"d33624b4-49b2-46c3-a2f0-b30a0abcb1e8\",\"7cb16f18-ebd1-4835-ab50-92bedbe2e56c\",\"22db7305-82f0-4db2-8725-a02b8c63b263\",\"58a477c8-22e1-4a5a-8b7a-4ab38ef2c2a1\"]", "На светофоре какой-то лихач, проехав на красный свет, нагло подрезает вас, едва не спровоцировав аварию. Ваши действия?" },
                    { new Guid("2b8ad992-d4aa-4c3f-a65e-aaf036260807"), "[\"5ed2804d-bc6a-4296-b9a0-cf720271a18a\",\"4c748f11-614c-4da8-97f2-eec8dc8ef989\",\"01786293-47e4-407e-9c24-66591aa9e099\",\"6afb4539-1a1c-44d5-ab1e-c8b29fbc2ddc\"]", "На корпоративе, к которому вы давно готовились, сосед случайно проливает на вас красное вино. Ваша первая реакция?" },
                    { new Guid("4862fb3b-5603-4073-8aa4-29b4d324c266"), "[\"6ca56951-b7c8-4fc5-ae95-d308cbb9606b\",\"bc99bedd-0c29-43a2-834e-b7cb53dfb462\",\"0c5ba408-6941-4f62-a216-1376625cad92\",\"0e2bc63b-4249-438f-ab4c-ed52551de3f6\"]", "Напоследок вопрос-шутка. Представьте себе, что вы - хлеб. Вас подали на стол и вот-вот употребят в пищу. Вам необходимо что-то срочно предпринять, чтобы спастись. Что вы будете делать?" },
                    { new Guid("4e2dd4fa-6422-4ac3-b5ae-8c2a4b0de52f"), "[\"081ce27a-1ea3-4af4-8faf-57a4bbedb888\",\"0602c2f0-826b-499f-8248-68563ae32729\",\"0f3e9b80-9ca9-49d4-b825-526f99fa6177\",\"1431e81d-95d2-4e75-98f2-583c0f42a2e9\"]", "Вы увидели, как в магазине продавец продала спиртное лицу, которому, очевидно, ещё далеко до совершеннолетия. Каковы будут ваши действия?" },
                    { new Guid("6d6ffb66-cb93-421f-bb20-9b866482a037"), "[\"2f008483-6354-4f50-a434-4cf925415568\",\"0f6e2260-ef66-4da1-9e5a-c0c6802ab24b\",\"10fc872b-81ff-488b-a4e3-a83e20399575\",\"ecba0443-d733-4a15-9791-bc62cd6d2a7e\"]", "В соцсетях вы прочитали, что в где-то, скажем, в Японии, робот, созданный на основе искусственного интеллекта (ИИ), вышел из под контроля и покалечил человека. О чем вы в этот момент подумаете?" },
                    { new Guid("856dc1f5-0d38-43d1-87b5-805c0a35aa2b"), "[\"d9ca6c53-525c-4a1e-8d57-07b24a6f6655\",\"260ee899-5854-43c2-b1c0-a20161583216\",\"27a779a0-5338-4b62-bc46-93484d7164b5\",\"efb2240f-df9f-40da-bf19-c4da4a518034\"]", "Одна из ваших коллег по работе явно оказывает вам знаки внимания. Ваши действия?" },
                    { new Guid("91f9520e-caed-409a-b9de-4b6b31de6159"), "[\"5701ccd4-414d-4b9d-af8c-86deb1a56e45\",\"87b20356-54b0-4b72-9281-e5a300580f2b\",\"c2c60436-e42c-440f-a0d5-9b2266655cdb\",\"56932023-6769-4dc2-8680-484b70e3939a\"]", "Вы утром выносите мусор, но подойдя к контейнерам, видите, что они переполнены. Ваши действия?" },
                    { new Guid("c5fb7286-90d3-403d-a4b9-ffa775e32ec8"), "[\"0a3da123-ff86-4f54-9a96-83ed4258a4a7\",\"a011f3b9-c355-43a7-8840-41d32b3cc0f5\",\"c9bbd0e8-b648-419b-8bc8-c8dc6d0f2732\",\"26cb16cd-0cd8-48b4-a13d-2551eead53cb\"]", "В новостях вы услышали, что где-то в мире разгорелся новый вооруженный конфликт. Каковы ваши мысли в этот момент?" },
                    { new Guid("d863f251-3f53-42b8-86b9-c24e868cba16"), "[\"0033a8fa-5096-4218-88b5-e982ae9cf885\",\"d518b8ae-1c2c-49fb-8053-b7dac72f60bb\",\"352e1ae9-486c-4120-b397-00c61d7dc3d9\",\"6586fff5-1f69-4c6a-871a-5330011cd084\"]", "Один из ваших коллег, с которым вы не особо дружите, никак не может разобраться в вопросе, в котором вы уже давно стали большим специалистом. Каким будет ваше поведение?" },
                    { new Guid("e4ece256-cc81-457d-8e8d-e12c7358c3b2"), "[\"ac212308-36a3-4810-8948-9c3b973838a2\",\"35aaade3-98b1-4a06-9e0e-e0d729b623b7\",\"5cb42bbb-0248-4bfb-a42d-8525e2c3ad70\",\"c8458104-a5f3-46bb-bda8-859f6826662e\"]", "Представьте ситуацию, что уборщица, которая много лет мыла полы в вашем офисе, внезапно заболела. Офис уже несколько недель обрастает грязью. Ваши коллеги на это никак не реагируют. Ваши действия?" }
                });

            migrationBuilder.InsertData(
                table: "Reasons",
                columns: new[] { "Id", "Reason", "Weight", "Weight1", "Weight10", "Weight11", "Weight12", "Weight13", "Weight14", "Weight2", "Weight3", "Weight4", "Weight5", "Weight6", "Weight7", "Weight8", "Weight9", "typeWeight1", "typeWeight10", "typeWeight2", "typeWeight3", "typeWeight4", "typeWeight5", "typeWeight6", "typeWeight7", "typeWeight8", "typeWeight9" },
                values: new object[,]
                {
                    { new Guid("000a06a1-4cd6-4d85-8347-8eb5f5f2aa85"), "Если не вмешаться, то это повториться снова", 0, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 2, 1, 0, 0 },
                    { new Guid("007daed2-2d3b-49a4-ad0c-d7040d4f7b7c"), "Порядок превыше всего! Правила написаны кровью!", 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 1, 2, 0, 0, 0, 0 },
                    { new Guid("01d2e676-63fd-4a93-8ee3-9c4841a23ad1"), "Горы мусора вокруг контейнеров - это отвратительно!", 1, 1, 1, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 2, 0, 1, 0, 0 },
                    { new Guid("07c4753f-0e75-4516-b222-99ccf583cb1f"), "Рано или поздно кто-то решит эту проблему", 1, 0, 1, 1, 1, 0, 0, 1, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 2, 0, 0 },
                    { new Guid("0ba6f7c0-cd20-48dc-836c-f3ddc825605a"), "Точно помню, что видела в интернете, что пятно можно вывести", 0, 1, 0, 0, 1, 1, 0, 1, 0, 0, 1, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 2, 0, 0 },
                    { new Guid("0bfc79dd-5bb0-4817-ba21-0ba838c9b545"), "Может быть, и он мне когда-нибудь пригодится", 0, 1, 0, 0, 1, 1, 0, 1, 0, 1, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 2, 0, 0 },
                    { new Guid("1013fefd-d505-4b34-bef2-3c08e83f5030"), "Такое нельзя оставлять безнаказанным, пусть задумается", 1, 1, 1, 0, 0, 0, 0, 0, 1, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 2, 0, 0, 0 },
                    { new Guid("1450b793-fcc6-4402-bcc0-c91b8631cbfc"), "Почему ему можно, а мне нельзя?", 1, 1, 1, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 2, 0, 0 },
                    { new Guid("15f35581-9ca5-4622-a5e6-d784925e7124"), "Просто не могу смолчать, когда такое со мной происходит", 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 1, 1, 0, 1, 0, 0, 0, 0, 0, 2, 0, 1, 0, 0, 0 },
                    { new Guid("18e43e9d-eb02-4075-9076-b26b3803c963"), "Все там будем", 1, 0, 1, 1, 1, 1, 1, 1, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 2, 0, 0 },
                    { new Guid("191565ba-f698-44eb-bf55-9db48c0ad9a7"), "Я не конфликтный человек, но подобные вещи прощать нельзя", 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 1, 1, 1, 0, 0, 0, 0, 2, 0, 1, 0, 0, 0 },
                    { new Guid("1b849154-df58-440b-a6f5-b1005e1b8483"), "Это нормальная реакция в подобной ситуации", 1, 1, 1, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 2, 0, 0, 1, 0, 0 },
                    { new Guid("1ca5ebc2-35ec-4784-8523-d62fcbbf2f4c"), "Никто не должен видеть меня в таком виде", 0, 0, 0, 1, 1, 0, 1, 1, 1, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0, 1, 0, 0 },
                    { new Guid("1ceb5f0e-363d-4eec-8c04-c9b078f3a8da"), "Нельзя игнорировать процесс спаивания наших детей!", 0, 0, 0, 1, 1, 0, 1, 1, 1, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 2, 0, 0, 0 },
                    { new Guid("1d033778-3762-4c22-90a0-51c826dac17d"), "Может быть, теперь руководство поймет, что процессы выстроены не правильно", 1, 1, 1, 0, 0, 0, 0, 0, 1, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 2, 0, 0 },
                    { new Guid("20cf563d-bfc5-4c15-aa70-ee91e0de167f"), "Без меня вечеринка - не вечеринка. Все внимание сосредоточено на мне", 1, 1, 1, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 2, 0, 1, 0, 0, 0 },
                    { new Guid("22a4c268-78c2-4888-8680-e903f4419440"), "Может быть, это будет ему уроком", 1, 1, 1, 0, 0, 0, 0, 0, 1, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 2, 0, 0 },
                    { new Guid("24673a02-eb1d-403d-9668-fe0187654b0d"), "Он мне не конкурент, и пусть он это поймет", 1, 1, 1, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 2, 0, 0, 0 },
                    { new Guid("256658ef-f816-48f7-a6bf-6a70ac079b47"), "Надеюсь, у власть имущих хватит ума остановить это кровопролитие", 1, 0, 1, 1, 0, 1, 0, 0, 0, 1, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 2, 0, 0 },
                    { new Guid("25dbf84c-5371-44b9-ba26-f6f17cb9f5fe"), "Хорошие люди на дороге не валяются", 0, 0, 0, 1, 1, 0, 1, 1, 1, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 2, 0, 0 },
                    { new Guid("2735e1da-4808-4b2f-b49b-9121d9bc5417"), "Я хочу сделать этот мир немного справедливее. Зло должно быть наказано!", 0, 1, 0, 0, 1, 1, 0, 1, 0, 1, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 2, 0, 1, 0, 0 },
                    { new Guid("2f63ea8f-38e3-4e40-87aa-9cd1af13c882"), "У меня всегда есть стратегический запас воды, а причину выясню потом", 1, 1, 1, 0, 1, 1, 0, 1, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 2, 0, 0 },
                    { new Guid("314814f8-f740-4e85-b86c-c2b08cc82679"), "Это поможет мне комфортнее работать в дальнейшем", 0, 1, 0, 0, 1, 1, 0, 1, 0, 1, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 2, 0, 0 },
                    { new Guid("35035162-c41a-47c9-aa9f-0d6b7cf16b60"), "Задолбали уже со своим ИИ, лучше бы о людях думали!", 1, 0, 1, 1, 1, 1, 0, 1, 0, 0, 0, 1, 0, 1, 1, 0, 0, 0, 0, 1, 2, 0, 0, 0, 0 },
                    { new Guid("380c9dc0-f8fb-4b2e-8aa5-548c5ea43a67"), "Флюиды страха не раз выручали меня", 0, 1, 0, 0, 1, 1, 0, 1, 0, 1, 1, 0, 0, 1, 0, 0, 0, 0, 0, 2, 0, 1, 0, 0, 0 },
                    { new Guid("38dc2cdc-59be-4676-9126-40afb29596a2"), "В мире и так много несправедливости, зачем обращать внимание на плохое?", 0, 0, 0, 1, 1, 1, 0, 1, 0, 0, 1, 1, 0, 1, 1, 0, 0, 0, 0, 1, 0, 2, 0, 0, 0 },
                    { new Guid("3bed62f7-0488-4f66-9020-588d2d048f48"), "Может быть кому-то нужна моя помощь", 0, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 2, 1, 0, 0 },
                    { new Guid("3ed7376c-35fb-41f8-a2ca-0778f6f8ba06"), "Не хочу тратить свое драгоценное время на поиски другого решения", 0, 1, 0, 0, 1, 1, 0, 1, 0, 1, 1, 0, 0, 1, 0, 0, 0, 0, 0, 2, 1, 0, 0, 0, 0 },
                    { new Guid("3ef4e2c9-746e-4ec9-9ad7-a3023f8c51bd"), "Какой смысл играть в догоняшки с идиотом?", 1, 1, 1, 0, 1, 1, 0, 1, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 2, 0, 0 },
                    { new Guid("4009ec61-081a-4cf1-ab46-f922edc46b1b"), "Зачем добавлять работу специалистам?", 0, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 2, 1, 0, 0, 0, 0 },
                    { new Guid("462fc8be-9bff-416e-b548-cb8f5b127268"), "Покажу пример коллегам", 1, 1, 1, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 2, 0, 0, 0 },
                    { new Guid("466a8851-1cd3-453f-89bf-d728ebc07d00"), "Надо ещё всем знакомым рассказать, чтоб тоже туда не ходили", 1, 0, 1, 1, 0, 0, 0, 0, 1, 1, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 2, 0, 0 },
                    { new Guid("4714c535-2e82-4bf8-8ffe-aab2a7ebfabb"), "Мне не привыкать бороться с системой", 0, 1, 0, 0, 1, 1, 0, 1, 0, 0, 1, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 2, 1, 0, 0 },
                    { new Guid("48b9f840-94b7-47c6-9af1-80284b5aa770"), "У меня есть любимый человек, я не нуждаюсь в подобных знакомствах", 0, 1, 0, 0, 1, 1, 0, 1, 0, 0, 1, 0, 0, 1, 1, 0, 0, 0, 0, 0, 2, 1, 0, 0, 0 },
                    { new Guid("4c594e6d-9108-481e-b0bf-2343970b731f"), "Такие ситуации выбивают меня из колеи, все равно уже не смогу веселиться", 0, 0, 0, 1, 1, 1, 0, 1, 0, 0, 1, 1, 0, 1, 1, 0, 0, 0, 0, 1, 2, 0, 0, 0, 0 },
                    { new Guid("4dd0651c-3029-4d51-8fcd-46728f49c125"), "Мне не сложно", 0, 0, 0, 1, 1, 0, 0, 1, 1, 0, 1, 1, 0, 0, 1, 0, 0, 0, 0, 1, 0, 2, 0, 0, 0 },
                    { new Guid("4e0eb8ed-e5e7-4b4c-b2c8-3fc4dc68e74b"), "Пусть знает своё место!", 1, 1, 1, 0, 0, 1, 0, 0, 0, 1, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 2, 1, 0, 0 },
                    { new Guid("5127c013-8026-430c-9773-fffec765e49f"), "Важно, чтоб он осознавал, что его поступок не остался безнаказанным", 1, 0, 1, 1, 0, 0, 1, 0, 1, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 2, 0, 0, 0 },
                    { new Guid("523db197-19ee-43a2-9438-0fffe55341fa"), "Это вообще не моё дело, что она там себе надумала", 1, 1, 1, 0, 1, 1, 0, 1, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 2, 0, 0, 0, 0 },
                    { new Guid("542c5b83-3d7a-4157-804a-fec7c7f32c17"), "Главное, чтобы все в команде работали эффективно", 1, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 1, 1, 0, 1, 0, 0, 0, 0, 1, 0, 0, 2, 0, 0 },
                    { new Guid("56455b12-df9c-4db6-862f-577b05cf24e6"), "Сейчас важнее не опоздать, а остальное -  мелочи", 1, 1, 1, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 2, 0, 1, 0, 0, 0 },
                    { new Guid("56bcf2b7-0f52-443e-a955-332832eb9e34"), "Меня это особо не касается", 1, 0, 1, 1, 1, 1, 1, 1, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 2, 0, 0, 1, 0, 0 },
                    { new Guid("5a3d67d7-08d3-4656-bc21-833842100b03"), "Сам ты хлеб!", 1, 1, 1, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 2, 1, 0, 0, 0 },
                    { new Guid("5e792610-baa6-4dc5-bc05-2a3bb131b0fd"), "за ИИ будущее, а развитие без ошибок невозможно", 0, 1, 0, 0, 1, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0, 1, 0, 0, 0 },
                    { new Guid("6087eac5-ac4e-41b0-a42b-158636cef8d9"), "Кому война, а кому - мать родна", 1, 0, 1, 1, 0, 1, 1, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 2, 0, 1, 0, 0, 0 },
                    { new Guid("60e556cd-e2f0-44e0-885a-37cf26e373bd"), "Мы все уже зависим от ИИ", 0, 0, 0, 1, 1, 0, 0, 1, 1, 0, 1, 1, 0, 0, 1, 0, 0, 0, 0, 2, 0, 1, 0, 0, 0 },
                    { new Guid("6378221f-b3cc-478a-be4d-9aa76a443872"), "Что за глупости?  Ну какой я хлеб?", 1, 1, 1, 0, 1, 1, 0, 1, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 2, 1, 0, 0, 0, 0 },
                    { new Guid("661db458-5cea-431e-b8ba-6a91ed2854a6"), "Может, кто-то знает причину отключения", 1, 1, 1, 0, 0, 1, 0, 0, 0, 1, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 1, 0, 2, 0, 0 },
                    { new Guid("67a0d081-2b25-4db0-b150-1f1f3ad7dd9a"), "Это выбор продавца, меня это никак не касается", 1, 0, 1, 1, 1, 1, 1, 1, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 2, 0, 0, 1, 0, 0 },
                    { new Guid("67a8eb08-f9a9-4426-8e15-5b2f6f70d117"), "В целом, я не против, но только не на работе!", 1, 0, 1, 1, 0, 0, 0, 0, 1, 1, 0, 1, 1, 0, 0, 0, 0, 0, 0, 2, 0, 0, 1, 0, 0 },
                    { new Guid("69114935-091c-4c7a-825f-bde4a2efd381"), "Мне вот, например, в таком возрасте не продавали", 0, 0, 0, 1, 1, 1, 0, 1, 0, 0, 1, 1, 0, 1, 1, 0, 0, 0, 0, 1, 2, 0, 0, 0, 0 },
                    { new Guid("6dd0cd41-c1a9-4c26-be6b-57391cadb830"), "Интересно, кто-то сможет это остановить?", 1, 0, 1, 1, 0, 0, 0, 0, 1, 1, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 2, 0, 0 },
                    { new Guid("6f8f4142-33eb-4fe9-95e2-f73e7570671a"), "Надеюсь, что подобных случаев будет как можно меньше", 0, 0, 0, 1, 1, 1, 0, 1, 0, 0, 1, 1, 0, 1, 1, 0, 0, 0, 0, 0, 2, 0, 1, 0, 0 },
                    { new Guid("74ba8aca-8b6e-41b4-91d0-f43919655d02"), "Мне не сложно", 0, 1, 0, 0, 1, 0, 0, 1, 1, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 2, 0, 0, 0 },
                    { new Guid("7557a105-a89c-4420-9d90-4b51854c4a2d"), "Надо подумать, как использовать ИИ в своей работе", 0, 0, 0, 1, 0, 1, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 2, 0, 0 },
                    { new Guid("76548bc2-eaea-441d-85ab-8630e3a28646"), "Мировая экономика опять пострадает", 1, 1, 1, 0, 0, 0, 0, 0, 1, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 2, 1, 0, 0 },
                    { new Guid("770ae718-1ac8-4975-ad4e-5be8f0c747e0"), "Пусть они потеряют в моем лице постоянного покупателя", 1, 1, 1, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 2, 0, 0 },
                    { new Guid("7bd9eaa0-e33c-4f02-a022-5be616e79ce8"), "Я занимаюсь своей работой, а остальное меня не касается", 1, 1, 1, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 2, 0, 1, 0, 0, 0 },
                    { new Guid("7c151077-39a0-4ced-bd8c-9303de968ead"), "Все зависит от умения людей, которые создают подобные вещи", 1, 0, 1, 1, 0, 1, 1, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 2, 0, 1, 0, 0, 0 },
                    { new Guid("7c2eb83e-5d2e-4f99-a34f-fb269d2dd482"), "Надо порасспрашивать друзей и родственников, может, кто-то прояснит обстановку", 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 1, 2, 0, 0, 0 },
                    { new Guid("800651bd-3270-4e0c-b65a-7fabdfbfb81f"), "Правила на дороге для всех одинаковы", 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 1, 1, 1, 0, 0, 0, 0, 1, 2, 0, 0, 0, 0 },
                    { new Guid("82fcd984-f475-42b2-bacc-2c948001c01c"), "Справедливость в моем мире превыше всего!", 0, 1, 0, 0, 1, 1, 1, 1, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 1, 2, 0, 0, 0, 0 },
                    { new Guid("8502cde7-19a4-4535-b5f4-e1de7d85660e"), "Я буду только рад, что кто-то смог насытиться мною!", 0, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 2, 0, 0 },
                    { new Guid("852df161-1900-4e68-8445-9451296d2d67"), "Такие мелочи не могут меня отвлечь от процесса вождения", 1, 1, 1, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 2, 0, 1, 0, 0 },
                    { new Guid("86f2026a-30bf-44b2-8483-12745611937d"), "Пусть добивается всего сам, как я в свое время", 0, 0, 0, 1, 1, 1, 0, 1, 0, 0, 1, 1, 0, 1, 1, 0, 0, 0, 0, 0, 2, 1, 0, 0, 0 },
                    { new Guid("87313919-1f8e-4ccd-bf1f-ab86120fed88"), "Возможно, это моя миссия!", 0, 1, 0, 0, 1, 1, 0, 1, 0, 0, 1, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 1, 2, 0, 0 },
                    { new Guid("89c19957-d134-48c4-a628-d4e8c9dae98c"), "Надо, чтоб такого продавца обязательно наказали, а ещё лучше уволили", 1, 1, 1, 0, 0, 0, 0, 0, 1, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 2, 1, 0, 0, 0 },
                    { new Guid("8eb4aedb-7de1-4b4d-b2fe-2298b08aca6b"), "Я испытываю негодование от количества дураков в моей жизни!", 1, 1, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 2, 0, 1, 0, 0 },
                    { new Guid("94141d88-aeb5-4c21-9d20-22e50879a756"), "На столе много другой еды, надеюсь, что на меня не обратят внимания", 1, 1, 1, 0, 1, 1, 0, 1, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 2, 0, 0 },
                    { new Guid("95b174c0-a5b3-4134-85f9-2f94467b23c1"), "Возможно, это ещё больше подогреет её интерес", 1, 0, 1, 1, 0, 1, 0, 0, 0, 1, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 2, 0, 0 },
                    { new Guid("968de2eb-4bde-422c-8ce2-59a71b9b1936"), "Мало ли, может, кто-то не может сам сходить и отправил ребенка", 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 1, 1, 1, 0, 1, 0, 0, 0, 0, 1, 0, 0, 2, 0, 0 },
                    { new Guid("97d69ebb-66ae-412c-8ccc-dfdc910e080b"), "Надоел этот бардак в стране, за что я плачу деньги?", 0, 0, 0, 1, 1, 1, 0, 1, 0, 0, 1, 1, 0, 1, 1, 0, 0, 0, 0, 0, 0, 2, 1, 0, 0 },
                    { new Guid("9b024278-7390-4678-9d0b-bdd93cc7d8a6"), "Не на того нарвался, и я ему это докажу", 1, 0, 1, 1, 1, 1, 1, 1, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 2, 0, 1, 0, 0, 0 },
                    { new Guid("9d2ca57a-ff4b-46d5-ad6b-14416412efcb"), "Может быть, руководство, наконец, заметит, что я компетентнее во многих вопросах", 1, 0, 1, 1, 1, 1, 1, 1, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 2, 0, 1, 0, 0, 0 },
                    { new Guid("9f39e031-554e-4edb-a1c7-00216ce24cc5"), "Жизнь его обязательно накажет", 1, 1, 1, 0, 0, 1, 0, 0, 0, 1, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 2, 1, 0, 0 },
                    { new Guid("9fe0df1f-8a80-4368-9150-852e4a5441dd"), "Всем можно, почему мне нельзя?", 0, 0, 0, 1, 1, 1, 0, 1, 0, 0, 1, 1, 0, 1, 1, 0, 0, 0, 0, 0, 0, 2, 1, 0, 0 },
                    { new Guid("9fe7069a-f8a9-48ae-b63e-68e0ad6e683a"), "Я свободный человек, что хочу, то и делаю", 1, 1, 1, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 2, 1, 0, 0 },
                    { new Guid("a169eb49-7103-4eb9-b23c-1f8f5722550d"), "Это только начало необратимого процесса", 0, 1, 0, 0, 1, 1, 1, 1, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 1, 2, 0, 0, 0, 0 },
                    { new Guid("a3f7aa1a-fd06-48ba-9427-21f7e6503bab"), "Надо вывалить на кого-то все зло, которое у меня накопилось", 1, 1, 1, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 2, 0, 1, 0, 0, 0 },
                    { new Guid("a48abfe5-42c4-472a-b97e-f52dba9b6da6"), "Это никак не влияет на мою основную деятельность", 1, 1, 1, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 2, 0, 0, 1, 0, 0 },
                    { new Guid("a62254af-21fe-4cca-95cb-9cc5b5aced2b"), "Почему только мне прилетает от начальства, пусть и ему прилетит", 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 2, 1, 0, 0, 0 },
                    { new Guid("a647e8f1-9eb2-46b0-a86b-8ecf338ba124"), "Потом ещё спасибо скажут", 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 1, 1, 0, 0, 0, 0, 0, 0, 1, 0, 2, 0, 0 },
                    { new Guid("a72bf684-2ba3-4523-b398-2fbbd1b15bcb"), "Надо запустить этот процесс, а коллеги меня поддержат", 0, 0, 0, 1, 1, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 2, 0, 0, 0 },
                    { new Guid("ac770c37-03bc-40d4-9ac1-8067134763d9"), "В мой мир это ещё не скоро придет", 1, 1, 1, 0, 1, 1, 0, 1, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 2, 0, 0 },
                    { new Guid("adc457f7-cb29-4fe1-838e-9a8038c0aa58"), "Можно и неумытой поехать, а умыться, скажем, в офисе", 1, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 1, 0, 2, 0, 0, 0 },
                    { new Guid("b1fa7309-783b-48b5-b68a-75bacb94d6a0"), "Может быть бардака в моем мире будет меньше", 0, 1, 0, 0, 1, 1, 0, 1, 0, 1, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 2, 0, 1, 0, 0 },
                    { new Guid("b2efdd67-6c98-49b0-9cc6-bf09b3b27bfa"), "Кто-то должен за это ответить!", 1, 0, 1, 1, 0, 0, 1, 0, 1, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 2, 1, 0, 0, 0 },
                    { new Guid("b3d2b465-6c85-469e-831c-40c1317baa95"), "Нельзя допускать подобного беспредела!", 1, 0, 1, 1, 0, 1, 1, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 1, 2, 0, 0, 0 },
                    { new Guid("b56c26c6-2de6-468c-98e2-dfc5fc35c436"), "Есть веская причина, которую поймет начальство", 1, 0, 1, 1, 0, 1, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 2, 0, 1, 0, 0 },
                    { new Guid("b720be24-7f05-4b84-b916-615099596d71"), "Чистота важна для всех в равной степени", 1, 1, 1, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 2, 0, 0, 0, 0 },
                    { new Guid("b925a8e2-9ec2-43bb-b96c-8587d43b2068"), "Обеспечение достойных условий труда - обязанность работодателя!", 1, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 1, 2, 0, 0, 0, 0 },
                    { new Guid("bb6d3939-359f-464a-af39-820c1cf5188a"), "Никто не любит черствый хлеб!", 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 1, 1, 1, 0, 1, 0, 0, 0, 0, 1, 2, 0, 0, 0, 0 },
                    { new Guid("bf265f0c-bdba-42e9-9d02-039ed2d98b2e"), "Почему это происходит в моем мире?", 0, 1, 0, 0, 1, 1, 1, 1, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 2, 1, 0, 0, 0, 0 },
                    { new Guid("bffe1e1e-7921-4a17-81f8-bf30437b6ccc"), "Мне важна чистота в моем мире", 0, 0, 0, 1, 1, 1, 0, 1, 0, 0, 1, 1, 0, 1, 1, 0, 0, 0, 0, 1, 2, 0, 0, 0, 0 },
                    { new Guid("c05a605d-d244-48c2-866c-011327f6d8fe"), "Зачем добавлять работу специалистам?", 0, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 2, 1, 0, 0, 0, 0 },
                    { new Guid("c20b6825-163e-4b40-8624-5fbd491477a1"), "Меня так просто не добиться!", 1, 1, 1, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 2, 0, 0, 0 },
                    { new Guid("c2ea7376-d1fb-466d-91b3-a6efb2fb0063"), "Может быть, кто-то уже предпринял действия для устранения проблемы", 1, 0, 1, 1, 0, 1, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 2, 1, 0, 0, 0 },
                    { new Guid("c325ad59-ce45-4225-b563-bcc74c529ced"), "В следующий раз сам ко мне придет за помощью", 1, 1, 1, 0, 1, 1, 0, 1, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 2, 1, 0, 0 },
                    { new Guid("c5018ed3-8b72-4f59-8f82-0fcfe0dcdb91"), "Вот, наконец-то, повод отлежаться дома", 1, 1, 1, 0, 1, 1, 0, 1, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 2, 0, 0, 1, 0, 0 },
                    { new Guid("c59dd14c-0cd9-4b38-9ac6-b2fc7e49ad45"), "Чем меньше я обращаю на это внимание, тем быстрее это закончится", 0, 0, 1, 0, 1, 1, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 2, 0, 0, 1, 0, 0 },
                    { new Guid("c5e88078-2957-4255-9f69-209868b59cbc"), "Я дорожу своей безупречной репутацией", 0, 1, 0, 0, 1, 1, 0, 1, 0, 0, 1, 0, 0, 1, 1, 0, 0, 0, 0, 0, 2, 1, 0, 0, 0 },
                    { new Guid("c97493b0-9616-4f2d-8f24-773f51f60dd6"), "Не велика проблема, можно и с пятном быть харизматичной", 1, 1, 1, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 2, 1, 0, 0 },
                    { new Guid("ca7cfe1e-332c-413a-8ddc-64db7a2642d2"), "Зачем мне что-то предпринимать? Это ведь никак не отразится на моей зарплате", 0, 1, 0, 0, 1, 1, 0, 1, 0, 0, 1, 0, 0, 1, 1, 0, 0, 0, 0, 1, 2, 0, 0, 0, 0 },
                    { new Guid("cac0e665-9992-4fc0-b98a-c4c2106a4e3f"), "Пока кто-то зарабатывает, люди страдают", 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 1, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 2, 1, 0, 0 },
                    { new Guid("cb49c8e2-ff11-4e2e-ac7d-181d9f588223"), "Мало ли дураков за рулем, зачем обращать внимание на каждого?", 0, 1, 0, 0, 1, 1, 0, 1, 0, 0, 1, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 2, 0, 0 },
                    { new Guid("cb9a9358-434f-4f99-ba79-78e5c9dc2953"), "Я никогда не против новой интрижки", 1, 0, 1, 1, 0, 1, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 2, 1, 0, 0 },
                    { new Guid("ccb12853-2446-4b42-9581-16db2853f079"), "Я не раз видел, что такие действия могут помочь в решении проблемы", 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 1, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 1, 2, 0, 0 },
                    { new Guid("cd87c258-cf5e-4e0e-9f8b-cf01c82ec880"), "Очень скоро всем нам придется столкнуться с чем-то подобным", 0, 0, 0, 1, 1, 0, 1, 1, 1, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 2, 0, 0, 0 },
                    { new Guid("ce8e5fbd-138c-4370-a9f1-bb5543f10bcf"), "Не думаю, что на подобной вечеринке мой конфуз будет сильно бросаться в глаза", 0, 0, 0, 1, 0, 1, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 2, 1, 0, 0 },
                    { new Guid("d07501c8-e224-4500-87a9-2d1d75c3cc48"), "В конце концов, найду чем позаниматься дома", 1, 1, 1, 0, 0, 1, 0, 0, 0, 1, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 2, 0, 0, 0 },
                    { new Guid("d1078e15-f779-452e-b72c-fde1b835c639"), "Надо ходить по земле и зарабатывать на физических продуктах", 1, 1, 1, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 2, 0, 1, 0, 0, 0 },
                    { new Guid("d3568b6a-c200-476d-8292-a2d227b81320"), "У продавца есть начальство, у ребенка - родители, пусть сами разбираются", 1, 1, 1, 0, 1, 1, 0, 1, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 2, 0, 0, 0, 0 },
                    { new Guid("d4eb06ea-6c59-4a7a-8bbb-7adf041ce4c8"), "Я не трус, но иногда боюсь", 0, 0, 0, 1, 1, 1, 0, 1, 0, 0, 1, 1, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 2, 0, 0 },
                    { new Guid("d578a565-d33c-4f77-abad-d9a7b0c6f748"), "Любые отношения мешают рабочему процессу", 1, 0, 1, 1, 0, 0, 1, 0, 1, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 2, 1, 0, 0, 0, 0 },
                    { new Guid("d647ba58-9482-43ce-830f-7d8ce0f917ed"), "У меня и так много забот", 0, 0, 0, 1, 1, 1, 0, 1, 0, 0, 1, 1, 0, 1, 1, 0, 0, 0, 0, 0, 2, 1, 0, 0, 0 },
                    { new Guid("da5ff667-d385-48fa-951d-6ce8e7fd08bf"), "Такие вылазки для меня редкость, поэтому надо вернуться и обязательно догулять", 1, 1, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 2, 0, 0 },
                    { new Guid("df6d9cc1-5bb2-4271-b1b7-574c951840da"), "Это естественный процесс эволюции", 1, 0, 1, 1, 0, 0, 0, 0, 1, 1, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 2, 0, 0 },
                    { new Guid("e50ee429-61ab-42e3-99ff-4e7799e0510c"), "Я всегда выгляжу идеально и должен быть примером для других", 1, 1, 1, 0, 0, 0, 0, 0, 1, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 2, 0, 0, 0, 0 },
                    { new Guid("eb49fb72-769c-4cc5-b38d-fa253263f73a"), "Если бы подобных людей в моей жизни было бы меньше, я бы чувствовала себя лучше", 0, 1, 0, 0, 1, 1, 0, 1, 0, 0, 1, 0, 0, 1, 1, 0, 0, 0, 0, 1, 2, 0, 0, 0, 0 },
                    { new Guid("ef3eff5f-9193-44fa-8ee4-95d8885d9cd5"), "Сами виноваты, что не убирают вовремя", 1, 0, 1, 1, 1, 1, 1, 1, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 2, 1, 0, 0, 0 },
                    { new Guid("eff0158e-f158-4e0f-81c9-5f5c62326cf3"), "Раз я могу представить, что я - хлеб, то могу  представить себя и черствым", 0, 1, 0, 0, 1, 1, 1, 1, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 2, 1, 0, 0 },
                    { new Guid("f1e3ce54-dca2-4f95-a5d3-281107afef9e"), "Само провидение её мне посылает", 0, 1, 0, 0, 1, 1, 0, 1, 0, 1, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 2, 0, 0 },
                    { new Guid("f223da69-63f6-468d-b25e-279fd8f11d7b"), "Придет время, и он сам всему научится", 1, 0, 1, 1, 0, 1, 0, 0, 0, 1, 0, 1, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 2, 0, 0 },
                    { new Guid("f481437f-5d66-4183-b041-f60302ac0fa2"), "Того и гляди, до нас докатится", 1, 0, 1, 1, 0, 1, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 2, 0, 1, 0, 0 },
                    { new Guid("f5b4d3f8-e602-4da0-802d-f20430da0342"), "Горы мусора вокруг контейнеров - это отвратительно!", 1, 1, 1, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 2, 0, 1, 0, 0 },
                    { new Guid("f70515d3-c89c-42f1-81be-47de0db3143e"), "Я, скорее, апельсин", 0, 0, 0, 1, 1, 1, 0, 1, 0, 0, 1, 1, 0, 1, 1, 0, 0, 0, 0, 0, 0, 2, 1, 0, 0 },
                    { new Guid("f70fca13-268b-4e2e-9906-066b455d2081"), "А вдруг это у меня только что-то сломалось?", 0, 0, 0, 1, 1, 0, 1, 1, 1, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 2, 1, 0, 0, 0, 0 },
                    { new Guid("f83b28c3-c12c-4097-99d6-58da46f6bd9f"), "Наверняка, люди сами наделали ошибок, при конструировании робота", 1, 0, 1, 1, 0, 1, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 1, 2, 0, 0, 0, 0 },
                    { new Guid("f8dfade8-1e5a-4b5b-b866-0b5c3953fd76"), "Пусть увидит, что я компетентнее в этом вопросе", 1, 1, 1, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 2, 1, 0, 0, 0, 0 },
                    { new Guid("f908af7a-2f84-4fdf-a400-1510a68c62b8"), "Я давно предчувствую беду", 0, 0, 0, 1, 1, 1, 0, 1, 0, 0, 1, 1, 0, 1, 1, 0, 0, 0, 0, 1, 2, 0, 0, 0, 0 },
                    { new Guid("fdaff6ee-c481-45c5-bf2c-98fec53c8640"), "Кто-то должен взять это на себя, если не я, то кто?", 0, 1, 0, 0, 1, 1, 0, 1, 0, 0, 1, 0, 0, 1, 1, 0, 0, 0, 0, 2, 0, 1, 0, 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "Resaults",
                columns: new[] { "Id", "Gender", "Resault", "Style", "TrigerImage", "Type" },
                values: new object[,]
                {
                    { new Guid("0d6ba570-1721-4d51-83c4-fa990a69b728"), "woman", "Сильная, уверенная в себе личность, взор которой устремлен в далекое безоблачное будущее. Несмотря на то, что её цели не сформулированы конкретно, будет настойчиво двигаться вперёд и активно вовлекать в это движение окружающих. Ей не нужны партнёры, но она нуждается в сподвижниках, которые поверят в неё и пойдут за ней. При этом, она не только не стремится конкретизировать будущее, но и особо не позволяет это сделать другим. Будущее - её территория, на которую она неохотно пускает посторонних. При этом, её не особо интересует что происходит в настоящем, и уж тем более то, что произошло в прошлом.\r\nХороший стратег и неплохой аналитик, но, опять же, когда речь идёт об анализе какого-то будущего. Если для неё собрать и обобщить фактические данные, то она сможет разработать несколько вариантов стратегического развития, выбрать из них наиболее эффективный и обосновать свой выбор с помощью веских аргументов.\r\nТакие люди сильны в стратегическом маркетинге, их советы могут быть очень ценными, например, при позиционировании компании на рынке.", "Интегратор", "охотник-Интегратор", "Хранительница" },
                    { new Guid("12a7faba-5904-4bcb-949a-f71224190e43"), "man", "Сотрудник, обладающий неплохим набором деловых качеств, но не карьерист. Ему гораздо комфортнее работать под чьим-то началом. Вообще, его руководителю нужно нащупать тот идеальный баланс, при котором данный тип сотрудника будет под контролем, но при этом будет обладать относительной свободой действий. Можно, например, дать ему свободу в проведении переговоров среднего уровня, в процессах заключения сделок, но при этом поручить оформление сопроводительных документов другому лицу. \r\nОн очень хорошо обучаем всему тому, что даёт посыл к действию. И в этом же он хорош и на деле. Обозначьте ему границы его полномочий и смело бросайте в бой - он не подведёт. В крайнем случае, обратится к вам за советом.  Однако, при неправильной постановке задач, может проявить неуместную самостоятельность, так как не всегда осознает уровень своей ответственности. Даже если вы будете навязывать ему эту ответственность, пугая санкциями, скорей всего, он этого просто не услышит. Если создать вокруг него условия, в которых будет как можно меньше внештатных ситуаций, то он будет чувствовать себя, как рыба в воде, и сможет показывать очень хорошие результаты", "Предприниматель", "ишуший-предпренематель", "Ищущий" },
                    { new Guid("13ebde4b-5e7e-44cf-834e-b6cdfa0ef02c"), "man", "Довольно адская смесь доминирующего мужского начала с административным стилем управления процессами. Не терпят бардака ни в чем. Если им приходится постоянно сталкиваться с чем-то непонятным и непредсказуемым, с чем-то, что плохо оцифровывается и классифицируется в их мире, то они могут в какой-то момент просто уйти, не сказав ни слова. Это проявляется на работе и дома. Если, например, в семье заведено садиться ужинать в семь часов, а жена, по природе своей мать-интегратор, несколько дней подряд нарушила это правило, то она может искренне удивиться, когда он однажды хлопнет дверью, не объяснив причин ухода, ведь в ее мире не произошло ничего страшного, а для него это сродни предательству.\r\nНе терпим он также и к подобным, казалось бы, пустяковым, ошибкам коллег и друзей. \r\nС удовольствием проводит время в одиночестве, не сторонник шумных компаний и громких вечеринок. Не частый гость на корпоративах и различных тимбилдингах.", "Администратор", "охотник-админестратор", "Охотник" },
                    { new Guid("2da33b3a-e685-4dd9-a1a1-55121d31d136"), "woman", "Жесткий и требовательный модератор процессов. Требовательный как к другим, так и к себе. Идеальный порядок сопутствует ей во всех проявлениях личности: на работе, в семье и даже в хобби. На рабочем столе идеальный порядок, дома всё лежит по своим полочкам, любимый пирог печется строго по рецепту. Не приемлет вмешательства в свои идеальные порядки. Прислушивается исключительно к тем источникам, которые сама считает авторитетными. Так что, если вам достался сотрудник с таким набором скиллов, то неплохо было бы понимать, какие ценности на самом деле являются для неё жизнеутверждающими. И уж совсем хорошо, когда её руководитель эти ценности периодически транслирует в жизнь.  Только тогда она готова пускать вас на свою территорию и проявлять к вам лояльность. \r\nХорошие юристы, следователи, адвокаты, врачи, заведующие складами и хозяйствами, диспетчеры и IT-специалисты - вот далеко не полный список профессий, в которых могут ярко проявляться люди данного типа", "Администратор", "охотник-админестратор", "Хранительница" },
                    { new Guid("2e77f1b9-a436-4c15-be4b-b581c10bec2c"), "woman", "Если этому человеку близки корпоративные ценности, то он хорошо подойдет для выполнения производственных функций. В четко отлаженных процессах она незаменима. Во многих вопросах она проявляет консервативность, и это качество помогает ей \"хранить и приумножать\". Четко видит границы своего мира, в котором ей комфортно и понятно, и в который оне не очень охотно впускает любые изменения. В растущем или масштабируемом бизнесе, где постоянно появляются новые вводные и задачи, ей может быть некомфортно на передовых ролях, но ей вполне по силам выполнение понятных производственных функций, которые нельзя обделять вниманием, увлекаясь развитием. Она - та самая рабочая лошадка, которая будет тащить эти процессы на себе, не требуя дополнительных бонусов. Тем не менее, любая похвала ей приятна и может являться хорошим мотивирующим фактором. Ей гораздо комфортнее работать в мужском коллективе и даже управлять им. Если же в работе её окружают преимущественно женщины, то следует особое внимание уделить вопросам её корректной мотивации, во избежание возникновения нездоровой конкуренции в коллективе.", "Производитель", "охотник-производитель", "Хранительница" },
                    { new Guid("363b07c0-5f2d-430a-8e96-7f9c700532c1"), "man", "Почти идеальный руководитель отдела продаж. Хороший наставник для менеджеров, знающий свое дело. Однако стратегическое мышление ему не всегда присуще, и именно это мешает ему стать коммерческим директором. Если в компании есть кому заниматься стратегическими вопросами, а перед отделом продаж стоят понятные задачи, то цены ему в роли РОПа не будет. Возьмет на себя переговоры любой сложности и научит этому подопечных. Вытащит любую, даже самую безнадёжную сделку. \r\nТаких людей любят в коллективе и в семье. У них много друзей. Они, как правило, очень начитаны и образованы. Иногда чересчур требовательны к окружающим, но не более, чем к себе. \r\nИм нужно создавать постоянное движение, и именно этого они хотят от своего окружения. Покой их  немного угнетает. Они готовы к действию во время выходных и праздников и будут вовлекать в работу весь коллектив. И коллектив, как правило, их поддержит.\r\nЛюдей данного типа не смущает работа в жестких условиях, как временнЫх, так и финансовых. Важно хвалить даже небольшие их достижения, особенно организационные.", "Предприниматель", "Наставник-предпренематель", "Наставник" },
                    { new Guid("39c860f6-b6bc-4c3e-b1fc-6f5dead8fe75"), "man", "Одинокий волк, способный проворачивать серьёзные сделки самостоятельно. Любой внешний контроль воспринимает, как вторжение на свою территорию. Сам ставит себе задачи и сам их решает. Попробуйте дать такому человеку свободу действий, и он непременно покажет результат. Люди этой категории – хорошие предприниматели, менеджеры и даже руководители отделов продаж. Однако, если в команде присутствуют сильные, доминирующие продажники, то им сложно будет ужиться вместе. \r\nКак правило, такие люди сосредоточены на моменте \"здесь и сейчас\" и смотрят в будущее только в краткосрочном периоде, поэтому при решении стратегических задач их интерес быстро угасает. Это люди действия и, как правило, сильные личности, способные быстро и решительно достигать практически любые цели, становясь примером для менее опытных коллег. Их не смущают переговоры на любом уровне. Они, что называются, за словом в карман не полезут. \r\nНе жалуют бумажную и любую монотонную работу и могут допускать примитивные ошибки, если им доверить процесс сделки полностью, поэтому во вторичных, обеспечивающих процессах нуждаются в ненавязчивом контроле. Правильнее всего договориться с ним \"на берегу\"", "Предприниматель", "охотник-предпренематель", "Охотник" },
                    { new Guid("46af2f80-adf6-4fa3-88a4-4c9d9703a914"), "woman", "Любознательный и, как правило, прилежный производитель, однако не горящий желанием играть \"первую скрипку\". Внештатные ситуации могут выбить ее из колеи, даже если в голове у неё есть варианты их разрешения. Может хорошо проявлять себя в различном функционале, если задачи и цели ей понятны. Даже в финансовом блоке, если работа связана не со стратегическим планированием, а, например, с расчетом себестоимости или нормированием труда, может показать себя, как эффективный сотрудник. Лучше всего себя проявляет под руководством \"мужчины-наставника\" или \"заботливой женщины\". Но если таковые отсутствуют в подразделении, где она работает, то может на протяжении долгого времени не раскрывать свой потенциал, при этом усердно работая. Тем не менее, это один из немногих производителей, способных быстро адаптироваться к изменениям. Это уникальное сочетание может быть незаменимым в процессах растущего бизнеса или при переориентации производства. ", "Производитель", "ишуший-производитель", "Познающая" },
                    { new Guid("64552b30-4c93-4a69-b305-10f4d7db6cb4"), "woman", "Имея главного бухгалтера не путать с финансовым директором с таким набором компетенций, ни одна компания не прогадает. Порядок в цифрах будет обеспечен на сто процентов.\r\nЛюбая ошибка в цифрах может восприниматься ею, как личное оскорбление, благо, что этих ошибок она практически не допускает. Ни своих, ни своих подчиненных: она будет проверять их работу до тех пор, пока не убедится в том, что результат будет верным. А когда убедится - продолжит проверять. Умеет анализировать, но так как фокус ее внимания сосредоточен на мелочах, ее анализ не будет распространяться на глобальные процессы. Иными словами, она сможет быстро и с легкостью выявить ошибку в расчетах, но не будет ломать голову, как упростить процесс расчета. Или, например, видя, что выручка компании снижается из периода в период, она может быстро и четко, как \"Отче наш\"", "Администратор", "Наставник-админестратор", "Заботливая " },
                    { new Guid("6d981101-05f0-4e4f-b62a-f49a1e1edaa3"), "man", "Редкое сочетание жизненных настроек. Способен управлять коллективом, при этом оставаясь незаменимой рабочей лошадкой. Однако в незаменимости часто и есть основная проблема. Стоит ему уйти в отпуск а на больничный он, как правило, не ходит, как система начинает давать сбои, словно у многотонного грузовика вдруг отказал гидроусилитель руля. \r\nЭто идеальный заместитель начальника производственного подразделения, который возьмет на себя всю работу и не будет пытаться выдавить из кресла вышестоящего руководителя.  Скорей наоборот: если вдруг это кресло зашатается, он будет поддерживать его, даже в чем-то жертвуя собой. Может найти себя в любом направлении деятельности и адаптироваться практически в любом коллективе, но ближе всего ему производственные бизнес-процессы, хорошо описанные, а ещё лучше нарисованные на бумаге, с понятным и достижимом результатом. Сложнее всего ему дается стратегическое планирование. Не сказать, что он с ним не справляется, но он тратит на это намного больше сил и энергии, чем люди с управленческим типом \"I\".", "Производитель", "Наставник-производитель", "Наставник" },
                    { new Guid("6e071be6-3d6a-4f1d-adad-dcd1f77db403"), "man", "Отличный руководитель большой компании и даже корпорации. Его решения мудры и стратегически выверены. Работать под началом такого человека - одно удовольствие. Он справедлив и щедр. Практически всегда найдет решение любой проблемы и любого конфликта. Причем, решением этим будут удовлетворены все стороны. Хороший аналитик, но посредственный финансист. Однако, если даже перед ним стоит задача, решение которой лежит за пределами его компетенций, он вникнет во все нюансы и тонкости и постарается её решить. \r\nСреди таких людей много выпускников-медалистов, кандидатов и докторов наук, преподавателей и авторов научных статей. Они интеллигентны, интеллектуальны и приятны в общении. \r\nКрасноречивы и умеют выступать на публике. \r\nВесьма требовательны к себе. Зачастую, намного больше, чем к окружающим. Это часто мешает им принимать быстрые решения.\r\nЕсли у них в подчинении есть администраторы, производители и предприниматели, то они могут так выстроить работу команды, что она будет максимально эффективна. Но делать они будут это очень медленно, выверяя каждый шаг.", "Интегратор", "Наставник-Интегратор", "Наставник" },
                    { new Guid("70baef4c-2aea-4b84-ad1b-3099dc968b86"), "man", "Идеальный производитель, но часто не сторонник командной работы. Волк-одиночка, который ставит перед собой задачу и доводит ее решение до конца. Знает себе цену, поэтому им непросто управлять, но это часто и не нужно. Гораздо проще с ним договориться, признав его авторитет и объяснив какой результат от него ждут. При достижении долгосрочных целей может тихо выгорать, не говоря никому об этом, так как для него важно видеть результат в обозримом настоящем. Но видимые ему цели готов достигать любой ценой. Такие люди незаменимы в условиях дедлайна: он не уйдет с работы, пока заказ не будет выполнен. Он обычно ощущает эту незаменимость, порой, настолько, что, попадая в условия комфортных временных рамок, может даже искусственно создавать ситуации цейтнота. \r\nНе всегда ладит с коллективом. Нетерпим к халявщикам и ленивым сослуживцам. Искренне не понимает, чем занимаются \"так много человек\" где-нибудь, например, в бухгалтерии или в отделе маркетинга.", "Производитель", "охотник-производитель", "Охотник" },
                    { new Guid("81393ae6-9b6f-462f-a189-bb421d430bff"), "woman", "Добрая, мягкая, отзывчивая - неполный перечень эпитетов, характеризующий данный тип личности. С этим человеком уютно и тепло. Она всегда придёт на помощь в трудную минуту, и будет готова отдать всю себя без остатка. \r\nВ работе это тот человек, который будет всегда вкручивать в текущую деятельность элементы стратегического планирования, устраивать мозговые штурмы и стратегические сессии и вовлекать в них весь коллектив. И у неё всегда найдутся веские аргументы, для чего это необходимо делать. Фокус её внимание почти всегда направлен в далёкое будущее, в котором всё должно быть светло и радостно. Это часто мешает ей сосредоточиться на настоящем моменте и проанализировать текущую ситуацию. Хотя, она очень сильна в аналитике. Иными словами, если сделать для нее анализ текущей ситуации, то она с большой долей вероятности предскажет, как будут развиваться события в дальнейшем.\r\nЕсли ей поручить управление коллективом, то она станет добрым и чутким наставником, способным двигать людей вперёд. \r\nДля полноценной работы ей в команде не помешает парочка производителей и администратор.", "Интегратор", "Наставник-Интегратор", "Заботливая " },
                    { new Guid("85430d7d-aa48-41d5-823d-625cdabbb7d9"), "man", "Весьма взыскательный и компетентный наставник. У такого не забалуешь. Поставьте такого у руля отдела, работа которого связана с четкими и понятными целями, и он идеально выстроит в нем все процессы. Если же цели размыты или часто меняются, то он все равно выстроит процессы идеально, но это будет работа ради работы. Тут важно понимать, почему так происходит. Само понятие цели для него вторично, он сфокусирован на процессах и алгоритмах, которые в них заложены.  При этом, если цели кем-то сформулированы, ему вполне по силам выстроить процессы и распределить задачи между людьми для качественного выполнения работы. \r\nОтличный главный инженер, технолог, механик, руководитель отдела контроля качества, специалист по кадровой работе, зачастую, хороший, но требовательный и принципиальный преподаватель.\r\nУ него могут непросто складываться отношения со склонными к быстрым действиям предпринимателями и витающими в облаках интеграторами, но если знать, в чем они могут дополнять друг друга и распределить глобальные процессы между ними правильно, то это может существенно повысить эффективность процессов, в которых они задействованы.", "Администратор", "Наставник-админестратор", "Наставник" },
                    { new Guid("8bb5e5c9-14c4-4dd1-b695-d144aaa8f7d2"), "woman", "Самостоятельный до эгоистичности архетип. Добиться максимальной эффективности от нее можно, только выстроив с ней партнерские отношения. В роли исполнителя своенравна и будет постоянно показывать характер. В роли руководителя зачастую склонна к авторитарности на грани тирании. У такого начальника не забалуешь. Ей по душе роль свободного агента, именно в ней она будет наиболее эффективна. Любой контроль может вывести её из себя. Заберите у неё те процессы, которые ей не нравятся, а в остальном дайте ей свободу действий, и она может показать ошеломительные результаты. \r\nНесмотря на присущие ей коммуникативные навыки, не всегда ладит с коллективом. Особенно с тем, где она не является безоговорочным лидером. Если мотивационная система включает соревновательный момент, то, вероятней всего, она будет одним из постоянных лидеров любого состязания. Поражения же, напротив, её угнетают и могут существенно снижать её эффективность в краткосрочном периоде. Лидер в семье и на работе, но лидер - одиночка. Если будет назревать революция, то она может стать одной из первых, кто полезет на баррикады, и ей не важно, пойдут ли за ней соратники", "Предприниматель", "охотник-продпренематель", "Хранительница" },
                    { new Guid("991c17b5-7165-46cc-96f2-3811798622c3"), "man", "ВедОмый, но исполнительный и аккуратный. Редко готов брать на себя главную роль, но работает всегда со знанием дела. На растущем предприятии, где ещё очень много хаотичных и новых процессов, ему будет не очень комфортно, но зато в управлении сложившимися процессами ему нет равных. Благодаря математическому складу ума, он быстро обучаем высокотехнологичным алгоритмам. Ему по силам освоить сложную систему автоматизации или работу с установками ЧПУ, но ровно до того момента, где не будет требоваться творческое вмешательство. Он искуснее и филиграннее сделает то, что было сделано до него уже не раз, но не нужно заставлять его придумывать что-то новое.\r\nКульт качества для таких людей превыше многого другого, но если у них нет эталона, то это может уводить их от цели. Гораздо проще, чем администраторы-охотники, относятся к своим ошибком, но, тем не менее, некорректное указание им на эти ошибки может стать для них существенным демотивирующим фактором", "Администратор", "ишуший-админестратор", "Ищущий" },
                    { new Guid("a548a1f0-b437-41ad-b5ef-6e8e4e5064ed"), "woman", "Не очень распространенный и весьма противоречивый тип личности. Нередко подвисает между прошлым и будущим. И речь тут не про настоящее, а именно про внутренне разногласие при восприятии действительности. Её устремление в будущее нередко натыкается на глубокий внутренний конфликт, часто связанный с детскими триггерами. Особенно это характерно для людей, прошедших в жизни много испытаний. Без мудрого и опытного наставника могут периодически терять смысл в происходящих вокруг процессах, вплоть до депрессивных состояний. Однако, при правильной мотивации под руководством грамотного ментора, могут раскрыть свой потенциал. Хорошо генерирует идеи и умеет донести их смысл до окружающих. Довольно легко сходится с людьми. Не сказать, что становится прям душой компании, но с ней легко и приятно общаться: она всегда выслушает с любовью и искренним сочувствием. \r\nС радостью и энтузиазмом берется за аналитическую работу, но, если эта деятельность связана исключительно с анализом понятных данных и не требует стратегического мышления, её пыл быстро угасает, и она может допускать ошибки.", "Интегратор", "ишуший-Интегратор", "Познающая" },
                    { new Guid("b1954ccf-f1d0-495a-928d-0099701a9518"), "woman", "Этому типажу, как и другим, обладающим предпринимательским стилем управления процессами, свойственна склонность к действию. Не сторонник долгих рассуждений о том, а получится ли? Ей проще проверить на деле. Старается всем и всегда помочь, причем, не словом, а делом. Хороший руководитель любого отдела, чья работа направлена на действия. Анализ же деятельности ей дается непросто. Как правило, люди данной категории обаятельны и добродушны. Легки на подъем и могут увлечь за собой коллектив. Легко находят общий язык с коллегами и родными. Однако очень эмоциональны, и это может делать их обидчивыми. Но очень отходчивы и готовы к самопожертвованию.\r\nОбожают детей и животных. \r\nВ работе, как правило, исполнительны, но немного своенравны, когда не до конца понимают смысл поставленной задачи. Немного робеют перед обладателями ярко выраженных гендерных дистрибутивов, но именно среди них часто находят друзей. Обладают хорошим чувством вкуса и стиля. Им можно доверить креативную и творческую работу, но это потребует дополнительного контроля, так как их быстрый и склонный к действиям ум может уводить их от  целей", "Предприниматель", "Наставник-предпренематель", "Заботливая " },
                    { new Guid("b29b2152-b6f1-45d7-a49d-902ca3530268"), "man", "Основой нестабильности данного типа личности является тот факт, что мысли его устремлены в будущее, но для уверенности в себе ему необходимо опираться на какие-то факты из прошлого. Это противоречие часто выбивает у него почву из-под ног. Если ещё рядом нет мудрого и отзывчивого наставника, то жизненный путь его может быть наполнен несправедливостью. Нестабильность эта также влияет и на усидчивость. Он может часто менять места работы в поисках чего-то лучшего. \r\nЛюбознателен и обладает живым умом. Зачастую, это творческая и любознательная натура, порой излишне сентиментальная и ранимая. Его не сложно обидеть, но он отходчив и добродушен. Может простить практически всё, иногда даже предательство.\r\nОчень исполнителен и готов браться за любую работу, но не всякая работа доставляет ему удовольствие. Не очень по душе ему бумажная работа, если она не носит творческий характер, или, например, процесс прямых продаж, когда нужно в чем-то убеждать клиента. Но он охотно взаимодействует с клиентами, когда дело касается, например, получения обратной связи или выявления потребности. И сделает он это весьма профессионально.", "Интегратор", "ишуший-Интегратор", "Ищущий" },
                    { new Guid("b72c0d38-0fe3-4a00-bef2-acb32789e086"), "man", "Талантлив, начитан, умён, но часто асоциален. Не любит больших компаний и шумных вечеринок. Пользуется успехом у женщин, но не особо увлекается новыми знакомствами. Загадочная и непредсказуемая личность. В его голове всегда есть далеко идущие планы, но о них он почти никогда не говорит. \r\nМожет с большой долей вероятности прогнозировать будущее, но делиться своими выводами не очень торопится, так как опасается, что кто-то может присвоить всю славу себе. \r\nДля него важно внешнее подтверждение его компетенций, но присущая ему скрытность мешает этому процессу реализоваться. И в этом противоречии его главный бич.\r\nЕсли перед компанией стоят стратегические задачи, которые не требуют командной работы, то он будет почти идеальным кандидатом для решения таких задач.\r\nНо не загоняйте его в жесткие временные или формулярные рамки, так как это может существенным образом снизить его эффективность.", "Интегратор", "охотник-Интегратор", "Охотник" },
                    { new Guid("bc01dd89-601d-4c4e-969f-2082b6833ffc"), "woman", "Исполнительный и старательный сотрудник, не часто проявляющий амбиции. Ей комфортнее усердно работать под чьим-то началом, нежели принимать решения и давать указания. Свободный график, скорее, будет ее угнетать, чем радовать. Но это очень дотошный исполнитель, поэтому в условиях цейтнота ее эффективность может снижаться. Ей обязательно нужно время, чтобы на несколько раз себя перепроверить. Процесс для нее гораздо важнее результата, поэтому ей гораздо комфортнее выполнять функции, ориентированные именно на процесс.  Учитывая любовь к порядку и зачастую природный навык работы с большим количеством данных, из людей такого типа получаются хорошие аудиторы, бухгалтеры, финансовые аналитики, а также программисты, задачи которых ориентированы преимущественно не на разработку нового кода, а на обработку большого количества информации. Вероятность ошибки в работе таких сотрудников крайне мала, поэтому если ей понятна задача, её работу можно не перепроверять.  По этой же причине лучшей похвалой для неё будет оценка её аккуратности, внимательности или, скажем, свойственной ей пунктуальности. Всё это может лечь в основу её нематериальной мотивации.", "Администратор", "ишуший-админестратор", "Познающая" },
                    { new Guid("c299418c-9304-4fa0-a681-ec09a95b123c"), "woman", "\"Заботливый производитель\" - что может быть лучше для выполнения производственных функций? Будь это связано с производством продукта либо услуги - любой процесс, имеющий в своей основе \"делание\" чего-то, что приносит понятный ей результат, будет отработан качественно и в срок. Однако, если результат или процесс его достижения до конца ей непонятен, то рабочий энтузиазм ее может значительно поугаснуть.\r\nЕсли доверить этому человеку управление производственным коллективом, работающим по заданному алгоритму и имеющим четкие задачи, то можно быть уверенным в том, что она создаст в нем душевную атмосферу, что, безусловно, повысит корпоративный дух, а соответственно, и эффективность труда. Однако следует понимать, что в случае разногласий между руководством и персоналом, вероятней всего, она встанет на сторону коллектива и будет усердно отстаивать его позицию.\r\nЭтот человек может помочь в создании действительно бережливого производства, но если ей доверить выполнение функций, не связанных непосредственно с производственными процессами, то важно также объяснить ей цели и задачи её деятельности. В процессах же, связанных, например, с творчеством, креативом, генерацией новых идей, или иных, не имеющих четких задач и целей, она, скорей всего, будет постоянно смещать фокус своего внимания на что-то ей понятное, где она может показать хоть какой-то результат.", "Производитель", "Наставник-производитель", "Заботливая " },
                    { new Guid("e2fb7ee4-614b-4cd5-b11e-e522a2d75e94"), "man", "Послушный и дисциплинированный сотрудник, особо не стремящийся к карьерному росту. Не то, чтобы карьера его совсем не интересовала, просто ему важнее другие вещи. Он может долго и досконально разбираться в процессах, в которых ему приходится вариться, пока не достигнет вершин мастерства. Среди таких типажей чаще всего встречаются люди, способные \"подковать блоху\". \r\nОщущает свою уникальность, но ещё сильнее ощущение того, что он может ещё лучше, и это часто мешает ему показать свой настоящий потенциал. Усерден в учении и хорош в бою, но не в качестве командира. Зачастую, именно таких ставят во главу небольших подразделений, но это, скорей, ограничивает его, чем мотивирует. Если такой человек попадает в продажи, то он может стать хорошим менеджером в процессах, алгоритмы которых понятны и просты, например, в оформлении сделок или обработке входящих заявок, но непредсказуемость в переговорах, к примеру, может ставить его в тупик. Тем не менее, это человек дела. Для него главное - ринуться быстрее в бой. Любые падения для него - настоящий вызов, поэтому предпочитает учиться на собственных ошибках", "Производитель", "ишуший-производитель", "Ищущий" },
                    { new Guid("e6eb1f77-a620-488a-aea7-ec2dba777a66"), "woman", "Хороший, исполнительный \"продажник\". Любит учиться всему, что подталкивает её к действию. Не приемлет жесткого контроля, но с удовольствием отдаст в чье-то ведение процессы, которые ей не по душе. Например, администрирование, связанное с оформлением сопроводительных и бухгалтерских документов. \r\nАналитика её утомляет, но она бессознательно понимает и принимает её важность. Однако, если её саму заставлять заниматься только аналитическими процессами, быстро теряет интерес и начинает выгорать. \r\nНеплохо чувствует себя в команде, где есть лидер, умеющий ставить задачи. Начинает действовать сразу, как только видит ближайшую цель. Ей постоянно нужно ощущение результата, поэтому на короткой дистанции она незаменима. Эдакий спринтер в продажах. Но длительный марафон её утомляет. Если цель далека и призрачна, то, вероятней всего, она будет действовать хаотично. В таком случае лучше разбить путь на этапы с промежуточными результатами, которые ей будут понятны. \r\nКоммуникабельна и всегда открыта к диалогу. Не выпячивает себя и поэтому неплохо уживается с любым коллективом. Порой, излишне проактивна, поэтому важно направить эту активность в правильное русло, и тогда можно добиться максимальной эффективности в её деятельности.", "Предприниматель", "ишуший-предпренематель", "Познающая" }
                });

            migrationBuilder.InsertData(
                table: "TextFields",
                columns: new[] { "Id", "CodeWord", "DateAdded", "Text", "Title", "TitleImagePath" },
                values: new object[,]
                {
                    { new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"), "PageDescription", new DateTime(2024, 7, 8, 12, 43, 7, 832, DateTimeKind.Utc).AddTicks(165), "Содержание заполняется администратором", "Описание теста", null },
                    { new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"), "PageIndex", new DateTime(2024, 7, 8, 12, 43, 7, 832, DateTimeKind.Utc).AddTicks(120), "Мы искренне рады видеть тебя и приглашаем в свое пространство! Спасибо, что откликнулся пройти наш авторский тест. Мы старались, чтобы тебе было комфортно и интересно \r\n Устраивайся поудобнее, включай любимую волну, поехали!", "Дорогой друг,", null },
                    { new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"), "PageTests", new DateTime(2024, 7, 8, 12, 43, 7, 832, DateTimeKind.Utc).AddTicks(152), "Содержание заполняется администратором", "Тесты", null },
                    { new Guid("8eae0a63-8f52-4160-a14e-b405e431a13b"), "PageContacts", new DateTime(2024, 7, 8, 12, 43, 7, 832, DateTimeKind.Utc).AddTicks(179), "Содержание заполняется администратором", "Контакты", null }
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
                name: "News");

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
