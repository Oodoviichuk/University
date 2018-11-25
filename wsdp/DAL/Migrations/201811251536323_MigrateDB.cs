namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrateDB : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Goods", "Description", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Goods", "Description");
        }
    }
}
