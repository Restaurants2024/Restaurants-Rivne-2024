using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UI.Migrations
{
    /// <inheritdoc />
    public partial class Reviews : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1eac38a4-da1d-4dcf-bba0-8dbe095a73e2", "1fae3275-0b6b-4cc5-92aa-55a00aca6bcd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a0dddf2c-73a5-4366-8b61-ac2902f39109", "ead1a877-f20a-442e-b987-5679d4e64b14" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "baf8cb20-7291-4ebc-b67a-f3bd7c583245", "a3ca6431-30c1-48f0-9437-fbe399230da8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9a4032b0-2e60-4143-942f-44a28e63ca42", "bed01789-b99f-4ed5-af21-3f21dc189271" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1f6f3c95-4070-40a2-9326-5584c10541f4", "3064adc8-e88c-433e-b5ec-e612786fd564" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 12, 7, 12, 12, 11, 685, DateTimeKind.Local).AddTicks(897));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 12, 8, 12, 12, 11, 685, DateTimeKind.Local).AddTicks(984));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 12, 5, 12, 12, 11, 685, DateTimeKind.Local).AddTicks(1035));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 12, 4, 12, 12, 11, 685, DateTimeKind.Local).AddTicks(1042));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 12, 3, 12, 12, 11, 685, DateTimeKind.Local).AddTicks(1045));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 12, 2, 12, 12, 11, 685, DateTimeKind.Local).AddTicks(1048));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 12, 1, 12, 12, 11, 685, DateTimeKind.Local).AddTicks(1050));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 11, 30, 12, 12, 11, 685, DateTimeKind.Local).AddTicks(1053));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2024, 11, 29, 12, 12, 11, 685, DateTimeKind.Local).AddTicks(1056));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2024, 11, 28, 12, 12, 11, 685, DateTimeKind.Local).AddTicks(1058));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2024, 11, 27, 12, 12, 11, 685, DateTimeKind.Local).AddTicks(1061));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2024, 11, 26, 12, 12, 11, 685, DateTimeKind.Local).AddTicks(1063));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2024, 11, 25, 12, 12, 11, 685, DateTimeKind.Local).AddTicks(1066));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2024, 11, 24, 12, 12, 11, 685, DateTimeKind.Local).AddTicks(1069));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2024, 11, 23, 12, 12, 11, 685, DateTimeKind.Local).AddTicks(1084));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2024, 11, 22, 12, 12, 11, 685, DateTimeKind.Local).AddTicks(1087));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2024, 11, 21, 12, 12, 11, 685, DateTimeKind.Local).AddTicks(1089));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 16,
                column: "Date",
                value: new DateTime(2024, 11, 20, 12, 12, 11, 685, DateTimeKind.Local).AddTicks(1092));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2024, 11, 19, 12, 12, 11, 685, DateTimeKind.Local).AddTicks(1094));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 18,
                column: "Date",
                value: new DateTime(2024, 11, 18, 12, 12, 11, 685, DateTimeKind.Local).AddTicks(1097));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 19,
                column: "Date",
                value: new DateTime(2024, 11, 17, 12, 12, 11, 685, DateTimeKind.Local).AddTicks(1100));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 20,
                column: "Date",
                value: new DateTime(2024, 11, 16, 12, 12, 11, 685, DateTimeKind.Local).AddTicks(1102));

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "Id", "Date", "PersonId", "RestaurantId", "Text" },
                values: new object[,]
                {
                    { 21, new DateTime(2024, 11, 15, 12, 12, 11, 685, DateTimeKind.Local).AddTicks(1105), "1", 1, "Ресторан \"Gusto gastro salon\" перевершив всі мої очікування! Атмосфера чудова, кухня неперевершена.!" },
                    { 22, new DateTime(2024, 11, 14, 12, 12, 11, 685, DateTimeKind.Local).AddTicks(1107), "2", 1, "У \"Gusto gastro salon\" затишно і смачно, але ціни трохи вищі, ніж очікувалося. Загалом сподобалося!" },
                    { 23, new DateTime(2024, 11, 13, 12, 12, 11, 685, DateTimeKind.Local).AddTicks(1110), "3", 1, "\"Gusto gastro salon\" - ідеальне місце для тих, хто хоче швидко і смачно перекусити. Рекомендую!" },
                    { 24, new DateTime(2024, 11, 12, 12, 12, 11, 685, DateTimeKind.Local).AddTicks(1112), "4", 1, "\"Gusto gastro salon\" має чудову атмосферу, але обслуговування могло б бути кращим. Їжа на високому рівні." },
                    { 25, new DateTime(2024, 11, 11, 12, 12, 11, 685, DateTimeKind.Local).AddTicks(1115), "5", 1, "\"Gusto gastro salon\" - це любов з першого погляду. Ресторан із чудовою атмосферою та відмінною кухнею." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "54a534dc-972a-4448-be64-bb1c931b0bbf", "dee07582-2c1f-4e5c-9df9-f1a6226fe3b1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2b3079c7-bbb6-4354-9c3a-e6542feb1a77", "8f9a4431-4b78-467c-b81f-9d883b9ede2e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "879b437e-dff9-4a75-97b8-faba40ab513f", "b5b26c15-e7b8-4f69-8b73-9afadc19e73d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4cad1d88-860f-42c5-a1e4-fbd75fa4eda9", "4faee1a9-95b2-4de4-939e-3dfcc7c4e903" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cb1f2044-2eaf-4cd8-97fc-31153508a93e", "3807824c-d9e4-40f5-8a39-ddd3e0945801" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 12, 6, 23, 30, 19, 564, DateTimeKind.Local).AddTicks(173));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 12, 7, 23, 30, 19, 564, DateTimeKind.Local).AddTicks(250));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 12, 4, 23, 30, 19, 564, DateTimeKind.Local).AddTicks(1302));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 12, 3, 23, 30, 19, 564, DateTimeKind.Local).AddTicks(1312));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 12, 2, 23, 30, 19, 564, DateTimeKind.Local).AddTicks(1314));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 12, 1, 23, 30, 19, 564, DateTimeKind.Local).AddTicks(1319));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 11, 30, 23, 30, 19, 564, DateTimeKind.Local).AddTicks(1321));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 11, 29, 23, 30, 19, 564, DateTimeKind.Local).AddTicks(1323));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2024, 11, 28, 23, 30, 19, 564, DateTimeKind.Local).AddTicks(1324));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2024, 11, 27, 23, 30, 19, 564, DateTimeKind.Local).AddTicks(1326));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2024, 11, 26, 23, 30, 19, 564, DateTimeKind.Local).AddTicks(1328));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2024, 11, 25, 23, 30, 19, 564, DateTimeKind.Local).AddTicks(1330));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2024, 11, 24, 23, 30, 19, 564, DateTimeKind.Local).AddTicks(1332));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2024, 11, 23, 23, 30, 19, 564, DateTimeKind.Local).AddTicks(1334));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2024, 11, 22, 23, 30, 19, 564, DateTimeKind.Local).AddTicks(1336));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2024, 11, 21, 23, 30, 19, 564, DateTimeKind.Local).AddTicks(1338));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2024, 11, 20, 23, 30, 19, 564, DateTimeKind.Local).AddTicks(1340));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 16,
                column: "Date",
                value: new DateTime(2024, 11, 19, 23, 30, 19, 564, DateTimeKind.Local).AddTicks(1342));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2024, 11, 18, 23, 30, 19, 564, DateTimeKind.Local).AddTicks(1344));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 18,
                column: "Date",
                value: new DateTime(2024, 11, 17, 23, 30, 19, 564, DateTimeKind.Local).AddTicks(1345));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 19,
                column: "Date",
                value: new DateTime(2024, 11, 16, 23, 30, 19, 564, DateTimeKind.Local).AddTicks(1347));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 20,
                column: "Date",
                value: new DateTime(2024, 11, 15, 23, 30, 19, 564, DateTimeKind.Local).AddTicks(1350));
        }
    }
}
