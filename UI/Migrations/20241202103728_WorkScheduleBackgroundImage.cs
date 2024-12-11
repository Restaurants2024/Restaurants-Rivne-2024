using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UI.Migrations
{
    /// <inheritdoc />
    public partial class WorkScheduleBackgroundImage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BackgroundImagePath",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "WorkSchedule",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1a893685-dca7-439f-af9c-445d8fd62c19", "8ff6f156-9042-4809-b975-57b91b2ec758" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c58588bd-fea0-4245-b546-753fbd0fa585", "c4279adf-223c-4e1e-a9f3-e16530691208" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 12, 3, 12, 37, 28, 567, DateTimeKind.Local).AddTicks(5240));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 12, 4, 12, 37, 28, 567, DateTimeKind.Local).AddTicks(5295));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 12, 1, 12, 37, 28, 567, DateTimeKind.Local).AddTicks(5313));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 11, 30, 12, 37, 28, 567, DateTimeKind.Local).AddTicks(5316));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 11, 22, 12, 37, 28, 567, DateTimeKind.Local).AddTicks(5330));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 11, 27, 12, 37, 28, 567, DateTimeKind.Local).AddTicks(5333));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BackgroundImagePath", "WorkSchedule" },
                values: new object[] { "wwwroot/media/background/gustoback.jpg", " Пн.–Пт.: з 11:00 до 24:00\r\n                    Сб., Нд.: з 12:00 до 24:00" });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BackgroundImagePath", "WorkSchedule" },
                values: new object[] { "wwwroot/media/background/fatherback.jpg", " Графік роботи: Пн.-Чт.,Нд.: 12:00–00:00\r\n                    Пт.-Сб.: 12:00-02:00" });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BackgroundImagePath", "WorkSchedule" },
                values: new object[] { "wwwroot/media/background/fortissimoback.jpg", "08:00-22:30" });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BackgroundImagePath", "WorkSchedule" },
                values: new object[] { "wwwroot/media/background/new york back.jpg", "Пн.-Нд.: 10:00-22:00" });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BackgroundImagePath", "WorkSchedule" },
                values: new object[] { "wwwroot/media/background/dvirback.jpg", "Пн.-Чт. 10:00-21:45, Пт.-Нд. 10:00-22:45" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BackgroundImagePath",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "WorkSchedule",
                table: "Restaurants");

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
        }
    }
}
