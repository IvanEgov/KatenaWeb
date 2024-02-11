using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Katena.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Action = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.Id);
                });

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
                name: "Packs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Instructions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuestionsIds = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResaultsId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Packs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnswerId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Resaults",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Style = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Resault = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resaults", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TextFields",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CodeWord = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TextFields", x => x.Id);
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
                table: "Answers",
                columns: new[] { "Id", "Action", "Reason", "Type", "Weight" },
                values: new object[,]
                {
                    { new Guid("01786293-47e4-407e-9c24-66591aa9e099"), "Постараюсь, не привлекая внимания окружающих, удалить пятно подручными средствами, а если это не получится, продолжу веселиться вместе с пятном", "Не думаю, что на подобной вечеринке мой канфуз будет сильно бросаться в глаза", "Mentor", 0.0 },
                    { new Guid("03b5d02c-aa7f-47b9-8b80-4bd984ce7906"), "Начну искать телефоны снабжающих организаций и выяснять причину отключения", "Надо вывалить на кого-то все зло, которое у меня накопилось", "Mentor", 0.0 },
                    { new Guid("0429066e-201f-4b2a-97fe-d15448bc4876"), "Do something", "To do something", "Genius", 0.0 },
                    { new Guid("1b08ffbf-6ae8-46b2-a058-10f742cbb3d4"), "Do something", "To do something", "Genius", 0.0 },
                    { new Guid("4c748f11-614c-4da8-97f2-eec8dc8ef989"), "Поеду домой переодеваться, а потом вернусь на вечеринку", "Я всегда выгляжу идеально и должен быть примером для других", "Hunter", 0.0 },
                    { new Guid("5ed2804d-bc6a-4296-b9a0-cf720271a18a"), "Накричу на него, заставлю извиняться", "Если бы подобных людей в моей жизни было бы меньше, я бы чувствовал себя лучше", "Hunter", 0.0 },
                    { new Guid("6afb4539-1a1c-44d5-ab1e-c8b29fbc2ddc"), "Настроение испорчено, уеду с вечеринки", "Никто не должен видеть меня в таком виде", "Finder", 0.0 },
                    { new Guid("6b39f0ec-0314-41c3-84f1-3b892bef6545"), "Do something", "To do something", "Genius", 0.0 },
                    { new Guid("9102a12d-2845-4224-939e-913ab96524ab"), "Плевать, не велика проблема", "Сейчас важнее не опаздать, а остальное -  мелочи", "Finder", 0.0 },
                    { new Guid("c407f32a-9fbf-486e-b744-c69f4961e58e"), "Do something", "To do something", "Genius", 0.0 },
                    { new Guid("cb83a258-54e1-4b2a-a58f-24fe95a357bc"), "Начну звонить соседям и выяснять у всех ли отключили", "Может, кто-то знает причину отключения", "Hunter", 0.0 },
                    { new Guid("e82f0359-d505-49f3-9292-f3877a9a844f"), "Это знак свыше, можно никуда сегодня не ходить, пойду спать дальше", "Вот, наконец-то, повод отлежаться дома", "GoodMan", 0.0 }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e8ec6f61-f6d0-4b1d-bbe4-5910f862b2bd", null, "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ef37a3c2-7c96-4405-a971-7abcc91ac333", 0, "870bf979-e3d1-46e3-bb6c-c35b27dd3754", "my@email.com", true, false, null, "MY@EMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAEAyzhz0nlrz7tT72cN0Zt544jWnP8Gl7ycXOTlSf727u2id1GWGbc7RWM7gUVwyjLA==", null, false, "", false, "admin" });

            migrationBuilder.InsertData(
                table: "Packs",
                columns: new[] { "Id", "Description", "Instructions", "Name", "QuestionsIds", "ResaultsId" },
                values: new object[] { new Guid("0ed29a4b-ea2d-426d-add2-22753c7bf8cb"), "A good test to get to know yourself", "Think", "Personality test", "[\"0dc6e45e-ba94-4f54-a59e-53caa1eea73c\",\"2b8ad992-d4aa-4c3f-a65e-aaf036260807\",\"2c517d36-d4db-4b02-b1c6-20b9c5eab29a\"]", "[\"959f07c9-5bd1-402c-9d29-c0cd3b5f954d\",\"cbed2409-359d-4425-9505-7434d6f75d79\",\"6662ee7c-34c8-4811-b3f3-ada6618dc47b\"]" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "AnswerId", "Name" },
                values: new object[,]
                {
                    { new Guid("0dc6e45e-ba94-4f54-a59e-53caa1eea73c"), "[\"cb83a258-54e1-4b2a-a58f-24fe95a357bc\",\"03b5d02c-aa7f-47b9-8b80-4bd984ce7906\",\"9102a12d-2845-4224-939e-913ab96524ab\",\"e82f0359-d505-49f3-9292-f3877a9a844f\"]", "Вы проснулись утром и поняли, что проспали сигнал будильника. Вы стремглав бежите в ванную и обнаруживаете, что в кране нет воды. Ни холодной, ни горячей. Ваши первые действия?" },
                    { new Guid("2b8ad992-d4aa-4c3f-a65e-aaf036260807"), "[\"5ed2804d-bc6a-4296-b9a0-cf720271a18a\",\"4c748f11-614c-4da8-97f2-eec8dc8ef989\",\"01786293-47e4-407e-9c24-66591aa9e099\",\"6afb4539-1a1c-44d5-ab1e-c8b29fbc2ddc\"]", "На корпоративе, к которому вы давно готовились, сосед случайно проливает на вас красное вино. Ваша первая реакция?" },
                    { new Guid("2c517d36-d4db-4b02-b1c6-20b9c5eab29a"), "[\"c407f32a-9fbf-486e-b744-c69f4961e58e\",\"0429066e-201f-4b2a-97fe-d15448bc4876\",\"6b39f0ec-0314-41c3-84f1-3b892bef6545\",\"1b08ffbf-6ae8-46b2-a058-10f742cbb3d4\"]", "Question from Jack Fresko?" }
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
                columns: new[] { "Id", "CodeWord", "Text", "Title" },
                values: new object[,]
                {
                    { new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"), "PageAbilities", "Содержание заполняется администратором", "Возможности" },
                    { new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"), "PageIndex", "Содержание заполняется администратором", "Главная" },
                    { new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"), "PageTests", "Содержание заполняется администратором", "Тесты" },
                    { new Guid("8eae0a63-8f52-4160-a14e-b405e431a13b"), "PageContacts", "Содержание заполняется администратором", "Контакты" }
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
