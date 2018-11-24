using Model.DB;

namespace DAL.Migrations
{
	using System;
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
				OrderNo = 1
			};
            Category cat1Son1 = new Category()
            {
                Name = "Препарати від застуди",
                ParentCategory = cat1,
                OrderNo = 1
            };
            Category cat1Son2 = new Category()
            {
                Name = "Знеболюючі засоби",
                ParentCategory = cat1,
                OrderNo = 2
            };
            Category cat1Son1Son = new Category()
            {
                Name = "Препарати при сухому кашлю",
                ParentCategory = cat1Son1,
                OrderNo = 1
            };
            #endregion
            #region cat2
            Category cat2 = new Category() {
				Name = "Бади та вітаміни",
				OrderNo = 2
			};
            Category cat2Son1 = new Category()
            {
                Name = "Бади для серця та сосудів",
                ParentCategory = cat2,
                OrderNo = 1
            };
            Category cat2Son2 = new Category()
            {
                Name = "Вітаміни для очей",
                ParentCategory = cat2,
                OrderNo = 2
            };
            #endregion
            #region cat3
            Category cat3 = new Category()
            {
                Name = "Антибіотики",
                OrderNo = 3
            };
            Category cat3Son1 = new Category()
            {
                Name = "Антибіотики в дерматології",
                ParentCategory = cat3,
                OrderNo = 1
            };
            Category cat3Son2 = new Category()
            {
                Name = "Антибіотики для дітей",
                ParentCategory = cat3,
                OrderNo = 2
            };
            #endregion
            #region cat4
            Category cat4 = new Category()
            {
                Name = "Товари для косметологів",
                OrderNo = 4
            };
            Category cat4Son1 = new Category()
            {
                Name = "Рукавички",
                ParentCategory = cat4,
                OrderNo = 1
            };
            Category cat4Son2 = new Category()
            {
                Name = "Анестетики",
                ParentCategory = cat4,
                OrderNo = 2
            };
            Category cat4Son3 = new Category()
            {
                Name = "Ботулінотерапія",
                ParentCategory = cat4,
                OrderNo = 3
            };
            #endregion
            #region cat5
            Category cat5 = new Category()
            {
                Name = "Медтехніка",
                OrderNo = 5
            };
            Category cat5Son1 = new Category()
            {
                Name = "Глюкометри",
                ParentCategory = cat5,
                OrderNo = 1
            };
            Category cat5Son2 = new Category()
            {
                Name = "Інгалятори",
                ParentCategory = cat5,
                OrderNo = 2
            };
            #endregion
            #region cat6
            Category cat6 = new Category()
            {
                Name = "Товари для мам та дітей",
                OrderNo = 6
            };
            Category cat6Son1 = new Category()
            {
                Name = "Дитяче харчування",
                ParentCategory = cat6,
                OrderNo = 1
            };
            Category cat6Son2 = new Category()
            {
                Name = "Дитячі пеленки",
                ParentCategory = cat6,
                OrderNo = 2
            };
            #endregion
            #region cat7
            Category cat7 = new Category()
            {
                Name = "Косметика",
                OrderNo = 7
            };
            Category cat7Son1 = new Category()
            {
                Name = "Лікувальна косметика",
                ParentCategory = cat7,
                OrderNo = 1
            };
            Category cat7Son2 = new Category()
            {
                Name = "Засоби для рук",
                ParentCategory = cat7,
                OrderNo = 2
            };
            #endregion

			//Property prop1 = new Property() {
			//	Category = categorySmartphones,
			//	Name = "Display",
			//	DefaultValue = "Retina",
			//	Description = "qwerty",
			//	Prefix = "mm",
			//	Sufix = "gg",
			//	Type = PropertyType.String
			//};
			//Property prop2 = new Property() {
			//	Category = categorySmartphones,
			//	Name = "Diagonal",
			//	DefaultValue = "5,7",
			//	Description = "qwerty",
			//	Prefix = "mm",
			//	Sufix = "gg",
			//	Type = PropertyType.String
			//};
			//Property prop3 = new Property() {
			//	Category = categorySmartphones,
			//	Name = "Camera",
			//	DefaultValue = "8",
			//	Description = "qwerty",
			//	Prefix = "px",
			//	Sufix = "px",
			//	Type = PropertyType.String
			//};
			//Property prop4 = new Property() {
			//	Category = categorySmartphones,
			//	Name = "Battery",
			//	DefaultValue = "3700",
			//	Description = "qwerty",
			//	Prefix = "amp",
			//	Sufix = "amp",
			//	Type = PropertyType.String
			//};
			//Property prop5 = new Property() {
			//	Category = categorySmartphones,
			//	Name = "Sound",
			//	DefaultValue = "Gromkiy",
			//	Description = "qwerty",
			//	Prefix = "mm",
			//	Sufix = "gg",
			//	Type = PropertyType.String
			//};
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
            //Good good1 = new Good()
            //{
            //    XmlData = "<?xml version=\"1.0\" encoding=\"utf - 8\"?><PropertyValuesDTO type=\"Model.DTO.PropertyValuesDTO\"><DictStringProperties /><DictIntProperties /><DictDoubleProperties /></PropertyValuesDTO>",
            //    Category_Id = 4,
            //    WebShop_Id = 1,
            //    Status = true,
            //    Name = "Ноутбук Lenovo IdeaPad 110-17ACL (80UM002FRA) Black Суперцена!!!&nbsp;",
            //    Price = 7999,
            //    ImgLink = "http://i2.rozetka.ua/goods/1742927/lenovo_110_17acl_80um002fra_images_1742927925.jpg",
            //    UrlLink = "http://rozetka.com.ua/lenovo_110_17acl_80um002fra/p11781151/",
            //    OldPrice = 9999
            //};
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
            //context.Properties.AddOrUpdate(prop1);
            //context.Properties.AddOrUpdate(prop2);
            //context.Properties.AddOrUpdate(prop3);
            //context.Properties.AddOrUpdate(prop4);
            //context.Properties.AddOrUpdate(prop5);
            //context.ParserTasks.AddOrUpdate(task);
            //context.ParserTasks.AddOrUpdate(task2);

            //context.Goods.AddOrUpdate(good1);
            //context.PriceHistory.AddOrUpdate(priceHistory1);
            //context.PriceHistory.AddOrUpdate(priceHistory2);
        }
    }
}