using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UI.Migrations
{
    /// <inheritdoc />
    public partial class WithoutBackImage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BackgroundImagePath",
                table: "Restaurants");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1d3ae04b-2fe4-4726-a247-8dee51d40f51", "502754d9-d858-4fc3-a712-9b05a9943712" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8cf39992-598b-48db-9a7b-b9eab747f6e9", "1d0aaddd-7194-4884-a11a-1fafc981c064" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 12, 3, 13, 27, 34, 81, DateTimeKind.Local).AddTicks(8348));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 12, 4, 13, 27, 34, 81, DateTimeKind.Local).AddTicks(8392));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 12, 1, 13, 27, 34, 81, DateTimeKind.Local).AddTicks(8405));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 11, 30, 13, 27, 34, 81, DateTimeKind.Local).AddTicks(8408));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 11, 22, 13, 27, 34, 81, DateTimeKind.Local).AddTicks(8421));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 11, 27, 13, 27, 34, 81, DateTimeKind.Local).AddTicks(8424));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Title", "WorkSchedule" },
                values: new object[] { "Gusto gastro salon", " Пн.–Пт.: з 11:00 до 24:00 Сб., Нд.: з 12:00 до 24:00" });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 2,
                column: "WorkSchedule",
                value: "Пн.-Чт.,Нд.: 12:00–00:00\r\n                    Пт.-Сб.: 12:00-02:00");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 4,
                column: "Title",
                value: "Nеw York Strееt Pіzzа");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BackgroundImagePath",
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
                columns: new[] { "BackgroundImagePath", "Title", "WorkSchedule" },
                values: new object[] { "wwwroot/media/background/gustoback.jpg", "Ресторан \"Gusto gastro salon\"", " Пн.–Пт.: з 11:00 до 24:00\r\n                    Сб., Нд.: з 12:00 до 24:00" });

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
                column: "BackgroundImagePath",
                value: "wwwroot/media/background/fortissimoback.jpg");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BackgroundImagePath", "Title" },
                values: new object[] { "wwwroot/media/background/new york back.jpg", "Ресторан \"Nеw York Strееt Pіzzа\"" });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 5,
                column: "BackgroundImagePath",
                value: "wwwroot/media/background/dvirback.jpg");
        }
    }
}
