namespace E_shop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Categories", "Description", c => c.String(nullable: false));
            AlterColumn("dbo.Categories", "Thumbnail", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Categories", "Thumbnail", c => c.String(nullable: false));
            AlterColumn("dbo.Categories", "Description", c => c.String(nullable: false, maxLength: 250));
        }
    }
}
