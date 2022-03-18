namespace FaicEcommerce.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update1 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Products", new[] { "Category_Id" });
            DropColumn("dbo.Products", "CategoryId");
            RenameColumn(table: "dbo.Products", name: "Category_Id", newName: "CategoryId");
            AlterColumn("dbo.Categories", "CategoryName", c => c.String());
            AlterColumn("dbo.Products", "CategoryId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Products", "CategoryId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Products", new[] { "CategoryId" });
            AlterColumn("dbo.Products", "CategoryId", c => c.Int(nullable: false));
            AlterColumn("dbo.Categories", "CategoryName", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Products", name: "CategoryId", newName: "Category_Id");
            AddColumn("dbo.Products", "CategoryId", c => c.Int(nullable: false));
            CreateIndex("dbo.Products", "Category_Id");
        }
    }
}
