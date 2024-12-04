using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UI.Migrations
{
    /// <inheritdoc />
    public partial class Test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
                name: "Photo",
                table: "News",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)");

            migrationBuilder.AddColumn<string>(
                name: "ListItems",
                table: "News",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShortDescription",
                table: "News",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "News",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TitleBox",
                table: "News",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "213f63f1-7d65-438d-b260-d61d205a83fd", "97b15b2c-66f3-4751-8f1e-6f8282e0e10e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "47a45c9e-f291-41c6-aa9e-08f1d517df60", "a4d03675-7802-49f8-9242-c001d26afdb3" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 12, 3, 18, 12, 41, 372, DateTimeKind.Local).AddTicks(1543));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 12, 4, 18, 12, 41, 372, DateTimeKind.Local).AddTicks(1604));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 12, 1, 18, 12, 41, 372, DateTimeKind.Local).AddTicks(1623));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 11, 30, 18, 12, 41, 372, DateTimeKind.Local).AddTicks(1626));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "Description", "ListItems", "Photo", "ShortDescription", "Title", "TitleBox" },
                values: new object[] { new DateTime(2024, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Вирушайте у мандрівку у світ музичної насолоди та смачної кухні разом з SHEF😍 Кожної п’ятниці та суботи ми чекаємо на Вас з живою музикою та ідеальною атмосферою🤩.Забронюйте столик вже зараз та приходьте насолоджуватись хітами у виконанні найкращих наших виконавців. 🎤", null, null, "Жива музика в ресторані SHEF кожну Пт та Сб Вирушайте у мандрівку у світ музичної насолоди та смачної кухні разом з SHEF😍 Кожної п’ятниці та суботи ми чекаємо на Вас з живою музикою та ідеальною атмосферою🤩.", "Live music", "Жива музика в ресторані SHEF кожну Пт та Сб" });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "Description", "ListItems", "Photo", "ShortDescription", "Title", "TitleBox" },
                values: new object[] { new DateTime(2024, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "	<p>\r\n					Окуніться в кулінарну подорож кожної неділі з безлімітним SEAFOOD BRUNCH у Forrest Club,\r\n					який стартує 14 квітня. З 11:00 до 16:00 гості можуть насолоджуватися необмеженою кількістю делікатесів з\r\n					морепродуктів, доповнених безлімітним prosecco і aperol spritz.\r\n				</p>\r\n\r\n				<p>Меню безлімітного бранчу з морепродуктами:</p>\r\n				<ul>\r\n					<li><span></span>Prosecco</li>\r\n					<li><span></span>Aperol Spritz</li>\r\n					<li><span></span>Устриці</li>\r\n					<li><span></span>Фокача з оливами</li>\r\n					<li><span></span>Злакові чипси</li>\r\n					<li><span></span>Смажені оливи з в'яленими томатами</li>\r\n					<li><span></span>Великий зелений салат Forrest Club</li>\r\n					<li><span></span>Тартар з лосося в листі ромен</li>\r\n					<li><span></span>Креветки Панко</li>\r\n					<li><span></span>Крокети з щучою ікрою</li>\r\n					<li><span></span>Гострий суп SEAFOOD</li>\r\n					<li><span></span>Піца з креветками</li>\r\n					<li><span></span>Фрегола з морепродуктами</li>\r\n					<li><span></span>Сувлакі з судака з соусом лемонграс</li>\r\n				</ul>\r\n				<p>\r\n					Протягом літнього сезону, SEAFOOD BRUNCH стає щотижневою недільною родзинкою,\r\n					з необмеженим просекко, устрицями та стравами з морепродуктів.\r\n					Відчуйте привабливість безлімітних морепродуктів і атмосферного розташування біля озера у Forrest Club,\r\n					де кожна неділя перетворюється на справжнє свято смаку.\r\n				</p>\r\n				<p><strong>Reserve:</strong> +38 (099) 234 01 77</p>", null, null, "Окуніться в кулінарну подорож кожної неділі з безлімітним SEAFOOD BRUNCH у Forrest Club, який стартує 14 квітня...\r\n", "Unlimіted food", "Безлімітний SEAFOOD BRUNCH у Forrest Club" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ListItems",
                table: "News");

            migrationBuilder.DropColumn(
                name: "ShortDescription",
                table: "News");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "News");

            migrationBuilder.DropColumn(
                name: "TitleBox",
                table: "News");

            migrationBuilder.AlterColumn<byte[]>(
                name: "Photo",
                table: "News",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0],
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ac32ff6b-0ee4-41b2-8cad-191bee6c6613", "52a32516-2c8b-4531-9dd7-f68ac4b58866" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "799abe07-8d0e-492f-82ba-06d9b4ab585b", "e79988f1-e8d8-4677-a2db-4de869a26048" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 12, 3, 13, 33, 44, 594, DateTimeKind.Local).AddTicks(151));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 12, 4, 13, 33, 44, 594, DateTimeKind.Local).AddTicks(203));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 12, 1, 13, 33, 44, 594, DateTimeKind.Local).AddTicks(220));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 11, 30, 13, 33, 44, 594, DateTimeKind.Local).AddTicks(223));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Date", "Description", "Photo" },
                values: new object[] { new DateTime(2024, 11, 22, 13, 33, 44, 594, DateTimeKind.Local).AddTicks(235), "Restaurant A is opening soon!", new byte[] { 0, 0, 0, 0, 0 } });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Date", "Description", "Photo" },
                values: new object[] { new DateTime(2024, 11, 27, 13, 33, 44, 594, DateTimeKind.Local).AddTicks(238), "New menu in Restaurant B!", new byte[] { 0, 0, 0, 0, 0 } });
        }
    }
}
