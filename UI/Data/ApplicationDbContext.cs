using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Security.Principal;
using UI.Models;

namespace UI.Data
{
	public class ApplicationDbContext : IdentityDbContext<Person>
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}

		public DbSet<Restaurant> Restaurants { get; set; }
		public DbSet<Booking> Bookings { get; set; }
		public DbSet<Feedback> Feedbacks { get; set; }
		public DbSet<News> News { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);


			// Зв'язки для таблиці Booking
			modelBuilder.Entity<Booking>()
				.HasOne(b => b.Restaurant)
				.WithMany(r => r.Bookings)
				.HasForeignKey(b => b.RestaurantId)
				.OnDelete(DeleteBehavior.Cascade);

			modelBuilder.Entity<Booking>()
				.HasOne(b => b.Person)
				.WithMany(u => u.Bookings)
				.HasForeignKey(b => b.PersonId);

			// Зв'язки для таблиці Feedback
			modelBuilder.Entity<Feedback>()
				.HasOne(f => f.Restaurant)
				.WithMany(r => r.Feedbacks)
				.HasForeignKey(f => f.RestaurantId)
				.OnDelete(DeleteBehavior.Cascade);

			modelBuilder.Entity<Feedback>()
				.HasOne(f => f.Person)
				.WithMany(u => u.Feedbacks)
				.HasForeignKey(f => f.PersonId);

			// Налаштування полів Restaurant
			modelBuilder.Entity<Restaurant>()
				.Property(r => r.Title)
				.IsRequired()
				.HasMaxLength(100);

			modelBuilder.Entity<Restaurant>()
				.Property(r => r.Description)
				.HasMaxLength(2000);

			// Ініціалізація тестових даних

			modelBuilder.Entity<Restaurant>().HasData(
				new Restaurant
				{
					Id = 1,
					PointX = 50.6245097,
					PointY = 26.2449953,
					Title = "\"Gusto gastro salon\"",
					Description = " Gusto – перший космополітичний заклад у Рівному формату gastro salon, місце зустрічі однодумців, тих, хто вважає основною метою життя – насолода у всіх її проявах. Для тебе тут поєднали найяскравіші смаки страв із чудовими напоями, створили затишну атмосферу, доклали максимум зусиль, щоб звичайне задоволення від їжі перетворити на ейфорію.",
					TelNum = "+38(095) 471 00 31",
					Address = "просп. Миру, 10",
					FavoriteLinks = "https://grill-bar-dvir.choiceqr.com/",
					ShortDescription = "Gusto - це авторські страви свропейської та японської кухні з унікальним методом приготування. Це ексклюзивна алкогольна карта та меню авторських і класичних коктейлів. Це кайкращі рецепти домашніх десертів зібрані з різних куточки світу.",
					Stars = 5,
					WorkSchedule = " Пн.–Пт.: з 11:00 до 24:00 Сб., Нд.: з 12:00 до 24:00",
					DescriptionRating = "Gusto - це більше ніж кафе,це інакше ніж ресторан.",
					LinksRating = "https://www.gusto.rv.ua",
					Photo = File.ReadAllBytes("wwwroot/media/restaurants/gusto.jpg")
				},
				new Restaurant
				{
					Id = 2,
					PointX = 50.6130101,
					PointY = 26.2548994,
					Title = "Гастропаб \"Father\"",
					Description = "Gastropub Father відчинив свої двері в 2016 році. Концепцією закладу є виготовлення крафтового пива. Любителі смачної кухні можуть сповна насолодитися стравами англо-британської кухні. Особливостями нашого меню є 6 видів крафтового пива, два сорти з яких у 2020 році здобули перше та друге місце на конкурсі EAST EUROPEAN BEER AWARD 2020. Заклад приємно порадує великою різноманітністю страв: салати, смачні супи, м’ясні та рибні страви, птиця, закуски а також неповторні десерти. Затишна атмосфера, цікаві декорації інтер’єру і сміливі дизайнерські рішення дозволять вам затишно провести свій час. У барному меню вас чекає широкий асортимент алкогольних коктейлів і безалкогольних напоїв, що дозволить знайти ідеальний варіант для кожного гостя. На вихідних в закладі грає жива музика, транслюються футбольні матчі. Ви неодмінно залишитеся задоволені і побажаєте знову повернутися в gastropub Father .\"",
					TelNum = "+38(097) 559 55 50",
					Address = "вул. Степана Бандери 24А",
					FavoriteLinks = "https://gastropubfather.com/",
					ShortDescription = " Міні-пивоварня ресторанного типу гастропаб \"Father\". Тут встановлено обладнання від угорської компанії «ZIP Technologies», на якому на сьогоднішній день варять чотири сорти пива. Крім того, Ви тут поласуйте різноманітними стравами на будь-який смак і поринете в неповторну атмосферу закладу, відволікши себе від рутинної метушні.",
					Stars = 5,
					WorkSchedule = "Пн.-Чт.,Нд.: 12:00–00:00\r\n                    Пт.-Сб.: 12:00-02:00",
					DescriptionRating = "Затишна атмосфера, цікаві декорації інтер’єру і сміливі дизайнерські рішення дозволять вам затишно провести свій час.",
					LinksRating = "https://gastropubfather.com",
					Photo = File.ReadAllBytes("wwwroot/media/restaurants/father.jpg")
				},

				new Restaurant
				{
					Id = 3,
					PointX = 50.45,
					PointY = 30.52,
					Title = "Автентичний стріт-бар \"Fortissimo\"",
					Description = "У ресторані \"Fortissimo\" представлені різноманітні алкогольні напої та коктейльні композиції. Крім того можна смачно поїсти, оскільки в меню широкий вибір салатів, гарячих і холодних страв. Авторська кухня американського та європейського зразку. Оскільки ресторан працює цілодобово - він відповідає ритму життя динамічного містечка західної України.",
					TelNum = "+38(097) 898 15 51",
					Address = "вул. 16 Липня, 7a",
					FavoriteLinks = "https://fortissimo.choiceqr.com/",
					ShortDescription = "У Fortissimo представлені унікальні алкогольні напої та коктейльні композиції і авторська кухня американського та європейського зразку. Цілодобовий режим роботи зобов'язує нас працювати у ритмі життя динамічного містечка західної України. Fortissimo – це оптимальний вибір для гостей міста, і затишний відпочинок для його постійних мешканців щодня.\r\n",
					Stars = 5,
					WorkSchedule = "08:00-22:30",
					DescriptionRating = "Fortissimo – це оптимальний вибір для гостей міста, і затишний відпочинок для його постійних мешканців щодня. Яскравий та гармонійний смак.",
					LinksRating = "https://fortissimoroasters.com",
					Photo = File.ReadAllBytes("wwwroot/media/restaurants/fortissimo.jpg")
				},

				new Restaurant
				{
					Id = 4,
					PointX = 50.61863,
					PointY = 26.2457217,
					Title = "\"Nеw York Strееt Pіzzа\"",
					Description = "New York Street Pizza\" (ТЦ \"Покровський\") – яскравий та стильний заклад всеукраїнської мережі, що знаходиться у мальовничому куточку міста поблизу центрального парку. Приємне світло, теплий дизайн та зручна зональність створюють надзвичайну затишну атмосферу в закладі, доповнену ароматом свіжоспеченої піци та кави. На першому поверсі – столики для двох та дивани для довгих посиденьок, а також банкетна зала. На другому поверсі гостям відкривається панорама міста. В теплу пору року можна займати місця на терасі. Щодня в закладі подають сніданки, в обідню пору можна замовити комплекс: на вибір українська або японська кухня.",
					TelNum = "+38 (068) 007 00 72",
					Address = "вул. Княгині Ольги, 1а",
					FavoriteLinks = "https://nysp.com.ua/menu-rest",
					ShortDescription = "New York Street Pizza – смачна гаряча їжа з швидкою доставкою, постійними акціями та новинками. Заклад-космополіт: тут створено усе, що може потребувати житель або гість міста.\r\n",
					Stars = 4,
					WorkSchedule = "Пн.-Нд.: 10:00-22:00",
					DescriptionRating = "New York Street Pizza – смачна гаряча їжа з швидкою доставкою, постійними акціями та новинками. Заклад-космополіт: тут створено усе, що може потребувати житель або гість міста.",
					LinksRating = "https://newyork.rivne.ua",
					Photo = File.ReadAllBytes("wwwroot/media/restaurants/new york street pizza.jpg")
				},
				new Restaurant
				{
					Id = 5,
					PointX = 50.6209912,
					PointY = 26.2452216,
					Title = "\"Grill&Bar DVIR\"",
					Description = "Ресторан гриль-бар \"Dvir\" розташований у центральній частині міста Рівного. Має унікальний інтер'єр та розташування, створюючи особливу атмосферу для своїх гостей. Пропонує своїм відвідувачам страви української та європейської кухонь, а також великий вибір напоїв на будь-який смак. Привітний персонал забезпечить якісний сервіс. У закладі є дуже велика та затишна літня тераса, де приємно посидіти з друзями або в сімейному колі.\r\n",
					TelNum = "+38 (068) 072 40 46",
					Address = "вул. Симона Петлюри, 3",
					FavoriteLinks = "https://grill-bar-dvir.choiceqr.com/",
					ShortDescription = "Ресторан гриль-бар \"Dvir\" розташований у центральній частині міста Рівного. Має унікальний інтер'єр та розташування, створюючи особливу атмосферу для своїх гостей.\r\n",
					Stars = 4,
					WorkSchedule = "Пн.-Чт. 10:00-21:45, Пт.-Нд. 10:00-22:45",
					DescriptionRating = "Grill&Bar DVIR - ресторан затишної атмосфери та смачної кухні.",
					LinksRating = "https://grill-bar-dvir.choiceqr.com",
					Photo = File.ReadAllBytes("wwwroot/media/restaurants/dvir.jpg")
				}
		   );






			modelBuilder.Entity<News>().HasData(
				new News
				{
					Id = 1,
					Title = "Live music",
					Description = "<p> з 05.06.2024 (01:05) до 31.12.2024 (23:00)\r\n</p>Вирушайте у мандрівку у світ музичної насолоди та смачної кухні разом з SHEF😍 Кожної п’ятниці та суботи ми чекаємо на Вас з живою музикою та ідеальною атмосферою\U0001f929.Забронюйте столик вже зараз та приходьте насолоджуватись хітами у виконанні найкращих наших виконавців. 🎤 <p>📞 Reserve: +38 (066) 300 01 77</p>\r\n                <p>📍 Location: Маршала Конева, 6</p>",
					ShortDescription = "Жива музика в ресторані SHEF кожну Пт та Сб Вирушайте у мандрівку у світ музичної насолоди та смачної кухні разом з SHEF😍 Кожної п’ятниці та суботи ми чекаємо на Вас з живою музикою та ідеальною атмосферою🤩.",
					Photo = System.IO.File.ReadAllBytes("wwwroot/media/news/music.jpg"), // Шлях до зображення
					TitleBox = "Жива музика в ресторані SHEF кожну Пт та Сб",
					Date = new DateTime(2024, 08, 8)
				},
				new News
				{
					Id = 2,
					Title = "Unlimіted food",
					Description = "\t<p>\r\n\t\t\t\t\tОкуніться в кулінарну подорож кожної неділі з безлімітним SEAFOOD BRUNCH у Forrest Club,\r\n\t\t\t\t\tякий стартує 14 квітня. З 11:00 до 16:00 гості можуть насолоджуватися необмеженою кількістю делікатесів з\r\n\t\t\t\t\tморепродуктів, доповнених безлімітним prosecco і aperol spritz.\r\n\t\t\t\t</p>\r\n\r\n\t\t\t\t<p>Меню безлімітного бранчу з морепродуктами:</p>\r\n\t\t\t\t<ul>\r\n\t\t\t\t\t<li><span></span>Prosecco</li>\r\n\t\t\t\t\t<li><span></span>Aperol Spritz</li>\r\n\t\t\t\t\t<li><span></span>Устриці</li>\r\n\t\t\t\t\t<li><span></span>Фокача з оливами</li>\r\n\t\t\t\t\t<li><span></span>Злакові чипси</li>\r\n\t\t\t\t\t<li><span></span>Смажені оливи з в'яленими томатами</li>\r\n\t\t\t\t\t<li><span></span>Великий зелений салат Forrest Club</li>\r\n\t\t\t\t\t<li><span></span>Тартар з лосося в листі ромен</li>\r\n\t\t\t\t\t<li><span></span>Креветки Панко</li>\r\n\t\t\t\t\t<li><span></span>Крокети з щучою ікрою</li>\r\n\t\t\t\t\t<li><span></span>Гострий суп SEAFOOD</li>\r\n\t\t\t\t\t<li><span></span>Піца з креветками</li>\r\n\t\t\t\t\t<li><span></span>Фрегола з морепродуктами</li>\r\n\t\t\t\t\t<li><span></span>Сувлакі з судака з соусом лемонграс</li>\r\n\t\t\t\t</ul>\r\n\t\t\t\t<p>\r\n\t\t\t\t\tПротягом літнього сезону, SEAFOOD BRUNCH стає щотижневою недільною родзинкою,\r\n\t\t\t\t\tз необмеженим просекко, устрицями та стравами з морепродуктів.\r\n\t\t\t\t\tВідчуйте привабливість безлімітних морепродуктів і атмосферного розташування біля озера у Forrest Club,\r\n\t\t\t\t\tде кожна неділя перетворюється на справжнє свято смаку.\r\n\t\t\t\t</p>\r\n\t\t\t\t<p><strong>Reserve:</strong> +38 (099) 234 01 77</p>",
					ShortDescription = "Окуніться в кулінарну подорож кожної неділі з безлімітним SEAFOOD BRUNCH у Forrest Club, який стартує 14 квітня...\r\n",
					Photo = System.IO.File.ReadAllBytes("wwwroot/media/news/unlimfood.jpg"), // Шлях до зображення
					TitleBox = "Безлімітний SEAFOOD BRUNCH у Forrest Club",
					Date = new DateTime(2024, 12, 2)
				},

				 new News
				 {
					 Id = 3,
					 Title = "Restaurant event",
					 Description = " <img src=\"https://reston.ua/images/img/salt_kyiv_649_03_11_2023_1.jpg\" alt=\"Image\" style=\"width: 600px; display: block; margin: 20px auto 0;\">\r\n        <p>Одноденна інтерактивна подія, яка ознайомила з усіма трендами розвитку ресторанної індустрії, надала практичну, корисну інформацію для трансформації бізнесу та поділилась історіями успіху провідних компаній.</p>\r\n        <p> Вперше у Києві на \"SALT: Restaurant Innovation Conference\" був представлений новий, повністю електричний автомобіль BMW I5. Учасники та гості конференції змогли першими познайомитись з новітніми технологіями.</p>\r\n        <p>Офіційно відкрив конференцію засновник та CEO HOTELIERO, Національної Премії \"СІЛЬ\" та SALT: Restaurant Innovation Conferece - Андрій Скіп’ян, а зі вступною промовою виступив ресторатор та візіонер Премії \"СІЛЬ\" Савелій Лібкін.</p>\r\n        <img src=\"https://posteat.ua/wp-content/uploads/2023/11/IMG_1492-600x401.jpg\" alt=\"Image\" style=\"width: 600px; display: block; margin: 20px auto 0;\">\r\n        <img src=\"https://reston.ua/images/img/salt_kyiv_649_03_11_2023_5.jpg\" alt=\"Image\" style=\"width: 600px; display: block; margin: 10px auto 0;\">\r\n        <p>\r\n            На конференції кожен спікер поділився своїм цінним досвідом та спробував розширити світогляд на бізнес. Серед них:\r\n        </p>\r\n        <ul style=\"list-style-type: none; font-family: Arial, sans-serif; font-size: 16px;\">\r\n            <li style=\"display: flex; align-items: center; margin-bottom: 5px;\">\r\n                <span style=\"width: 8px; height: 8px;  border-radius: 50%; display: inline-block; margin-right: 10px;\"></span>\r\n                1. Співзасновник Monobank Михайло Рогальський, який розповів про новий проєкт Expirienza 2.0 та його особливості: як обирати заклади за стравами, створювати списки улюблених страв та додавати продукти, на які є алергія.\r\n            </li>\r\n            <li style=\"display: flex; align-items: center; margin-bottom: 5px;\">\r\n                <span style=\"width: 8px; height: 8px;  border-radius: 50%; display: inline-block; margin-right: 10px;\"></span>\r\n                2. Андрій Длігач про те, як ресторани стають трендами ком‘юніті, наскільки складною залишається ситуація з ресторанною індустрією та на чому будуватиметься маркетинг.\r\n            </li>\r\n            <li style=\"display: flex; align-items: center; margin-bottom: 5px;\">\r\n                <span style=\"width: 8px; height: 8px; border-radius: 50%; display: inline-block; margin-right: 10px;\"></span>\r\n                3. Тарас Маселко з темою: \"Тенденції з життя холдингу емоцій \"!FEST\". Про тенденції в часі воєнного стану, освіту, івенти, виробництва і масштабування бізнесу\". Гості конференції дізнались, як змінився формат заходів під час війни та як це проводити івенти в укритті.\r\n            </li>\r\n            <li style=\"display: flex; align-items: center; margin-bottom: 5px;\">\r\n                <span style=\"width: 8px; height: 8px; border-radius: 50%; display: inline-block; margin-right: 10px;\"></span>\r\n                4. Євгеній Таллер співвласник ресторанів \"Ministry of...\" поділився ідеями, як залучити інфлюенсерів до взаємодії з бізнесом.\r\n            </li>\r\n            <li style=\"display: flex; align-items: center; margin-bottom: 5px;\">\r\n                <span style=\"width: 8px; height: 8px;  border-radius: 50%; display: inline-block; margin-right: 10px;\"></span>\r\n                5. Головна директорка \"Glovo Ukraine\" Марина Павлюк виступила з темою \"Тенденції фудтек, як можливості для рестораторів: віртуальні бренди, хмарні кухні, швидка доставка та нові споживчі звички українців\".\r\n            </li>\r\n            <li style=\"display: flex; align-items: center; margin-bottom: 5px;\">\r\n                <span style=\"width: 8px; height: 8px;  border-radius: 50%; display: inline-block; margin-right: 10px;\"></span>\r\n                6. Олександр Краковецький відкрив блок \"Технології та софт\", висвітлив реальні кейси використання ШІ в ресторанній індустрії та детально розповів чому всі говорять про ШІ.\r\n            </li>\r\n            <li style=\"display: flex; align-items: center; margin-bottom: 5px;\">\r\n                <span style=\"width: 8px; height: 8px;  border-radius: 50%; display: inline-block; margin-right: 10px;\"></span>\r\n                7. Великий зелений салат Forrest Club\r\n            </li>\r\n            <li style=\"display: flex; align-items: center; margin-bottom: 5px;\">\r\n                <span style=\"width: 8px; height: 8px;  border-radius: 50%; display: inline-block; margin-right: 10px;\"></span>\r\n                8. CEO та співвласник компанії Servio Soft - Ігор Гречко, у своїй доповіді розкрив тему діджиталізації, онлайн сервісів для збільшення прибутку та як досягти найкращого за допомогою сучасного програмного забезпечення.\r\n            <li style=\"display: flex; align-items: center; margin-bottom: 5px;\">\r\n                <span style=\"width: 8px; height: 8px;  border-radius: 50%; display: inline-block; margin-right: 10px;\"></span>\r\n                9. Радниця офісу з розвитку підприємництва та експорту Анна Міленіна поділилась, як правильно підготувати грантову заявку, на що звертати увагу та яких помилок слід уникати, аби отримати цікавий грант.\r\n            </li>\r\n            <li style=\"display: flex; align-items: center; margin-bottom: 5px;\">\r\n                <span style=\"width: 8px; height: 8px;  border-radius: 50%; display: inline-block; margin-right: 10px;\"></span>\r\n                10. Жорж Піонов презентував свій новий проєкт про освіту та розповів навіщо ресторанному бізнесу потрібні інновації.\r\n            </li>\r\n        </ul>\r\n        <img src=\"https://yizhakultura.com/uploads/images/materials/full/20231105_1622_001.JPG\" alt=\"Image\" style=\"width: 600px; display: block; margin: 20px auto 0;\">\r\n        <p>Також, на конференцію був запрошений спеціальний гість з Британії - Чарльз Бенкс, кофаундер провідної трендвочінг агенції The Food People, який розповів про топ 10 трендів 2023/2024 років, серед яких \"Вартість приготування\", \"Точна ферментація\", \"Назад до основ\", \"Новий клімат&культура\" та інші.</p>\r\n        <img src=\"https://www.saltconference.com.ua/wp-content/uploads/2024/11/kopyya1117-scaled.jpg\" alt=\"Image\" style=\"width: 600px; display: block; margin: 20px auto 0;\">\r\n        <img src=\"https://md.ua/storage/editor/fotos/a4ede478cddde6800aa6fd2b6cabf704.jpg\" alt=\"Image\" style=\"width: 600px; display: block; margin: 20px auto 0;\">\r\n        <p>Ольга Руднєва, Олена Вдовиченко та Олексій Волошин в рамках дискусійній панелі \"Інклюзивність\" підняли надважливу тему сьогодення, як інтегрувати Суперлюдину в заклади ресторанної індустрії, щоб вона почувалась комфортно.</p>\r\n        <p>\r\n            Також, SALT: Restaurant Innovation Conference підтримали соціальну ініціативу Superhumans Center, перевівши туди частину свого прибутку отриманого з продажу квитків.\r\n        </p>",
					 ShortDescription = " 30 жовтня у КВЦ \"Парковий\" відбувся захід \"SALT: Restaurant Innovation Conference\" від HOTELIERO про сучасні ресторанні тенденції та інновації, який відвідало понад 500-та гостей.",
					 Photo = System.IO.File.ReadAllBytes("wwwroot/media/news/event.jpg"), // Шлях до зображення
					 TitleBox = "30 жовтня у Києві відбувся захід \"SALT: Restaurant Innovation Conference\"",
					 Date = new DateTime(2024, 12, 1)
				 },
				 new News
				 {
					 Id = 4,
					 Title = "Pizza based on an AI recipe",
					 Description = " <p>Мережа ресторанів 1708 Pizza dі Napoli готує піцу за рецептом, який створив штучний інтелект ChatGPT.</p>\r\n        <img src=\"https://cdn.village.com.ua/the-village.com.ua/post_image-image/E2XcVl_64QfVt4FatZlH5Q.jpg\" alt=\"Image\" style=\"width: 300px; display: block; margin: 20px auto 0;\">\r\n        <p>«Нещодавно команда обговорювала зі штучним інтелектом, яку страву можна створити й додати в меню, зважаючи на концепт і географію мережі. Штучний інтелект СhatGPT придумав піцу Futuro. Шеф-кухар підтримав ідею, тому таку інноваційну піцу вже можна куштувати в закладах мережі у Львові й Києві», – каже керуючий партнер мережі 1708 Володимир Гнатюк.</p>\r\n        <img src=\"https://cdn.village.com.ua/the-village.com.ua/post_image-image/YxlhUirBaL6xngsqxGRIUw.jpg\" alt=\"Image\" style=\"width: 300px; display: block; margin: 20px auto 0;\">\r\n        <p>\r\n            Штучний інтелект склав рецепт піци, який включає томатний соус, пепероні, моцарелу, карамелізовану цибулю, вʼялені томати, руколу й пікантний козячий сир.\r\n\r\n            «Естетична й смачна страва, де поєднується солодкий, солоний, гострий і вершковий смаки. Ці поєднання підходять для гурманів, які люблять складні смаки», – підкреслює шеф-кухар закладу.\r\n        </p>\r\n        <hr>\r\n\r\n        <p> Піцерія 1708 Pizza Di Napoli – це новий формат від власників мережі Lviv Croissants з неаполітанським варіантом піци. Заклади мережі є в Києві і Львові. </p>\r\n    </div>",
					 ShortDescription = "Ресторани української мережі 1708 Pizza dі Napoli готують піцу за рецептом штучного інтелекту.\r\n",
					 Photo = System.IO.File.ReadAllBytes("wwwroot/media/news/pizzaAI.jpg"), // Шлях до зображення
					 TitleBox = " Ресторани української мережі 1708 Pizza dі Napoli готують піцу за рецептом штучного інтелекту",
					 Date = new DateTime(2024, 12, 2)
				 },
				 new News
				 {
					 Id = 5,
					 Title = "Beer for dogs",
					 Description = " <div class=\"menu-text\">\r\n<p>Заклад Kyiv Local Bar поблизу Контрактової площі запустив нове меню. За оновлення позицій відповідає команда шеф-кухаря Іллі Сьоміна (Pie Spot, «Спельта»).</p>\r\n                <h5>З меню:</h5>\r\n                <p>Бургери – 290–345 гривень</p>\r\n                <p>Мелти – 290–295 гривень</p>\r\n                <p>Гуакамоле з батутом фрі – 285 гривень</p>\r\n                <p>Корн-доги – 160 гривень</p>\r\n                <p>Курячі крильця – 220 гривень</p>\r\n                <p>Перці «Падрон» – 185 гривень</p>\r\n                <p>Фіш-енд-чипс – 290 гривень</p>\r\n            </div>\r\n\r\n            <!-- Зображення -->\r\n            <img src=\"https://cdn.village.com.ua/the-village.com.ua/post_image-image/GJk9C9vWwKw5XZk479fztw-article.png\" alt=\"Image\" class=\"menu-image\">\r\n        </div>\r\n\r\n        <p> «Нашим завданням було створити ідеальний фудпейрінг страв американського фастфуду й пива від нашої пивоварні Kyiv Local Brewery. До кожної страви ми підбираємо сорти локального пива, які підкреслюють смакові характеристики одне одного!» – розповідають The Village Україна в закладі.</p>\r\n\r\n        <p> Наприклад, у меню тепер є три фірмові дабл-чизбургери зі смеш-котлетами: класичний, із блакитним сиром і з беконом. «Також розробили дві позиції, що будуть до вподоби вегетеріанцям: гуакамоле з бататом фрі й перці «Падрон», смажені на грилі з пластівцями солі мелдон», – додають у команді.</p>\r\n    </div>",
					 ShortDescription = "Тепер у пивному барі Kyiv Local Bar: є чизбургери й пиво для собак.",
					 Photo = System.IO.File.ReadAllBytes("wwwroot/media/news/dog.jpg"), // Шлях до зображення
					 TitleBox = "Шеф-кухар Ілля Сьомін оновив меню пивного бару Kyiv Local Bar: тепер є чизбургери й пиво для собак",
					 Date = new DateTime(2024, 12, 2)
				 }
		   );


			// Додавання тестових користувачів
			modelBuilder.Entity<Person>().HasData(
				new Person { Id = "1", UserName = "user1", Email = "user1@example.com", Surname = "Власюк", Name = "Іван", ThirdName = "Іванович", NormalizedUserName = "USER1", NormalizedEmail = "USER1@EXAMPLE.COM", PasswordHash = "testpasswordhash" },
				new Person { Id = "2", UserName = "user2", Email = "user2@example.com", Surname = "Андрощук", Name = "Олена", ThirdName = "Петрівна", NormalizedUserName = "USER2", NormalizedEmail = "USER2@EXAMPLE.COM", PasswordHash = "testpasswordhash" },
                new Person { Id = "3", UserName = "user3", Email = "user3@example.com", Surname = "Яценюк", Name = "Андрій", ThirdName = "Володимирович", NormalizedUserName = "USER3", NormalizedEmail = "USER3@EXAMPLE.COM", PasswordHash = "testpasswordhash" },
                new Person { Id = "4", UserName = "user4", Email = "user4@example.com", Surname = "Кучма", Name = "Микола", ThirdName = "Генадійович", NormalizedUserName = "USER4", NormalizedEmail = "USER4@EXAMPLE.COM", PasswordHash = "testpasswordhash" },
                new Person { Id = "5", UserName = "user5", Email = "user5@example.com", Surname = "Дорошенко", Name = "Олександр", ThirdName = "Федорович", NormalizedUserName = "USER5", NormalizedEmail = "USER5@EXAMPLE.COM", PasswordHash = "testpasswordhash" }
            );

			// Додавання тестових бронювань
			modelBuilder.Entity<Booking>().HasData(
				new Booking { Id = 1, TableNum = 1, Date = DateTime.Now.AddDays(1), RestaurantId = 1, PersonId = "1" },
				new Booking { Id = 2, TableNum = 2, Date = DateTime.Now.AddDays(2), RestaurantId = 2, PersonId = "2" }
			);

			// Додавання тестових відгуків
			modelBuilder.Entity<Feedback>().HasData(
				new Feedback { Id = 1, Text = "Ресторан \"Father\" перевершив всі мої очікування! Атмосфера чудова, кухня неперевершена.!", Date = DateTime.Now.AddDays(-1), RestaurantId = 2, PersonId = "1" },
                new Feedback { Id = 2, Text = "У \"Father\" затишно і смачно, але ціни трохи вищі, ніж очікувалося. Загалом сподобалося!", Date = DateTime.Now.AddDays(-2), RestaurantId = 2, PersonId = "2" },
                new Feedback { Id = 3, Text = "\"Father\" - ідеальне місце для тих, хто хоче швидко і смачно перекусити. Рекомендую!!", Date = DateTime.Now.AddDays(-3), RestaurantId = 2, PersonId = "3" },
                new Feedback { Id = 4, Text = "\"Father\" має чудову атмосферу, але обслуговування могло б бути кращим. Їжа на високому рівні.", Date = DateTime.Now.AddDays(-4), RestaurantId = 2, PersonId = "4" },
                new Feedback { Id = 5, Text = "\"Father\" - це любов з першого погляду. Ресторан із чудовою атмосферою та відмінною кухнею.", Date = DateTime.Now.AddDays(-5), RestaurantId = 2, PersonId = "5" },
                new Feedback { Id = 6, Text = "Ресторан \"Fortissimo\" перевершив всі мої очікування! Атмосфера чудова, кухня неперевершена.!", Date = DateTime.Now.AddDays(-6), RestaurantId = 3, PersonId = "1" },
                new Feedback { Id = 7, Text = "У \"Fortissimo\" затишно і смачно, але ціни трохи вищі, ніж очікувалося. Загалом сподобалося!", Date = DateTime.Now.AddDays(-7), RestaurantId = 3, PersonId = "2" },
                new Feedback { Id = 8, Text = "\"Fortissimo\" - ідеальне місце для тих, хто хоче швидко і смачно перекусити. Рекомендую!", Date = DateTime.Now.AddDays(-8), RestaurantId = 3, PersonId = "3" },
                new Feedback { Id = 9, Text = "\"Fortissimo\" має чудову атмосферу, але обслуговування могло б бути кращим. Їжа на високому рівні.", Date = DateTime.Now.AddDays(-9), RestaurantId = 3, PersonId = "4" },
                new Feedback { Id = 10, Text = "\"Fortissimo\" - це любов з першого погляду. Ресторан із чудовою атмосферою та відмінною кухнею.", Date = DateTime.Now.AddDays(-10), RestaurantId = 3, PersonId = "5" },
                new Feedback { Id = 11, Text = "Ресторан \"Nеw York Strееt Pіzzа\" перевершив всі мої очікування! Атмосфера чудова, кухня неперевершена.", Date = DateTime.Now.AddDays(-11), RestaurantId = 4, PersonId = "1" },
                new Feedback { Id = 12, Text = "У \"Nеw York Strееt Pіzzа\" затишно і смачно, але ціни трохи вищі, ніж очікувалося. Загалом сподобалося!", Date = DateTime.Now.AddDays(-12), RestaurantId = 4, PersonId = "2" },
                new Feedback { Id = 13, Text = "\"Nеw York Strееt Pіzzа\" - ідеальне місце для тих, хто хоче швидко і смачно перекусити. Рекомендую!!", Date = DateTime.Now.AddDays(-13), RestaurantId = 4, PersonId = "3" },
                new Feedback { Id = 14, Text = "\"Nеw York Strееt Pіzzа\" має чудову атмосферу, але обслуговування могло б бути кращим. Їжа на високому рівні!", Date = DateTime.Now.AddDays(-14), RestaurantId = 4, PersonId = "4" },
                new Feedback { Id = 15, Text = "\"Nеw York Strееt Pіzzа\" - це любов з першого погляду. Ресторан із чудовою атмосферою та відмінною кухнею.", Date = DateTime.Now.AddDays(-15), RestaurantId = 4, PersonId = "5" },
                new Feedback { Id = 16, Text = "Ресторан \"Grill&Bar DVIR\" перевершив всі мої очікування! Атмосфера чудова, кухня неперевершена.", Date = DateTime.Now.AddDays(-16), RestaurantId = 5, PersonId = "1" },
                new Feedback { Id = 17, Text = "У \"Grill&Bar DVIR\" затишно і смачно, але ціни трохи вищі, ніж очікувалося. Загалом сподобалося!", Date = DateTime.Now.AddDays(-17), RestaurantId = 5, PersonId = "2" },
                new Feedback { Id = 18, Text = "\"Grill&Bar DVIR\" - ідеальне місце для тих, хто хоче швидко і смачно перекусити. Рекомендую!", Date = DateTime.Now.AddDays(-18), RestaurantId = 5, PersonId = "3" },
                new Feedback { Id = 19, Text = "\"Grill&Bar DVIR\" має чудову атмосферу, але обслуговування могло б бути кращим. Їжа на високому рівні.", Date = DateTime.Now.AddDays(-19), RestaurantId = 5, PersonId = "4" },
                new Feedback { Id = 20, Text = "\"Grill&Bar DVIR\" - це любов з першого погляду. Ресторан із чудовою атмосферою та відмінною кухнею.", Date = DateTime.Now.AddDays(-20), RestaurantId = 5, PersonId = "5" },
                 new Feedback { Id = 21, Text = "Ресторан \"Gusto gastro salon\" перевершив всі мої очікування! Атмосфера чудова, кухня неперевершена.!", Date = DateTime.Now.AddDays(-21), RestaurantId = 1, PersonId = "1" },
                new Feedback { Id = 22, Text = "У \"Gusto gastro salon\" затишно і смачно, але ціни трохи вищі, ніж очікувалося. Загалом сподобалося!", Date = DateTime.Now.AddDays(-22), RestaurantId = 1, PersonId = "2" },
                new Feedback { Id = 23, Text = "\"Gusto gastro salon\" - ідеальне місце для тих, хто хоче швидко і смачно перекусити. Рекомендую!", Date = DateTime.Now.AddDays(-23), RestaurantId = 1, PersonId = "3" },
                new Feedback { Id = 24, Text = "\"Gusto gastro salon\" має чудову атмосферу, але обслуговування могло б бути кращим. Їжа на високому рівні.", Date = DateTime.Now.AddDays(-24), RestaurantId = 1, PersonId = "4" },
                new Feedback { Id = 25, Text = "\"Gusto gastro salon\" - це любов з першого погляду. Ресторан із чудовою атмосферою та відмінною кухнею.", Date = DateTime.Now.AddDays(-25), RestaurantId = 1, PersonId = "5" }

            );



		}

	}
}
