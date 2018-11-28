using Model.DB;

namespace DAL.Migrations
{
	using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
	using Common.Enum;
	internal sealed class Configuration : DbMigrationsConfiguration<DAL.MainContext>
	{
		public Configuration()
		{
			AutomaticMigrationsEnabled = false;
		}

		protected override void Seed(DAL.MainContext context)
		{
			//  This method will be called after migrating to the latest version.
			Role role = new Role() { Id = 1, Name = "Administrator", Description = "Application administrator" };
			Role role_user = new Role() { Id = 2, Name = "User", Description = "Application user" };
			var  user = new User() { Id = 1, Email = "admin@admin.admin", UserName = "admin", Password = "password", Role = role };
			var  user2 = new User() { Id = 2, Email = "user@admin.admin", UserName = "user", Password = "qwert22y", Role = role };

            #region cat1
            Category cat1 = new Category() {
				Name = "Медикаменти",
				OrderNo = 1,
                Id = 1
			};
            Category cat1Son1 = new Category()
            {
                Name = "Препарати від застуди",
                ParentCategory = cat1,
                OrderNo = 1,
                Id = 2
            };
            Category cat1Son2 = new Category()
            {
                Name = "Знеболюючі засоби",
                ParentCategory = cat1,
                OrderNo = 2,
                Id = 3
            };
            Category cat1Son1Son = new Category()
            {
                Name = "Препарати при сухому кашлю",
                ParentCategory = cat1Son1,
                OrderNo = 1,
                Id = 4
            };
            #endregion
            #region cat2
            Category cat2 = new Category() {
				Name = "Бади та вітаміни",
				OrderNo = 2,
                Id = 5
            };
            Category cat2Son1 = new Category()
            {
                Name = "Бади для серця та сосудів",
                ParentCategory = cat2,
                OrderNo = 1,
                Id = 6
            };
            Category cat2Son2 = new Category()
            {
                Name = "Вітаміни для очей",
                ParentCategory = cat2,
                OrderNo = 2,
                Id = 7
            };
            #endregion
            #region cat3
            Category cat3 = new Category()
            {
                Name = "Антибіотики",
                OrderNo = 3,
                Id = 8
            };
            Category cat3Son1 = new Category()
            {
                Name = "Антибіотики в дерматології",
                ParentCategory = cat3,
                OrderNo = 1,
                Id = 9
            };
            Category cat3Son2 = new Category()
            {
                Name = "Антибіотики для дітей",
                ParentCategory = cat3,
                OrderNo = 2,
                Id = 10
            };
            #endregion
            #region cat4
            Category cat4 = new Category()
            {
                Name = "Товари для косметологів",
                OrderNo = 4,
                Id = 11
            };
            Category cat4Son1 = new Category()
            {
                Name = "Рукавички",
                ParentCategory = cat4,
                OrderNo = 1,
                Id = 12
            };
            Category cat4Son2 = new Category()
            {
                Name = "Анестетики",
                ParentCategory = cat4,
                OrderNo = 2,
                Id = 13
            };
            Category cat4Son3 = new Category()
            {
                Name = "Ботулінотерапія",
                ParentCategory = cat4,
                OrderNo = 3,
                Id = 14
            };
            #endregion
            #region cat5
            Category cat5 = new Category()
            {
                Name = "Медтехніка",
                OrderNo = 5,
                Id = 15
            };
            Category cat5Son1 = new Category()
            {
                Name = "Глюкометри",
                ParentCategory = cat5,
                OrderNo = 1,
                Id = 16
            };
            Category cat5Son2 = new Category()
            {
                Name = "Інгалятори",
                ParentCategory = cat5,
                OrderNo = 2,
                Id = 17
            };
            #endregion
            #region cat6
            Category cat6 = new Category()
            {
                Name = "Товари для мам та дітей",
                OrderNo = 6,
                Id = 18
            };
            Category cat6Son1 = new Category()
            {
                Name = "Дитяче харчування",
                ParentCategory = cat6,
                OrderNo = 1,
                Id = 19
            };
            Category cat6Son2 = new Category()
            {
                Name = "Дитячі пеленки",
                ParentCategory = cat6,
                OrderNo = 2,
                Id = 20
            };
            #endregion
            #region cat7
            Category cat7 = new Category()
            {
                Name = "Косметика",
                OrderNo = 7,
                Id = 21
            };
            Category cat7Son1 = new Category()
            {
                Name = "Лікувальна косметика",
                ParentCategory = cat7,
                OrderNo = 1,
                Id = 22
            };
            Category cat7Son2 = new Category()
            {
                Name = "Засоби для рук",
                ParentCategory = cat7,
                OrderNo = 2,
                Id = 23
            };
            #endregion
            #region Properties
            Property prop1 = new Property()
            {
                Category = null,
                Name = "Лікарська форма",
                DefaultValue = " ",
                Description = "Лікарська форма",
                Prefix = "",
                Sufix = "",
                Type = PropertyType.String
            };
            Property prop2 = new Property()
            {
                Category = null,
                Name = "Виробник",
                DefaultValue = " ",
                Description = "Виробник",
                Prefix = "",
                Sufix = "",
                Type = PropertyType.String
            };
            Property prop3 = new Property()
            {
                Category = null,
                Name = "Вік",
                DefaultValue = " ",
                Description = "Вік",
                Prefix = "",
                Sufix = "",
                Type = PropertyType.String
            };
            Property prop4 = new Property()
            {
                Category = null,
                Name = "Показання",
                DefaultValue = " ",
                Description = "Показання",
                Prefix = "",
                Sufix = "",
                Type = PropertyType.String
            };
            Property prop5 = new Property()
            {
                Category = null,
                Name = "Протипоказання",
                DefaultValue = " ",
                Description = "Протипоказання",
                Prefix = "",
                Sufix = "",
                Type = PropertyType.String
            };
            Property prop6 = new Property()
            {
                Category = null,
                Name = "Склад",
                DefaultValue = " ",
                Description = "Склад",
                Prefix = "",
                Sufix = "",
                Type = PropertyType.String
            };
            Property prop7 = new Property()
            {
                Category = null,
                Name = "Термін придатності",
                DefaultValue = " ",
                Description = "Термін придатності",
                Prefix = "",
                Sufix = "",
                Type = PropertyType.String
            };
            Property prop8 = new Property()
            {
                Category = null,
                Name = "Українська назва",
                DefaultValue = " ",
                Description = "Українська назва",
                Prefix = "",
                Sufix = "",
                Type = PropertyType.String
            };
            Property prop9 = new Property()
            {
                Category = null,
                Name = "Упаковка",
                DefaultValue = " ",
                Description = "Упаковка",
                Prefix = "",
                Sufix = "",
                Type = PropertyType.String
            };
            Property prop10 = new Property()
            {
                Category = null,
                Name = "Фармакотерапевтична група",
                DefaultValue = " ",
                Description = "Фармакотерапевтична група",
                Prefix = "",
                Sufix = "",
                Type = PropertyType.String
            };
            #endregion
            var categories = new List<Category>();
            categories.Add(cat1);
            categories.Add(cat2);
            categories.Add(cat3);
            categories.Add(cat4);
            categories.Add(cat5);
            categories.Add(cat6);
            categories.Add(cat7);
            categories.Add(cat1Son1);
            categories.Add(cat1Son2);
            categories.Add(cat1Son1Son);
            categories.Add(cat2Son1);
            categories.Add(cat2Son2);
            categories.Add(cat3Son1);
            categories.Add(cat3Son2);
            categories.Add(cat4Son1);
            categories.Add(cat4Son2);
            categories.Add(cat4Son3);
            categories.Add(cat5Son1);
            categories.Add(cat5Son2);
            categories.Add(cat6Son1);
            categories.Add(cat6Son2);
            categories.Add(cat7Son1);
            categories.Add(cat7Son2);

            var properties = new List<Property>();

            properties.Add(prop1);
            properties.Add(prop2);
            properties.Add(prop3);
            properties.Add(prop4);
            properties.Add(prop5);
            properties.Add(prop6);
            properties.Add(prop7);
            properties.Add(prop8);
            properties.Add(prop9);
            properties.Add(prop10);


            Model.DB.WebShop webShop1 = new Model.DB.WebShop() {
				Name = "Аптека 24",
				Path = "https://www.apteka24.ua",
				Status = true
			};
			Model.DB.WebShop webShop2 = new Model.DB.WebShop() {
				Name = "Аптека А+",
				Path = "https://aplusapteka.com.ua/",
				Status = true
			};
            Model.DB.WebShop webShop3 = new Model.DB.WebShop()
            {
                Name = "Аптека Дня",
                Path = "https://www.add.ua/ua/",
                Status = true
            };
            Good good1 = new Good()
            {
                XmlData = "<?xml version=\"1.0\" encoding=\"utf - 8\"?><PropertyValuesDTO type=\"Model.DTO.PropertyValuesDTO\"><DictStringProperties><Item><Key>1</Key><Value>Розчин для ін'єкцій, 75 мг/3 мл по 3 мл в ампулах № 5</Value></Item><Item><Key>2</Key><Value>КРКА, д.д., Ново место, Словенія</Value></Item><Item><Key>3</Key><Value>не застосовувати дітям</Value></Item><Item><Key>4</Key><Value>Препарат при внутрішньом’язовому введенні призначений для лікування: Запальних та дегенеративних форм ревматизму, ревматоїдного артриту, анкілозуючого спондиліту, остеоартриту, спондилоартриту, вертебрального больового синдрому, несуглобового ревматизму; гострих нападів подагри; ниркової та біліарної колік; болю та набряку після травм і операцій; тяжких нападів мігрені. Препарат при введенні у вигляді внутрішньовенних інфузій призначений для лікування або профілактики післяопераційного болю.</Value></Item><Item><Key>5</Key><Value>Відома гіперчутливість до діючої речовини, натрію метабісульфіту або до будь-яких інших компонентів препарату. Кровотеча або перфорація шлунково-кишкового тракту в анамнезі, пов’язана з попереднім лікуванням нестероїдними протизапальними засобами (НПЗЗ). Активна форма виразкової хвороби/кровотечі або рецидивуюча виразкова хвороба/кровотеча в анамнезі (два або більше окремих епізоди встановленої виразки або кровотечі). Печінкова недостатність. Ниркова недостатність. Застійна серцева недостатність (NYHA ІІ-ІV). III триместр вагітності. Як і інші НПЗЗ, диклофенак також протипоказаний пацієнтам, у яких застосування ібупрофену, ацетилсаліцилової кислоти або інших нестероїдних протизапальних препаратів провокує напади бронхіальної астми, ангіоневротичного набряку, кропив’янки або гострого риніту. Запальні захворювання кишечнику (наприклад хвороба Крона або виразковий коліт). Високий ризик розвитку післяопераційних кровотеч, незгортання крові, порушень гемостазу, гемопоетичних порушень чи цереброваскулярних кровотеч. Лікування періопераційного болю при аортокоронарному шунтуванні (або використання апарату штучного кровообігу). Ішемічна хвороба серця у пацієнтів, які мають стенокардію, перенесений інфаркт міокарда. Цереброваскулярні захворювання у пацієнтів, які перенесли інсульт або мають епізоди транзиторних ішемічних атак. Захворювання периферичних артерій. У даній лікарській формі препарат протипоказаний дітям. Тільки щодо внутрішньовенного застосування. Одночасне застосування НПЗЗ або антикоагулянту (в тому числі низьких доз гепарину). Наявність в анамнезі геморагічного діатезу, підтверджена або підозрювана цереброваскулярна кровотеча в анамнезі. Операції, пов’язані з високим ризиком кровотечі. Бронхіальна астма в анамнезі. Помірне або тяжке порушення функцій нирок (креатинін сироватки крові > 160 мкмоль/л). Гіповолемія або зневоднення з будь-якої причини.</Value></Item><Item><Key>6</Key><Value>діюча речовина: 3 мл розчину (1 ампула) містять диклофенаку натрію – 75 мг; допоміжні речовини: спирт бензиловий, пропіленгліколь, натрію метабісульфіт (Е 223), натрію гідроксид, вода для ін’єкцій.</Value></Item><Item><Key>7</Key><Value>5 роки</Value></Item><Item><Key>8</Key><Value>НАКЛОФЕН</Value></Item><Item><Key>9</Key><Value>ампула</Value></Item><Item><Key>10</Key><Value>Нестероїдні протизапальні та протиревматичні засоби. Диклофенак. Код АТХ М01А В05.</Value></Item></DictStringProperties><DictIntProperties /><DictDoubleProperties /></PropertyValuesDTO>",
                Category_Id = 3,
                WebShop_Id = 1,
                Status = true,
                Name = "Наклофен 75 мг/3 мл N5 раствор",
                Price = 68.2m,
                ImgLink = "https://www.apteka24.ua/upload/resize_cache/iblock/31b/650_400_1/31b8c50201d1f3bf9690239eea338eb7.jpg",
                UrlLink = "https://www.apteka24.ua/naklofen-75-mg-3-ml-n5/",
                Description = "Наклофен является нестероидным противовоспалительным препаратом (НПВП) для местного применения, обладающим выраженным анальгезирующим и противовоспалительным свойствами.",
                OldPrice = 70m
            };
            Good good2 = new Good()
            {
                XmlData = "<?xml version=\"1.0\" encoding=\"utf - 8\"?><PropertyValuesDTO type=\"Model.DTO.PropertyValuesDTO\"><DictStringProperties><Item><Key>1</Key><Value>Таблетки шипучі № 10 (2х5) у стрипах</Value></Item><Item><Key>2</Key><Value>Байєр Біттерфельд ГмбХ, Німеччина</Value></Item><Item><Key>3</Key><Value>Препарат застосовують дітям віком від 15 років.</Value></Item><Item><Key>4</Key><Value>Незначний або помірний біль, такий як головний біль, зубний біль, періодичні болі у жінок, больові симптоми, пов’язані з застудою (наприклад, головний біль, біль у горлі, біль у кінцівках). -Гарячка.</Value></Item><Item><Key>5</Key><Value>	Гіперчутливість до ацетилсаліцилової кислоти, інших саліцилатів, аскорбінової кислоти або до будь-якого компонента препарату. - Бронхіальна астма, спричинена застосуванням саліцилатів або інших НПЗЗ в анамнезі. - Гострі шлунково-кишкові виразки. - Геморагічний діатез. - Тяжкі захворювання нирок; виражена ниркова недостатність. - Сечокам’яна хвороба. - Виражена печінкова недостатність. - Виражена серцева недостатність. - Схильність до тромбозів, тромбофлебіт. - Цукровий діабет. - Комбінація з метотрексатом у дозуванні 15 мг/тиждень або більше (див. розділ «Взаємодія з іншими лікарськими засобами та інші види взаємодій»).</Value></Item><Item><Key>6</Key><Value>діючі речовини: ацетилсаліцилова кислота та аскорбінова кислота; 1 таблетка містить 400 мг ацетилсаліцилової кислоти та 240 мг аскорбінової кислоти (вітаміну С); допоміжні речовини: натрію дигідроцитрат, натрію гідрокарбонат, кислота лимонна безводна, натрію карбонат безводний.</Value></Item><Item><Key>7</Key><Value>3 роки</Value></Item><Item><Key>8</Key><Value>АСПІРИН® С</Value></Item><Item><Key>9</Key><Value>	Стрип</Value></Item><Item><Key>10</Key><Value>Аналгетики та антипіретики. Кислота ацетилсаліцилова. Код АТХ N02В А01.</Value></Item></DictStringProperties><DictIntProperties /><DictDoubleProperties /></PropertyValuesDTO>",
                Category_Id = 3,
                WebShop_Id = 1,
                Status = true,
                Name = "Аспирин C №10 таблетки шипучие",
                Price = 68.2m,
                ImgLink = "https://www.apteka24.ua/upload/iblock/d13/d13b9fe9ab6e453f536caf8f234df55d.jpg",
                UrlLink = "https://www.apteka24.ua/aspirin-s-n10/",
                Description = "Шипучие таблетки Аспирин С №10 - это всем хорошо известное средство, которое отменно борется с головной и зубной болью, а также эффективно устраняет мышечные и суставные боли. Относится данный препарат к группе анальгетиков и антипиретиков и содержит ацетилсалициловую кислоту. Именно за счет данного компонента и осуществляется его терапевтический эффект."
            };
            Good good3 = new Good()
            {
                XmlData = "<?xml version=\"1.0\" encoding=\"utf - 8\"?><PropertyValuesDTO type=\"Model.DTO.PropertyValuesDTO\"><DictStringProperties><Item><Key>1</Key><Value>Таблетки шипучі № 10 (2х5) у стрипах</Value></Item><Item><Key>2</Key><Value>Байєр Біттерфельд ГмбХ, Німеччина</Value></Item><Item><Key>3</Key><Value>Препарат застосовують дітям віком від 15 років.</Value></Item><Item><Key>4</Key><Value>Незначний або помірний біль, такий як головний біль, зубний біль, періодичні болі у жінок, больові симптоми, пов’язані з застудою (наприклад, головний біль, біль у горлі, біль у кінцівках). -Гарячка.</Value></Item><Item><Key>5</Key><Value>	Гіперчутливість до ацетилсаліцилової кислоти, інших саліцилатів, аскорбінової кислоти або до будь-якого компонента препарату. - Бронхіальна астма, спричинена застосуванням саліцилатів або інших НПЗЗ в анамнезі. - Гострі шлунково-кишкові виразки. - Геморагічний діатез. - Тяжкі захворювання нирок; виражена ниркова недостатність. - Сечокам’яна хвороба. - Виражена печінкова недостатність. - Виражена серцева недостатність. - Схильність до тромбозів, тромбофлебіт. - Цукровий діабет. - Комбінація з метотрексатом у дозуванні 15 мг/тиждень або більше (див. розділ «Взаємодія з іншими лікарськими засобами та інші види взаємодій»).</Value></Item><Item><Key>6</Key><Value>діючі речовини: ацетилсаліцилова кислота та аскорбінова кислота; 1 таблетка містить 400 мг ацетилсаліцилової кислоти та 240 мг аскорбінової кислоти (вітаміну С); допоміжні речовини: натрію дигідроцитрат, натрію гідрокарбонат, кислота лимонна безводна, натрію карбонат безводний.</Value></Item><Item><Key>7</Key><Value>3 роки</Value></Item><Item><Key>8</Key><Value>АСПІРИН® С</Value></Item><Item><Key>9</Key><Value>	Стрип</Value></Item><Item><Key>10</Key><Value>Аналгетики та антипіретики. Кислота ацетилсаліцилова. Код АТХ N02В А01.</Value></Item></DictStringProperties><DictIntProperties /><DictDoubleProperties /></PropertyValuesDTO>",
                Category_Id = 3,
                WebShop_Id = 1,
                Status = true,
                Name = "Аспирин C №10 таблетки шипучиеx",
                Price = 68.2m,
                ImgLink = "https://www.apteka24.ua/upload/iblock/d13/d13b9fe9ab6e453f536caf8f234df55d.jpg",
                UrlLink = "https://www.apteka24.ua/naklofen-75-mg-3-ml-n5/",
                Description = "Шипучие таблетки Аспирин С №10 - это всем хорошо известное средство, которое отменно борется с головной и зубной болью, а также эффективно устраняет мышечные и суставные боли. Относится данный препарат к группе анальгетиков и антипиретиков и содержит ацетилсалициловую кислоту. Именно за счет данного компонента и осуществляется его терапевтический эффект.",
                OldPrice = 70m
            };
            Good good4 = new Good()
            {
                XmlData = "<?xml version=\"1.0\" encoding=\"utf - 8\"?><PropertyValuesDTO type=\"Model.DTO.PropertyValuesDTO\"><DictStringProperties><Item><Key>1</Key><Value>Таблетки шипучі № 10 (2х5) у стрипах</Value></Item><Item><Key>2</Key><Value>Байєр Біттерфельд ГмбХ, Німеччина</Value></Item><Item><Key>3</Key><Value>Препарат застосовують дітям віком від 15 років.</Value></Item><Item><Key>4</Key><Value>Незначний або помірний біль, такий як головний біль, зубний біль, періодичні болі у жінок, больові симптоми, пов’язані з застудою (наприклад, головний біль, біль у горлі, біль у кінцівках). -Гарячка.</Value></Item><Item><Key>5</Key><Value>	Гіперчутливість до ацетилсаліцилової кислоти, інших саліцилатів, аскорбінової кислоти або до будь-якого компонента препарату. - Бронхіальна астма, спричинена застосуванням саліцилатів або інших НПЗЗ в анамнезі. - Гострі шлунково-кишкові виразки. - Геморагічний діатез. - Тяжкі захворювання нирок; виражена ниркова недостатність. - Сечокам’яна хвороба. - Виражена печінкова недостатність. - Виражена серцева недостатність. - Схильність до тромбозів, тромбофлебіт. - Цукровий діабет. - Комбінація з метотрексатом у дозуванні 15 мг/тиждень або більше (див. розділ «Взаємодія з іншими лікарськими засобами та інші види взаємодій»).</Value></Item><Item><Key>6</Key><Value>діючі речовини: ацетилсаліцилова кислота та аскорбінова кислота; 1 таблетка містить 400 мг ацетилсаліцилової кислоти та 240 мг аскорбінової кислоти (вітаміну С); допоміжні речовини: натрію дигідроцитрат, натрію гідрокарбонат, кислота лимонна безводна, натрію карбонат безводний.</Value></Item><Item><Key>7</Key><Value>3 роки</Value></Item><Item><Key>8</Key><Value>АСПІРИН® С</Value></Item><Item><Key>9</Key><Value>	Стрип</Value></Item><Item><Key>10</Key><Value>Аналгетики та антипіретики. Кислота ацетилсаліцилова. Код АТХ N02В А01.</Value></Item></DictStringProperties><DictIntProperties /><DictDoubleProperties /></PropertyValuesDTO>",
                Category_Id = 3,
                WebShop_Id = 1,
                Status = true,
                Name = "Аспирин C №10 таблетки шипучиеd",
                Price = 68.2m,
                ImgLink = "https://www.apteka24.ua/upload/iblock/d13/d13b9fe9ab6e453f536caf8f234df55d.jpg",
                UrlLink = "https://www.apteka24.ua/naklofen-75-mg-3-ml-n5/",
                Description = "Шипучие таблетки Аспирин С №10 - это всем хорошо известное средство, которое отменно борется с головной и зубной болью, а также эффективно устраняет мышечные и суставные боли. Относится данный препарат к группе анальгетиков и антипиретиков и содержит ацетилсалициловую кислоту. Именно за счет данного компонента и осуществляется его терапевтический эффект."
            };
            Good good5 = new Good()
            {
                XmlData = "<?xml version=\"1.0\" encoding=\"utf - 8\"?><PropertyValuesDTO type=\"Model.DTO.PropertyValuesDTO\"><DictStringProperties><Item><Key>1</Key><Value>Таблетки шипучі № 10 (2х5) у стрипах</Value></Item><Item><Key>2</Key><Value>Байєр Біттерфельд ГмбХ, Німеччина</Value></Item><Item><Key>3</Key><Value>Препарат застосовують дітям віком від 15 років.</Value></Item><Item><Key>4</Key><Value>Незначний або помірний біль, такий як головний біль, зубний біль, періодичні болі у жінок, больові симптоми, пов’язані з застудою (наприклад, головний біль, біль у горлі, біль у кінцівках). -Гарячка.</Value></Item><Item><Key>5</Key><Value>	Гіперчутливість до ацетилсаліцилової кислоти, інших саліцилатів, аскорбінової кислоти або до будь-якого компонента препарату. - Бронхіальна астма, спричинена застосуванням саліцилатів або інших НПЗЗ в анамнезі. - Гострі шлунково-кишкові виразки. - Геморагічний діатез. - Тяжкі захворювання нирок; виражена ниркова недостатність. - Сечокам’яна хвороба. - Виражена печінкова недостатність. - Виражена серцева недостатність. - Схильність до тромбозів, тромбофлебіт. - Цукровий діабет. - Комбінація з метотрексатом у дозуванні 15 мг/тиждень або більше (див. розділ «Взаємодія з іншими лікарськими засобами та інші види взаємодій»).</Value></Item><Item><Key>6</Key><Value>діючі речовини: ацетилсаліцилова кислота та аскорбінова кислота; 1 таблетка містить 400 мг ацетилсаліцилової кислоти та 240 мг аскорбінової кислоти (вітаміну С); допоміжні речовини: натрію дигідроцитрат, натрію гідрокарбонат, кислота лимонна безводна, натрію карбонат безводний.</Value></Item><Item><Key>7</Key><Value>3 роки</Value></Item><Item><Key>8</Key><Value>АСПІРИН® С</Value></Item><Item><Key>9</Key><Value>	Стрип</Value></Item><Item><Key>10</Key><Value>Аналгетики та антипіретики. Кислота ацетилсаліцилова. Код АТХ N02В А01.</Value></Item></DictStringProperties><DictIntProperties /><DictDoubleProperties /></PropertyValuesDTO>",
                Category_Id = 3,
                WebShop_Id = 1,
                Status = true,
                Name = "Аспирин C №10 таблетки шипучиеs",
                Price = 68.2m,
                ImgLink = "https://www.apteka24.ua/upload/iblock/d13/d13b9fe9ab6e453f536caf8f234df55d.jpg",
                UrlLink = "https://www.apteka24.ua/naklofen-75-mg-3-ml-n5/",
                Description = "Шипучие таблетки Аспирин С №10 - это всем хорошо известное средство, которое отменно борется с головной и зубной болью, а также эффективно устраняет мышечные и суставные боли. Относится данный препарат к группе анальгетиков и антипиретиков и содержит ацетилсалициловую кислоту. Именно за счет данного компонента и осуществляется его терапевтический эффект.",
                OldPrice = 66.6m
            };
            Good good6 = new Good()
            {
                XmlData = "<?xml version=\"1.0\" encoding=\"utf - 8\"?><PropertyValuesDTO type=\"Model.DTO.PropertyValuesDTO\"><DictStringProperties><Item><Key>1</Key><Value>Таблетки шипучі № 10 (2х5) у стрипах</Value></Item><Item><Key>2</Key><Value>Байєр Біттерфельд ГмбХ, Німеччина</Value></Item><Item><Key>3</Key><Value>Препарат застосовують дітям віком від 15 років.</Value></Item><Item><Key>4</Key><Value>Незначний або помірний біль, такий як головний біль, зубний біль, періодичні болі у жінок, больові симптоми, пов’язані з застудою (наприклад, головний біль, біль у горлі, біль у кінцівках). -Гарячка.</Value></Item><Item><Key>5</Key><Value>	Гіперчутливість до ацетилсаліцилової кислоти, інших саліцилатів, аскорбінової кислоти або до будь-якого компонента препарату. - Бронхіальна астма, спричинена застосуванням саліцилатів або інших НПЗЗ в анамнезі. - Гострі шлунково-кишкові виразки. - Геморагічний діатез. - Тяжкі захворювання нирок; виражена ниркова недостатність. - Сечокам’яна хвороба. - Виражена печінкова недостатність. - Виражена серцева недостатність. - Схильність до тромбозів, тромбофлебіт. - Цукровий діабет. - Комбінація з метотрексатом у дозуванні 15 мг/тиждень або більше (див. розділ «Взаємодія з іншими лікарськими засобами та інші види взаємодій»).</Value></Item><Item><Key>6</Key><Value>діючі речовини: ацетилсаліцилова кислота та аскорбінова кислота; 1 таблетка містить 400 мг ацетилсаліцилової кислоти та 240 мг аскорбінової кислоти (вітаміну С); допоміжні речовини: натрію дигідроцитрат, натрію гідрокарбонат, кислота лимонна безводна, натрію карбонат безводний.</Value></Item><Item><Key>7</Key><Value>3 роки</Value></Item><Item><Key>8</Key><Value>АСПІРИН® С</Value></Item><Item><Key>9</Key><Value>	Стрип</Value></Item><Item><Key>10</Key><Value>Аналгетики та антипіретики. Кислота ацетилсаліцилова. Код АТХ N02В А01.</Value></Item></DictStringProperties><DictIntProperties /><DictDoubleProperties /></PropertyValuesDTO>",
                Category_Id = 3,
                WebShop_Id = 1,
                Status = true,
                Name = "Аспирин C №10 таблетки шипучиеs",
                Price = 68.2m,
                ImgLink = "https://www.apteka24.ua/upload/iblock/d13/d13b9fe9ab6e453f536caf8f234df55d.jpg",
                UrlLink = "https://www.apteka24.ua/naklofen-75-mg-3-ml-n5/",
                Description = "Шипучие таблетки Аспирин С №10 - это всем хорошо известное средство, которое отменно борется с головной и зубной болью, а также эффективно устраняет мышечные и суставные боли. Относится данный препарат к группе анальгетиков и антипиретиков и содержит ацетилсалициловую кислоту. Именно за счет данного компонента и осуществляется его терапевтический эффект.",
                OldPrice = 66.6m
            };
            Good good7 = new Good()
            {
                XmlData = "<?xml version=\"1.0\" encoding=\"utf - 8\"?><PropertyValuesDTO type=\"Model.DTO.PropertyValuesDTO\"><DictStringProperties><Item><Key>1</Key><Value>Таблетки шипучі № 10 (2х5) у стрипах</Value></Item><Item><Key>2</Key><Value>Байєр Біттерфельд ГмбХ, Німеччина</Value></Item><Item><Key>3</Key><Value>Препарат застосовують дітям віком від 15 років.</Value></Item><Item><Key>4</Key><Value>Незначний або помірний біль, такий як головний біль, зубний біль, періодичні болі у жінок, больові симптоми, пов’язані з застудою (наприклад, головний біль, біль у горлі, біль у кінцівках). -Гарячка.</Value></Item><Item><Key>5</Key><Value>	Гіперчутливість до ацетилсаліцилової кислоти, інших саліцилатів, аскорбінової кислоти або до будь-якого компонента препарату. - Бронхіальна астма, спричинена застосуванням саліцилатів або інших НПЗЗ в анамнезі. - Гострі шлунково-кишкові виразки. - Геморагічний діатез. - Тяжкі захворювання нирок; виражена ниркова недостатність. - Сечокам’яна хвороба. - Виражена печінкова недостатність. - Виражена серцева недостатність. - Схильність до тромбозів, тромбофлебіт. - Цукровий діабет. - Комбінація з метотрексатом у дозуванні 15 мг/тиждень або більше (див. розділ «Взаємодія з іншими лікарськими засобами та інші види взаємодій»).</Value></Item><Item><Key>6</Key><Value>діючі речовини: ацетилсаліцилова кислота та аскорбінова кислота; 1 таблетка містить 400 мг ацетилсаліцилової кислоти та 240 мг аскорбінової кислоти (вітаміну С); допоміжні речовини: натрію дигідроцитрат, натрію гідрокарбонат, кислота лимонна безводна, натрію карбонат безводний.</Value></Item><Item><Key>7</Key><Value>3 роки</Value></Item><Item><Key>8</Key><Value>АСПІРИН® С</Value></Item><Item><Key>9</Key><Value>	Стрип</Value></Item><Item><Key>10</Key><Value>Аналгетики та антипіретики. Кислота ацетилсаліцилова. Код АТХ N02В А01.</Value></Item></DictStringProperties><DictIntProperties /><DictDoubleProperties /></PropertyValuesDTO>",
                Category_Id = 3,
                WebShop_Id = 1,
                Status = true,
                Name = "Аспирин C №10 таблетки шипучиеs",
                Price = 68.2m,
                ImgLink = "https://www.apteka24.ua/upload/iblock/d13/d13b9fe9ab6e453f536caf8f234df55d.jpg",
                UrlLink = "https://www.apteka24.ua/naklofen-75-mg-3-ml-n5/",
                Description = "Шипучие таблетки Аспирин С №10 - это всем хорошо известное средство, которое отменно борется с головной и зубной болью, а также эффективно устраняет мышечные и суставные боли. Относится данный препарат к группе анальгетиков и антипиретиков и содержит ацетилсалициловую кислоту. Именно за счет данного компонента и осуществляется его терапевтический эффект.",
                OldPrice = 66.6m
            };
            Good good8 = new Good()
            {
                XmlData = "<?xml version=\"1.0\" encoding=\"utf - 8\"?><PropertyValuesDTO type=\"Model.DTO.PropertyValuesDTO\"><DictStringProperties><Item><Key>1</Key><Value>Таблетки шипучі № 10 (2х5) у стрипах</Value></Item><Item><Key>2</Key><Value>Байєр Біттерфельд ГмбХ, Німеччина</Value></Item><Item><Key>3</Key><Value>Препарат застосовують дітям віком від 15 років.</Value></Item><Item><Key>4</Key><Value>Незначний або помірний біль, такий як головний біль, зубний біль, періодичні болі у жінок, больові симптоми, пов’язані з застудою (наприклад, головний біль, біль у горлі, біль у кінцівках). -Гарячка.</Value></Item><Item><Key>5</Key><Value>	Гіперчутливість до ацетилсаліцилової кислоти, інших саліцилатів, аскорбінової кислоти або до будь-якого компонента препарату. - Бронхіальна астма, спричинена застосуванням саліцилатів або інших НПЗЗ в анамнезі. - Гострі шлунково-кишкові виразки. - Геморагічний діатез. - Тяжкі захворювання нирок; виражена ниркова недостатність. - Сечокам’яна хвороба. - Виражена печінкова недостатність. - Виражена серцева недостатність. - Схильність до тромбозів, тромбофлебіт. - Цукровий діабет. - Комбінація з метотрексатом у дозуванні 15 мг/тиждень або більше (див. розділ «Взаємодія з іншими лікарськими засобами та інші види взаємодій»).</Value></Item><Item><Key>6</Key><Value>діючі речовини: ацетилсаліцилова кислота та аскорбінова кислота; 1 таблетка містить 400 мг ацетилсаліцилової кислоти та 240 мг аскорбінової кислоти (вітаміну С); допоміжні речовини: натрію дигідроцитрат, натрію гідрокарбонат, кислота лимонна безводна, натрію карбонат безводний.</Value></Item><Item><Key>7</Key><Value>3 роки</Value></Item><Item><Key>8</Key><Value>АСПІРИН® С</Value></Item><Item><Key>9</Key><Value>	Стрип</Value></Item><Item><Key>10</Key><Value>Аналгетики та антипіретики. Кислота ацетилсаліцилова. Код АТХ N02В А01.</Value></Item></DictStringProperties><DictIntProperties /><DictDoubleProperties /></PropertyValuesDTO>",
                Category_Id = 3,
                WebShop_Id = 1,
                Status = true,
                Name = "Аспирин C №10 таблетки шипучиеs",
                Price = 68.2m,
                ImgLink = "https://www.apteka24.ua/upload/iblock/d13/d13b9fe9ab6e453f536caf8f234df55d.jpg",
                UrlLink = "https://www.apteka24.ua/naklofen-75-mg-3-ml-n5/",
                Description = "Шипучие таблетки Аспирин С №10 - это всем хорошо известное средство, которое отменно борется с головной и зубной болью, а также эффективно устраняет мышечные и суставные боли. Относится данный препарат к группе анальгетиков и антипиретиков и содержит ацетилсалициловую кислоту. Именно за счет данного компонента и осуществляется его терапевтический эффект.",
                OldPrice = 66.6m
            };
            Good good9 = new Good()
            {
                XmlData = "<?xml version=\"1.0\" encoding=\"utf - 8\"?><PropertyValuesDTO type=\"Model.DTO.PropertyValuesDTO\"><DictStringProperties><Item><Key>1</Key><Value>Таблетки шипучі № 10 (2х5) у стрипах</Value></Item><Item><Key>2</Key><Value>Байєр Біттерфельд ГмбХ, Німеччина</Value></Item><Item><Key>3</Key><Value>Препарат застосовують дітям віком від 15 років.</Value></Item><Item><Key>4</Key><Value>Незначний або помірний біль, такий як головний біль, зубний біль, періодичні болі у жінок, больові симптоми, пов’язані з застудою (наприклад, головний біль, біль у горлі, біль у кінцівках). -Гарячка.</Value></Item><Item><Key>5</Key><Value>	Гіперчутливість до ацетилсаліцилової кислоти, інших саліцилатів, аскорбінової кислоти або до будь-якого компонента препарату. - Бронхіальна астма, спричинена застосуванням саліцилатів або інших НПЗЗ в анамнезі. - Гострі шлунково-кишкові виразки. - Геморагічний діатез. - Тяжкі захворювання нирок; виражена ниркова недостатність. - Сечокам’яна хвороба. - Виражена печінкова недостатність. - Виражена серцева недостатність. - Схильність до тромбозів, тромбофлебіт. - Цукровий діабет. - Комбінація з метотрексатом у дозуванні 15 мг/тиждень або більше (див. розділ «Взаємодія з іншими лікарськими засобами та інші види взаємодій»).</Value></Item><Item><Key>6</Key><Value>діючі речовини: ацетилсаліцилова кислота та аскорбінова кислота; 1 таблетка містить 400 мг ацетилсаліцилової кислоти та 240 мг аскорбінової кислоти (вітаміну С); допоміжні речовини: натрію дигідроцитрат, натрію гідрокарбонат, кислота лимонна безводна, натрію карбонат безводний.</Value></Item><Item><Key>7</Key><Value>3 роки</Value></Item><Item><Key>8</Key><Value>АСПІРИН® С</Value></Item><Item><Key>9</Key><Value>	Стрип</Value></Item><Item><Key>10</Key><Value>Аналгетики та антипіретики. Кислота ацетилсаліцилова. Код АТХ N02В А01.</Value></Item></DictStringProperties><DictIntProperties /><DictDoubleProperties /></PropertyValuesDTO>",
                Category_Id = 3,
                WebShop_Id = 1,
                Status = true,
                Name = "Аспирин C №10 таблетки шипучиеs",
                Price = 68.2m,
                ImgLink = "https://www.apteka24.ua/upload/iblock/d13/d13b9fe9ab6e453f536caf8f234df55d.jpg",
                UrlLink = "https://www.apteka24.ua/naklofen-75-mg-3-ml-n5/",
                Description = "Шипучие таблетки Аспирин С №10 - это всем хорошо известное средство, которое отменно борется с головной и зубной болью, а также эффективно устраняет мышечные и суставные боли. Относится данный препарат к группе анальгетиков и антипиретиков и содержит ацетилсалициловую кислоту. Именно за счет данного компонента и осуществляется его терапевтический эффект.",
                OldPrice = 66.6m
            };
            Good good10 = new Good()
            {
                XmlData = "<?xml version=\"1.0\" encoding=\"utf - 8\"?><PropertyValuesDTO type=\"Model.DTO.PropertyValuesDTO\"><DictStringProperties><Item><Key>1</Key><Value>Таблетки шипучі № 10 (2х5) у стрипах</Value></Item><Item><Key>2</Key><Value>Байєр Біттерфельд ГмбХ, Німеччина</Value></Item><Item><Key>3</Key><Value>Препарат застосовують дітям віком від 15 років.</Value></Item><Item><Key>4</Key><Value>Незначний або помірний біль, такий як головний біль, зубний біль, періодичні болі у жінок, больові симптоми, пов’язані з застудою (наприклад, головний біль, біль у горлі, біль у кінцівках). -Гарячка.</Value></Item><Item><Key>5</Key><Value>	Гіперчутливість до ацетилсаліцилової кислоти, інших саліцилатів, аскорбінової кислоти або до будь-якого компонента препарату. - Бронхіальна астма, спричинена застосуванням саліцилатів або інших НПЗЗ в анамнезі. - Гострі шлунково-кишкові виразки. - Геморагічний діатез. - Тяжкі захворювання нирок; виражена ниркова недостатність. - Сечокам’яна хвороба. - Виражена печінкова недостатність. - Виражена серцева недостатність. - Схильність до тромбозів, тромбофлебіт. - Цукровий діабет. - Комбінація з метотрексатом у дозуванні 15 мг/тиждень або більше (див. розділ «Взаємодія з іншими лікарськими засобами та інші види взаємодій»).</Value></Item><Item><Key>6</Key><Value>діючі речовини: ацетилсаліцилова кислота та аскорбінова кислота; 1 таблетка містить 400 мг ацетилсаліцилової кислоти та 240 мг аскорбінової кислоти (вітаміну С); допоміжні речовини: натрію дигідроцитрат, натрію гідрокарбонат, кислота лимонна безводна, натрію карбонат безводний.</Value></Item><Item><Key>7</Key><Value>3 роки</Value></Item><Item><Key>8</Key><Value>АСПІРИН® С</Value></Item><Item><Key>9</Key><Value>	Стрип</Value></Item><Item><Key>10</Key><Value>Аналгетики та антипіретики. Кислота ацетилсаліцилова. Код АТХ N02В А01.</Value></Item></DictStringProperties><DictIntProperties /><DictDoubleProperties /></PropertyValuesDTO>",
                Category_Id = 3,
                WebShop_Id = 1,
                Status = true,
                Name = "Аспирин C №10 таблетки шипучиеs",
                Price = 68.2m,
                ImgLink = "https://www.apteka24.ua/upload/iblock/d13/d13b9fe9ab6e453f536caf8f234df55d.jpg",
                UrlLink = "https://www.apteka24.ua/naklofen-75-mg-3-ml-n5/",
                Description = "Шипучие таблетки Аспирин С №10 - это всем хорошо известное средство, которое отменно борется с головной и зубной болью, а также эффективно устраняет мышечные и суставные боли. Относится данный препарат к группе анальгетиков и антипиретиков и содержит ацетилсалициловую кислоту. Именно за счет данного компонента и осуществляется его терапевтический эффект.",
                OldPrice = 66.6m
            };
            Good good11 = new Good()
            {
                XmlData = "<?xml version=\"1.0\" encoding=\"utf - 8\"?><PropertyValuesDTO type=\"Model.DTO.PropertyValuesDTO\"><DictStringProperties><Item><Key>1</Key><Value>Таблетки шипучі № 10 (2х5) у стрипах</Value></Item><Item><Key>2</Key><Value>Байєр Біттерфельд ГмбХ, Німеччина</Value></Item><Item><Key>3</Key><Value>Препарат застосовують дітям віком від 15 років.</Value></Item><Item><Key>4</Key><Value>Незначний або помірний біль, такий як головний біль, зубний біль, періодичні болі у жінок, больові симптоми, пов’язані з застудою (наприклад, головний біль, біль у горлі, біль у кінцівках). -Гарячка.</Value></Item><Item><Key>5</Key><Value>	Гіперчутливість до ацетилсаліцилової кислоти, інших саліцилатів, аскорбінової кислоти або до будь-якого компонента препарату. - Бронхіальна астма, спричинена застосуванням саліцилатів або інших НПЗЗ в анамнезі. - Гострі шлунково-кишкові виразки. - Геморагічний діатез. - Тяжкі захворювання нирок; виражена ниркова недостатність. - Сечокам’яна хвороба. - Виражена печінкова недостатність. - Виражена серцева недостатність. - Схильність до тромбозів, тромбофлебіт. - Цукровий діабет. - Комбінація з метотрексатом у дозуванні 15 мг/тиждень або більше (див. розділ «Взаємодія з іншими лікарськими засобами та інші види взаємодій»).</Value></Item><Item><Key>6</Key><Value>діючі речовини: ацетилсаліцилова кислота та аскорбінова кислота; 1 таблетка містить 400 мг ацетилсаліцилової кислоти та 240 мг аскорбінової кислоти (вітаміну С); допоміжні речовини: натрію дигідроцитрат, натрію гідрокарбонат, кислота лимонна безводна, натрію карбонат безводний.</Value></Item><Item><Key>7</Key><Value>3 роки</Value></Item><Item><Key>8</Key><Value>АСПІРИН® С</Value></Item><Item><Key>9</Key><Value>	Стрип</Value></Item><Item><Key>10</Key><Value>Аналгетики та антипіретики. Кислота ацетилсаліцилова. Код АТХ N02В А01.</Value></Item></DictStringProperties><DictIntProperties /><DictDoubleProperties /></PropertyValuesDTO>",
                Category_Id = 3,
                WebShop_Id = 1,
                Status = true,
                Name = "Аспирин C №10 таблетки шипучиеs",
                Price = 68.2m,
                ImgLink = "https://www.apteka24.ua/upload/iblock/d13/d13b9fe9ab6e453f536caf8f234df55d.jpg",
                UrlLink = "https://www.apteka24.ua/naklofen-75-mg-3-ml-n5/",
                Description = "Шипучие таблетки Аспирин С №10 - это всем хорошо известное средство, которое отменно борется с головной и зубной болью, а также эффективно устраняет мышечные и суставные боли. Относится данный препарат к группе анальгетиков и антипиретиков и содержит ацетилсалициловую кислоту. Именно за счет данного компонента и осуществляется его терапевтический эффект.",
                OldPrice = 66.6m
            };
            Good good12 = new Good()
            {
                XmlData = "<?xml version=\"1.0\" encoding=\"utf - 8\"?><PropertyValuesDTO type=\"Model.DTO.PropertyValuesDTO\"><DictStringProperties><Item><Key>1</Key><Value>Таблетки шипучі № 10 (2х5) у стрипах</Value></Item><Item><Key>2</Key><Value>Байєр Біттерфельд ГмбХ, Німеччина</Value></Item><Item><Key>3</Key><Value>Препарат застосовують дітям віком від 15 років.</Value></Item><Item><Key>4</Key><Value>Незначний або помірний біль, такий як головний біль, зубний біль, періодичні болі у жінок, больові симптоми, пов’язані з застудою (наприклад, головний біль, біль у горлі, біль у кінцівках). -Гарячка.</Value></Item><Item><Key>5</Key><Value>	Гіперчутливість до ацетилсаліцилової кислоти, інших саліцилатів, аскорбінової кислоти або до будь-якого компонента препарату. - Бронхіальна астма, спричинена застосуванням саліцилатів або інших НПЗЗ в анамнезі. - Гострі шлунково-кишкові виразки. - Геморагічний діатез. - Тяжкі захворювання нирок; виражена ниркова недостатність. - Сечокам’яна хвороба. - Виражена печінкова недостатність. - Виражена серцева недостатність. - Схильність до тромбозів, тромбофлебіт. - Цукровий діабет. - Комбінація з метотрексатом у дозуванні 15 мг/тиждень або більше (див. розділ «Взаємодія з іншими лікарськими засобами та інші види взаємодій»).</Value></Item><Item><Key>6</Key><Value>діючі речовини: ацетилсаліцилова кислота та аскорбінова кислота; 1 таблетка містить 400 мг ацетилсаліцилової кислоти та 240 мг аскорбінової кислоти (вітаміну С); допоміжні речовини: натрію дигідроцитрат, натрію гідрокарбонат, кислота лимонна безводна, натрію карбонат безводний.</Value></Item><Item><Key>7</Key><Value>3 роки</Value></Item><Item><Key>8</Key><Value>АСПІРИН® С</Value></Item><Item><Key>9</Key><Value>	Стрип</Value></Item><Item><Key>10</Key><Value>Аналгетики та антипіретики. Кислота ацетилсаліцилова. Код АТХ N02В А01.</Value></Item></DictStringProperties><DictIntProperties /><DictDoubleProperties /></PropertyValuesDTO>",
                Category_Id = 3,
                WebShop_Id = 1,
                Status = true,
                Name = "Аспирин C №10 таблетки шипучиеs",
                Price = 68.2m,
                ImgLink = "https://www.apteka24.ua/upload/iblock/d13/d13b9fe9ab6e453f536caf8f234df55d.jpg",
                UrlLink = "https://www.apteka24.ua/naklofen-75-mg-3-ml-n5/",
                Description = "Шипучие таблетки Аспирин С №10 - это всем хорошо известное средство, которое отменно борется с головной и зубной болью, а также эффективно устраняет мышечные и суставные боли. Относится данный препарат к группе анальгетиков и антипиретиков и содержит ацетилсалициловую кислоту. Именно за счет данного компонента и осуществляется его терапевтический эффект.",
                OldPrice = 66.6m
            };
            Good good13 = new Good()
            {
                XmlData = "<?xml version=\"1.0\" encoding=\"utf - 8\"?><PropertyValuesDTO type=\"Model.DTO.PropertyValuesDTO\"><DictStringProperties><Item><Key>1</Key><Value>Таблетки шипучі № 10 (2х5) у стрипах</Value></Item><Item><Key>2</Key><Value>Байєр Біттерфельд ГмбХ, Німеччина</Value></Item><Item><Key>3</Key><Value>Препарат застосовують дітям віком від 15 років.</Value></Item><Item><Key>4</Key><Value>Незначний або помірний біль, такий як головний біль, зубний біль, періодичні болі у жінок, больові симптоми, пов’язані з застудою (наприклад, головний біль, біль у горлі, біль у кінцівках). -Гарячка.</Value></Item><Item><Key>5</Key><Value>	Гіперчутливість до ацетилсаліцилової кислоти, інших саліцилатів, аскорбінової кислоти або до будь-якого компонента препарату. - Бронхіальна астма, спричинена застосуванням саліцилатів або інших НПЗЗ в анамнезі. - Гострі шлунково-кишкові виразки. - Геморагічний діатез. - Тяжкі захворювання нирок; виражена ниркова недостатність. - Сечокам’яна хвороба. - Виражена печінкова недостатність. - Виражена серцева недостатність. - Схильність до тромбозів, тромбофлебіт. - Цукровий діабет. - Комбінація з метотрексатом у дозуванні 15 мг/тиждень або більше (див. розділ «Взаємодія з іншими лікарськими засобами та інші види взаємодій»).</Value></Item><Item><Key>6</Key><Value>діючі речовини: ацетилсаліцилова кислота та аскорбінова кислота; 1 таблетка містить 400 мг ацетилсаліцилової кислоти та 240 мг аскорбінової кислоти (вітаміну С); допоміжні речовини: натрію дигідроцитрат, натрію гідрокарбонат, кислота лимонна безводна, натрію карбонат безводний.</Value></Item><Item><Key>7</Key><Value>3 роки</Value></Item><Item><Key>8</Key><Value>АСПІРИН® С</Value></Item><Item><Key>9</Key><Value>	Стрип</Value></Item><Item><Key>10</Key><Value>Аналгетики та антипіретики. Кислота ацетилсаліцилова. Код АТХ N02В А01.</Value></Item></DictStringProperties><DictIntProperties /><DictDoubleProperties /></PropertyValuesDTO>",
                Category_Id = 3,
                WebShop_Id = 1,
                Status = true,
                Name = "Аспирин C №10 таблетки шипучиеs",
                Price = 68.2m,
                ImgLink = "https://www.apteka24.ua/upload/iblock/d13/d13b9fe9ab6e453f536caf8f234df55d.jpg",
                UrlLink = "https://www.apteka24.ua/naklofen-75-mg-3-ml-n5/",
                Description = "Шипучие таблетки Аспирин С №10 - это всем хорошо известное средство, которое отменно борется с головной и зубной болью, а также эффективно устраняет мышечные и суставные боли. Относится данный препарат к группе анальгетиков и антипиретиков и содержит ацетилсалициловую кислоту. Именно за счет данного компонента и осуществляется его терапевтический эффект.",
                OldPrice = 66.6m
            };
            Good good14 = new Good()
            {
                XmlData = "<?xml version=\"1.0\" encoding=\"utf - 8\"?><PropertyValuesDTO type=\"Model.DTO.PropertyValuesDTO\"><DictStringProperties><Item><Key>1</Key><Value>Таблетки шипучі № 10 (2х5) у стрипах</Value></Item><Item><Key>2</Key><Value>Байєр Біттерфельд ГмбХ, Німеччина</Value></Item><Item><Key>3</Key><Value>Препарат застосовують дітям віком від 15 років.</Value></Item><Item><Key>4</Key><Value>Незначний або помірний біль, такий як головний біль, зубний біль, періодичні болі у жінок, больові симптоми, пов’язані з застудою (наприклад, головний біль, біль у горлі, біль у кінцівках). -Гарячка.</Value></Item><Item><Key>5</Key><Value>	Гіперчутливість до ацетилсаліцилової кислоти, інших саліцилатів, аскорбінової кислоти або до будь-якого компонента препарату. - Бронхіальна астма, спричинена застосуванням саліцилатів або інших НПЗЗ в анамнезі. - Гострі шлунково-кишкові виразки. - Геморагічний діатез. - Тяжкі захворювання нирок; виражена ниркова недостатність. - Сечокам’яна хвороба. - Виражена печінкова недостатність. - Виражена серцева недостатність. - Схильність до тромбозів, тромбофлебіт. - Цукровий діабет. - Комбінація з метотрексатом у дозуванні 15 мг/тиждень або більше (див. розділ «Взаємодія з іншими лікарськими засобами та інші види взаємодій»).</Value></Item><Item><Key>6</Key><Value>діючі речовини: ацетилсаліцилова кислота та аскорбінова кислота; 1 таблетка містить 400 мг ацетилсаліцилової кислоти та 240 мг аскорбінової кислоти (вітаміну С); допоміжні речовини: натрію дигідроцитрат, натрію гідрокарбонат, кислота лимонна безводна, натрію карбонат безводний.</Value></Item><Item><Key>7</Key><Value>3 роки</Value></Item><Item><Key>8</Key><Value>АСПІРИН® С</Value></Item><Item><Key>9</Key><Value>	Стрип</Value></Item><Item><Key>10</Key><Value>Аналгетики та антипіретики. Кислота ацетилсаліцилова. Код АТХ N02В А01.</Value></Item></DictStringProperties><DictIntProperties /><DictDoubleProperties /></PropertyValuesDTO>",
                Category_Id = 3,
                WebShop_Id = 1,
                Status = true,
                Name = "Аспирин C №10 таблетки шипучиеs",
                Price = 68.2m,
                ImgLink = "https://www.apteka24.ua/upload/iblock/d13/d13b9fe9ab6e453f536caf8f234df55d.jpg",
                UrlLink = "https://www.apteka24.ua/naklofen-75-mg-3-ml-n5/",
                Description = "Шипучие таблетки Аспирин С №10 - это всем хорошо известное средство, которое отменно борется с головной и зубной болью, а также эффективно устраняет мышечные и суставные боли. Относится данный препарат к группе анальгетиков и антипиретиков и содержит ацетилсалициловую кислоту. Именно за счет данного компонента и осуществляется его терапевтический эффект.",
                OldPrice = 66.6m
            };


            //PriceHistory priceHistory1 = new PriceHistory()
            //{
            //    Name = "Lenovo ideapad",
            //    Url = "http://rozetka.com.ua/lenovo_110_17acl_80um002fra/p11781151/",
            //    Date = new DateTime(2016, 12, 1),
            //    Price = 9999
            //};
            //PriceHistory priceHistory2 = new PriceHistory()
            //{
            //    Name = "Lenovo ideapad",
            //    Url = "http://rozetka.com.ua/lenovo_110_17acl_80um002fra/p11781151/",
            //    Date = new DateTime(2016, 12, 2),
            //    Price = 8888
            //};
            #region Users and Roles
            context.Roles.AddOrUpdate(role_user);
            context.Users.AddOrUpdate(user);
            context.Users.AddOrUpdate(user2);
            #endregion
            #region Categories
            context.Categories.AddOrUpdate(cat1);
            context.Categories.AddOrUpdate(cat2);
            context.Categories.AddOrUpdate(cat3);
            context.Categories.AddOrUpdate(cat4);
            context.Categories.AddOrUpdate(cat5);
            context.Categories.AddOrUpdate(cat6);
            context.Categories.AddOrUpdate(cat7);
            context.Categories.AddOrUpdate(cat1Son1);
            context.Categories.AddOrUpdate(cat1Son2);
            context.Categories.AddOrUpdate(cat1Son1Son);
            context.Categories.AddOrUpdate(cat2Son1);
            context.Categories.AddOrUpdate(cat2Son2);
            context.Categories.AddOrUpdate(cat3Son1);
            context.Categories.AddOrUpdate(cat3Son2);
            context.Categories.AddOrUpdate(cat4Son1);
            context.Categories.AddOrUpdate(cat4Son2);
            context.Categories.AddOrUpdate(cat4Son3);
            context.Categories.AddOrUpdate(cat5Son1);
            context.Categories.AddOrUpdate(cat5Son2);
            context.Categories.AddOrUpdate(cat6Son1);
            context.Categories.AddOrUpdate(cat6Son2);
            context.Categories.AddOrUpdate(cat7Son1);
            context.Categories.AddOrUpdate(cat7Son2);
            #endregion
            #region Pharmacy
            context.WebShops.AddOrUpdate(webShop1);
            context.WebShops.AddOrUpdate(webShop2);
            context.WebShops.AddOrUpdate(webShop3);
            #endregion
            foreach (var category in categories)
            {
                foreach (var item in properties)
                {
                    item.Category = category;
                    context.Properties.Add(item);
                    context.SaveChanges();
                }
            }
            //context.Properties.AddOrUpdate(prop1);
            //context.Properties.AddOrUpdate(prop2);
            //context.Properties.AddOrUpdate(prop3);
            //context.Properties.AddOrUpdate(prop4);
            //context.Properties.AddOrUpdate(prop5);
            //context.ParserTasks.AddOrUpdate(task);
            //context.ParserTasks.AddOrUpdate(task2);

            context.Goods.AddOrUpdate(good1);
            context.Goods.AddOrUpdate(good2);
            context.Goods.AddOrUpdate(good3);
            context.Goods.AddOrUpdate(good4);
            context.Goods.AddOrUpdate(good5);
            context.Goods.AddOrUpdate(good6);
            context.Goods.AddOrUpdate(good7);
            context.Goods.AddOrUpdate(good8);
            context.Goods.AddOrUpdate(good9);
            context.Goods.AddOrUpdate(good10);
            context.Goods.AddOrUpdate(good11);
            context.Goods.AddOrUpdate(good12);
            context.Goods.AddOrUpdate(good13);
            context.Goods.AddOrUpdate(good14);
            //context.PriceHistory.AddOrUpdate(priceHistory1);
            //context.PriceHistory.AddOrUpdate(priceHistory2);
        }
    }
}