namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addSocialNetworkToUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "SocialNetwork", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "SocialNetwork");
        }
    }
}
