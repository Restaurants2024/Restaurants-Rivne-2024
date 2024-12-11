using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UI.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThirdName = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                name: "News",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Photo = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Restaurants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PointX = table.Column<double>(type: "float", nullable: false),
                    PointY = table.Column<double>(type: "float", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Photo = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Stars = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    FavoriteLinks = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelNum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurants", x => x.Id);
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
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
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
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
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

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TableNum = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RestaurantId = table.Column<int>(type: "int", nullable: false),
                    PersonId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bookings_AspNetUsers_PersonId",
                        column: x => x.PersonId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bookings_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Feedbacks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RestaurantId = table.Column<int>(type: "int", nullable: false),
                    TableNum = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Feedbacks_AspNetUsers_PersonId",
                        column: x => x.PersonId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Feedbacks_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "ThirdName", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "e45a087d-2b12-4dc6-a6aa-9e5bf856e494", "user1@example.com", false, false, null, "John", "USER1@EXAMPLE.COM", "USER1", "testpasswordhash", null, false, "8a22978e-3628-4fc5-9b30-4aa6bdd63a3e", "Doe", "Smith", false, "user1" },
                    { "2", 0, "302b8f63-976d-42dd-969e-bbaf233f3886", "user2@example.com", false, false, null, "Jane", "USER2@EXAMPLE.COM", "USER2", "testpasswordhash", null, false, "ad7e917b-c221-426a-8d97-5f6ca50d6d98", "Smith", "Doe", false, "user2" }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "Date", "Description", "Photo" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 21, 16, 22, 23, 775, DateTimeKind.Local).AddTicks(9410), "Restaurant A is opening soon!", new byte[] { 0, 0, 0, 0, 0 } },
                    { 2, new DateTime(2024, 11, 26, 16, 22, 23, 775, DateTimeKind.Local).AddTicks(9412), "New menu in Restaurant B!", new byte[] { 0, 0, 0, 0, 0 } }
                });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "Address", "Description", "FavoriteLinks", "Photo", "PointX", "PointY", "Stars", "TelNum", "Title" },
                values: new object[,]
                {
                    { 1, "просп. Миру, 10", " Gusto – перший космополітичний заклад у Рівному формату gastro salon, місце зустрічі однодумців, тих, хто вважає основною метою життя – насолода у всіх її проявах. Для тебе тут поєднали найяскравіші смаки страв із чудовими напоями, створили затишну атмосферу, доклали максимум зусиль, щоб звичайне задоволення від їжі перетворити на ейфорію.", "https://grill-bar-dvir.choiceqr.com/", new byte[] { 0, 0, 0, 0, 0 }, 50.624509699999997, 26.244995299999999, 5, "+38(095) 471 00 31", "Ресторан \"Gusto gastro salon\"" },
                    { 2, "вул. Степана Бандери 24А", "Gastropub Father відчинив свої двері в 2016 році. Концепцією закладу є виготовлення крафтового пива. Любителі смачної кухні можуть сповна насолодитися стравами англо-британської кухні. Особливостями нашого меню є 6 видів крафтового пива, два сорти з яких у 2020 році здобули перше та друге місце на конкурсі EAST EUROPEAN BEER AWARD 2020. Заклад приємно порадує великою різноманітністю страв: салати, смачні супи, м’ясні та рибні страви, птиця, закуски а також неповторні десерти. Затишна атмосфера, цікаві декорації інтер’єру і сміливі дизайнерські рішення дозволять вам затишно провести свій час. У барному меню вас чекає широкий асортимент алкогольних коктейлів і безалкогольних напоїв, що дозволить знайти ідеальний варіант для кожного гостя. На вихідних в закладі грає жива музика, транслюються футбольні матчі. Ви неодмінно залишитеся задоволені і побажаєте знову повернутися в gastropub Father .\"", "https://gastropubfather.com/", new byte[] { 0, 0, 0, 0, 0 }, 50.613010099999997, 26.254899399999999, 4, "+38(097) 559 55 50", "Гастропаб \"Father\"" },
                    { 3, "вул. 16 Липня, 7a", "У ресторані \"Fortissimo\" представлені різноманітні алкогольні напої та коктейльні композиції. Крім того можна смачно поїсти, оскільки в меню широкий вибір салатів, гарячих і холодних страв. Авторська кухня американського та європейського зразку. Оскільки ресторан працює цілодобово - він відповідає ритму життя динамічного містечка західної України.", "https://fortissimo.choiceqr.com/", new byte[] { 0, 0, 0, 0, 0 }, 50.450000000000003, 30.52, 5, "+38(097) 898 15 51", "Автентичний стріт-бар \"Fortissimo\"" },
                    { 4, "вул. Княгині Ольги, 1а", "New York Street Pizza\" (ТЦ \"Покровський\") – яскравий та стильний заклад всеукраїнської мережі, що знаходиться у мальовничому куточку міста поблизу центрального парку. Приємне світло, теплий дизайн та зручна зональність створюють надзвичайну затишну атмосферу в закладі, доповнену ароматом свіжоспеченої піци та кави. На першому поверсі – столики для двох та дивани для довгих посиденьок, а також банкетна зала. На другому поверсі гостям відкривається панорама міста. В теплу пору року можна займати місця на терасі. Щодня в закладі подають сніданки, в обідню пору можна замовити комплекс: на вибір українська або японська кухня.", "https://nysp.com.ua/menu-rest", new byte[] { 0, 0, 0, 0, 0 }, 50.618630000000003, 26.245721700000001, 4, "+38 (068) 007 00 72", "Ресторан \"Nеw York Strееt Pіzzа\"" },
                    { 5, "вул. Симона Петлюри, 3", "Ресторан гриль-бар \"Dvir\" розташований у центральній частині міста Рівного. Має унікальний інтер'єр та розташування, створюючи особливу атмосферу для своїх гостей. Пропонує своїм відвідувачам страви української та європейської кухонь, а також великий вибір напоїв на будь-який смак. Привітний персонал забезпечить якісний сервіс. У закладі є дуже велика та затишна літня тераса, де приємно посидіти з друзями або в сімейному колі.\r\n", "https://grill-bar-dvir.choiceqr.com/", new byte[] { 0, 0, 0, 0, 0 }, 50.620991199999999, 26.245221600000001, 4, "+38 (068) 072 40 46", "Grill&Bar DVIR" }
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "Date", "PersonId", "RestaurantId", "TableNum" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 12, 2, 16, 22, 23, 775, DateTimeKind.Local).AddTicks(9330), "1", 1, 1 },
                    { 2, new DateTime(2024, 12, 3, 16, 22, 23, 775, DateTimeKind.Local).AddTicks(9379), "2", 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "Id", "Date", "PersonId", "RestaurantId", "TableNum", "Text" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 30, 16, 22, 23, 775, DateTimeKind.Local).AddTicks(9392), "1", 1, 1, "Great food!" },
                    { 2, new DateTime(2024, 11, 29, 16, 22, 23, 775, DateTimeKind.Local).AddTicks(9396), "2", 2, 2, "Nice ambiance!" }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_PersonId",
                table: "Bookings",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_RestaurantId",
                table: "Bookings",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_PersonId",
                table: "Feedbacks",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_RestaurantId",
                table: "Feedbacks",
                column: "RestaurantId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Feedbacks");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Restaurants");
        }
    }
}
