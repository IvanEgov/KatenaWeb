using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Katena.Migrations
{
    /// <inheritdoc />
    public partial class _intial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("29502787-ba92-410c-a4b0-b4ae9d2ad6e8"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ef37a3c2-7c96-4405-a971-7abcc91ac333",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7f0d4e70-0691-46b8-8649-b310ea660a3f", "AQAAAAIAAYagAAAAEBw1FZd2AuYnEmKikv/B++zX4bsG1yqIahptXnfM7v9TiEXkwmt2piPlAaKaomcp0w==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2024, 4, 1, 12, 51, 58, 946, DateTimeKind.Utc).AddTicks(5201));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2024, 4, 1, 12, 51, 58, 946, DateTimeKind.Utc).AddTicks(4941));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2024, 4, 1, 12, 51, 58, 946, DateTimeKind.Utc).AddTicks(5121));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("8eae0a63-8f52-4160-a14e-b405e431a13b"),
                column: "DateAdded",
                value: new DateTime(2024, 4, 1, 12, 51, 58, 946, DateTimeKind.Utc).AddTicks(5258));

            migrationBuilder.InsertData(
                table: "TextFields",
                columns: new[] { "Id", "CodeWord", "DateAdded", "Text", "Title" },
                values: new object[] { new Guid("24b7e371-eb5d-40ea-8dbc-0d3f18350c8b"), "Sidebar", new DateTime(2024, 4, 1, 12, 51, 58, 946, DateTimeKind.Utc).AddTicks(5317), "Содержание заполняется администратором", "Новости" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("24b7e371-eb5d-40ea-8dbc-0d3f18350c8b"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ef37a3c2-7c96-4405-a971-7abcc91ac333",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "71556450-b204-4793-9e85-9260008d2f62", "AQAAAAIAAYagAAAAEJonhQ/ETxxgfFyMZjHaNzKBfRQU9vJiH8O7VMQ8O1Od2p4nsMiV09RkOkUFrdnCog==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2024, 3, 31, 12, 0, 40, 555, DateTimeKind.Utc).AddTicks(4265));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2024, 3, 31, 12, 0, 40, 555, DateTimeKind.Utc).AddTicks(4127));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2024, 3, 31, 12, 0, 40, 555, DateTimeKind.Utc).AddTicks(4248));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("8eae0a63-8f52-4160-a14e-b405e431a13b"),
                column: "DateAdded",
                value: new DateTime(2024, 3, 31, 12, 0, 40, 555, DateTimeKind.Utc).AddTicks(4278));

            migrationBuilder.InsertData(
                table: "TextFields",
                columns: new[] { "Id", "CodeWord", "DateAdded", "Text", "Title" },
                values: new object[] { new Guid("29502787-ba92-410c-a4b0-b4ae9d2ad6e8"), "Sidebar", new DateTime(2024, 3, 31, 12, 0, 40, 555, DateTimeKind.Utc).AddTicks(4292), "Содержание заполняется администратором", "Новости" });
        }
    }
}
