namespace WebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Blogs", "URL");
            DropColumn("dbo.Blogs", "Rating");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Blogs", "Rating", c => c.Int(nullable: false));
            AddColumn("dbo.Blogs", "URL", c => c.String());
        }
    }
}
