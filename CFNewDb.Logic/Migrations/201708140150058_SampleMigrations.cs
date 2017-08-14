namespace CFNewDb.Logic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SampleMigrations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "Name", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Products", "Description", c => c.String(nullable: false, maxLength: 150));
            AlterColumn("dbo.Products", "Image", c => c.Binary(storeType: "image"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "Image", c => c.Binary());
            AlterColumn("dbo.Products", "Description", c => c.String());
            AlterColumn("dbo.Products", "Name", c => c.String());
        }
    }
}
