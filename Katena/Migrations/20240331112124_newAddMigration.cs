using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Katena.Migrations
{
    /// <inheritdoc />
    public partial class newAddMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("d2f20dd3-56d9-4861-8af2-9a3e2541ed9d"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ef37a3c2-7c96-4405-a971-7abcc91ac333",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3cd64ead-5a56-436b-b0da-9fd418771fd4", "AQAAAAIAAYagAAAAEBSqiOPBOmkF2vApBXIf3lnE0uKQ0mWjyj0cFNZfKf8XyR1yp3yc962zaXidVqHsSw==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2024, 3, 31, 11, 21, 23, 967, DateTimeKind.Utc).AddTicks(4292));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2024, 3, 31, 11, 21, 23, 967, DateTimeKind.Utc).AddTicks(4251));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2024, 3, 31, 11, 21, 23, 967, DateTimeKind.Utc).AddTicks(4278));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("8eae0a63-8f52-4160-a14e-b405e431a13b"),
                column: "DateAdded",
                value: new DateTime(2024, 3, 31, 11, 21, 23, 967, DateTimeKind.Utc).AddTicks(4306));

            migrationBuilder.InsertData(
                table: "TextFields",
                columns: new[] { "Id", "CodeWord", "DateAdded", "Text", "Title" },
                values: new object[] { new Guid("9b7c30c3-8c39-4604-89bf-aca5297d4016"), "Sidebar", new DateTime(2024, 3, 31, 11, 21, 23, 967, DateTimeKind.Utc).AddTicks(4319), "Содержание заполняется администратором", "Новости" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("9b7c30c3-8c39-4604-89bf-aca5297d4016"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ef37a3c2-7c96-4405-a971-7abcc91ac333",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dd8a4726-9fdb-4bc1-91dd-3235797d7805", "AQAAAAIAAYagAAAAEARq+xSY5qGyynCBZxc6/hAjcQ4SuNJANKIp6ll7YudxMW1+ebqF9veYJ90P1NxGjg==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2024, 3, 31, 10, 15, 56, 717, DateTimeKind.Utc).AddTicks(2054));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2024, 3, 31, 10, 15, 56, 717, DateTimeKind.Utc).AddTicks(1909));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2024, 3, 31, 10, 15, 56, 717, DateTimeKind.Utc).AddTicks(1943));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("8eae0a63-8f52-4160-a14e-b405e431a13b"),
                column: "DateAdded",
                value: new DateTime(2024, 3, 31, 10, 15, 56, 717, DateTimeKind.Utc).AddTicks(2070));

            migrationBuilder.InsertData(
                table: "TextFields",
                columns: new[] { "Id", "CodeWord", "DateAdded", "Text", "Title" },
                values: new object[] { new Guid("d2f20dd3-56d9-4861-8af2-9a3e2541ed9d"), "Sidebar", new DateTime(2024, 3, 31, 10, 15, 56, 717, DateTimeKind.Utc).AddTicks(2084), "Содержание заполняется администратором", "Новости" });
        }
    }
}
