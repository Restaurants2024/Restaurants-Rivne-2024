using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UI.Migrations
{
    /// <inheritdoc />
    public partial class PhotoNewssss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e2ca9bc4-82e6-4509-b8fe-f661bee5dae0", "cca69993-4aaf-4d1c-ae04-3c64d327eb6d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "be2cfe8b-4647-4ad6-988b-1bd2ab808981", "4d90e3eb-7afa-48ba-b82b-93e3a4fa7c7b" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 12, 3, 22, 26, 55, 739, DateTimeKind.Local).AddTicks(8912));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 12, 4, 22, 26, 55, 739, DateTimeKind.Local).AddTicks(8984));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 12, 1, 22, 26, 55, 739, DateTimeKind.Local).AddTicks(9008));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 11, 30, 22, 26, 55, 739, DateTimeKind.Local).AddTicks(9012));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "38bc3136-cb8c-4906-a22a-0b72f423a8cc", "f20de84d-a391-44cc-81c6-6959b5347094" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a70d45cc-7f42-4ca2-845d-dc679efcad3d", "af0c425e-3761-4edc-8f9d-c39fa61a265e" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 12, 3, 21, 53, 58, 100, DateTimeKind.Local).AddTicks(5158));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 12, 4, 21, 53, 58, 100, DateTimeKind.Local).AddTicks(5232));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 12, 1, 21, 53, 58, 100, DateTimeKind.Local).AddTicks(5287));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 11, 30, 21, 53, 58, 100, DateTimeKind.Local).AddTicks(5295));
        }
    }
}
