using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UI.Migrations
{
    /// <inheritdoc />
    public partial class RatingDescriptionLinks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DescriptionRating",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LinksRating",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cc5a978a-219a-42a1-9383-6a06a987d9db", "6d82d247-665e-44f6-a17e-73ea416e6f52" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8beb2469-3fcd-4e43-bef2-067b7b23b608", "954d08bc-a532-4cff-8a16-883f55b1d6e7" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 12, 5, 12, 27, 41, 587, DateTimeKind.Local).AddTicks(4371));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 12, 6, 12, 27, 41, 587, DateTimeKind.Local).AddTicks(4434));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 12, 3, 12, 27, 41, 587, DateTimeKind.Local).AddTicks(4487));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 12, 2, 12, 27, 41, 587, DateTimeKind.Local).AddTicks(4494));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "<p> з 05.06.2024 (01:05) до 31.12.2024 (23:00)\r\n</p>Вирушайте у мандрівку у світ музичної насолоди та смачної кухні разом з SHEF😍 Кожної п’ятниці та суботи ми чекаємо на Вас з живою музикою та ідеальною атмосферою🤩.Забронюйте столик вже зараз та приходьте насолоджуватись хітами у виконанні найкращих наших виконавців. 🎤 <p>📞 Reserve: +38 (066) 300 01 77</p>\r\n                <p>📍 Location: Маршала Конева, 6</p>");

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: " <div class=\"menu-text\">\r\n<p>Заклад Kyiv Local Bar поблизу Контрактової площі запустив нове меню. За оновлення позицій відповідає команда шеф-кухаря Іллі Сьоміна (Pie Spot, «Спельта»).</p>\r\n                <h5>З меню:</h5>\r\n                <p>Бургери – 290–345 гривень</p>\r\n                <p>Мелти – 290–295 гривень</p>\r\n                <p>Гуакамоле з батутом фрі – 285 гривень</p>\r\n                <p>Корн-доги – 160 гривень</p>\r\n                <p>Курячі крильця – 220 гривень</p>\r\n                <p>Перці «Падрон» – 185 гривень</p>\r\n                <p>Фіш-енд-чипс – 290 гривень</p>\r\n            </div>\r\n\r\n            <!-- Зображення -->\r\n            <img src=\"https://cdn.village.com.ua/the-village.com.ua/post_image-image/GJk9C9vWwKw5XZk479fztw-article.png\" alt=\"Image\" class=\"menu-image\">\r\n        </div>\r\n\r\n        <p> «Нашим завданням було створити ідеальний фудпейрінг страв американського фастфуду й пива від нашої пивоварні Kyiv Local Brewery. До кожної страви ми підбираємо сорти локального пива, які підкреслюють смакові характеристики одне одного!» – розповідають The Village Україна в закладі.</p>\r\n\r\n        <p> Наприклад, у меню тепер є три фірмові дабл-чизбургери зі смеш-котлетами: класичний, із блакитним сиром і з беконом. «Також розробили дві позиції, що будуть до вподоби вегетеріанцям: гуакамоле з бататом фрі й перці «Падрон», смажені на грилі з пластівцями солі мелдон», – додають у команді.</p>\r\n    </div>");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DescriptionRating", "LinksRating" },
                values: new object[] { "Gusto - це більше ніж кафе,це інакше ніж ресторан.", "https://www.gusto.rv.ua" });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DescriptionRating", "LinksRating", "Stars" },
                values: new object[] { "Затишна атмосфера, цікаві декорації інтер’єру і сміливі дизайнерські рішення дозволять вам затишно провести свій час.", "https://gastropubfather.com", 5 });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DescriptionRating", "LinksRating" },
                values: new object[] { "Fortissimo – це оптимальний вибір для гостей міста, і затишний відпочинок для його постійних мешканців щодня. Яскравий та гармонійний смак.", "https://fortissimoroasters.com" });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DescriptionRating", "LinksRating" },
                values: new object[] { "New York Street Pizza – смачна гаряча їжа з швидкою доставкою, постійними акціями та новинками. Заклад-космополіт: тут створено усе, що може потребувати житель або гість міста.", "https://newyork.rivne.ua" });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DescriptionRating", "LinksRating" },
                values: new object[] { "Grill&Bar DVIR - ресторан затишної атмосфери та смачної кухні.", "https://grill-bar-dvir.choiceqr.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DescriptionRating",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "LinksRating",
                table: "Restaurants");

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

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Вирушайте у мандрівку у світ музичної насолоди та смачної кухні разом з SHEF😍 Кожної п’ятниці та суботи ми чекаємо на Вас з живою музикою та ідеальною атмосферою🤩.Забронюйте столик вже зараз та приходьте насолоджуватись хітами у виконанні найкращих наших виконавців. 🎤");

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: " <div class=\"menu-text\">\r\n                <p>Заклад Kyiv Local Bar поблизу Контрактової площі запустив нове меню. За оновлення позицій відповідає команда шеф-кухаря Іллі Сьоміна (Pie Spot, «Спельта»).</p>\r\n                <h5>З меню:</h5>\r\n                <p>Бургери – 290–345 гривень</p>\r\n                <p>Мелти – 290–295 гривень</p>\r\n                <p>Гуакамоле з батутом фрі – 285 гривень</p>\r\n                <p>Корн-доги – 160 гривень</p>\r\n                <p>Курячі крильця – 220 гривень</p>\r\n                <p>Перці «Падрон» – 185 гривень</p>\r\n                <p>Фіш-енд-чипс – 290 гривень</p>\r\n            </div>\r\n\r\n            <!-- Зображення -->\r\n            <img src=\"https://cdn.village.com.ua/the-village.com.ua/post_image-image/GJk9C9vWwKw5XZk479fztw-article.png\" alt=\"Image\" class=\"menu-image\">\r\n        </div>\r\n\r\n        <p> «Нашим завданням було створити ідеальний фудпейрінг страв американського фастфуду й пива від нашої пивоварні Kyiv Local Brewery. До кожної страви ми підбираємо сорти локального пива, які підкреслюють смакові характеристики одне одного!» – розповідають The Village Україна в закладі.</p>\r\n\r\n        <p> Наприклад, у меню тепер є три фірмові дабл-чизбургери зі смеш-котлетами: класичний, із блакитним сиром і з беконом. «Також розробили дві позиції, що будуть до вподоби вегетеріанцям: гуакамоле з бататом фрі й перці «Падрон», смажені на грилі з пластівцями солі мелдон», – додають у команді.</p>\r\n    </div>");

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 2,
                column: "Stars",
                value: 4);
        }
    }
}
