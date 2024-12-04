using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UI.Migrations
{
    /// <inheritdoc />
    public partial class ShortGusto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "60f23168-1b36-4001-a9f5-f5aff1a0e734", "1cb33b83-dcf0-4097-98ed-122d77631ede" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "82636f4b-4f61-4a76-a5da-4f929f960ee1", "2120d643-4737-4ff0-9822-642e077ecc70" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 12, 3, 11, 47, 0, 678, DateTimeKind.Local).AddTicks(7555));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 12, 4, 11, 47, 0, 678, DateTimeKind.Local).AddTicks(7611));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 12, 1, 11, 47, 0, 678, DateTimeKind.Local).AddTicks(7631));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 11, 30, 11, 47, 0, 678, DateTimeKind.Local).AddTicks(7634));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 11, 22, 11, 47, 0, 678, DateTimeKind.Local).AddTicks(7648));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 11, 27, 11, 47, 0, 678, DateTimeKind.Local).AddTicks(7651));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1,
                column: "ShortDescription",
                value: "Gusto - це авторські страви свропейської та японської кухні з унікальним методом приготування. Це ексклюзивна алкогольна карта та меню авторських і класичних коктейлів. Це кайкращі рецепти домашніх десертів зібрані з різних куточки світу.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "521f33bf-1fca-46f7-a6e6-192ce2ea3c7c", "a011f46d-cea8-4751-93a5-ac58afb29230" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "72852449-5763-44e4-b1df-7c8d5f6f4e98", "6280af6a-20e6-44e5-bd9e-dbcee9d12c9b" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 12, 3, 11, 39, 29, 436, DateTimeKind.Local).AddTicks(2436));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 12, 4, 11, 39, 29, 436, DateTimeKind.Local).AddTicks(2491));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 12, 1, 11, 39, 29, 436, DateTimeKind.Local).AddTicks(2508));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 11, 30, 11, 39, 29, 436, DateTimeKind.Local).AddTicks(2512));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 11, 22, 11, 39, 29, 436, DateTimeKind.Local).AddTicks(2526));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 11, 27, 11, 39, 29, 436, DateTimeKind.Local).AddTicks(2529));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1,
                column: "ShortDescription",
                value: "Gusto – перший космополітичний заклад у Рівному формату gastro salon, місце зустрічі однодумців, тих, хто вважає основною метою життя – насолода у всіх її проявах.");
        }
    }
}
