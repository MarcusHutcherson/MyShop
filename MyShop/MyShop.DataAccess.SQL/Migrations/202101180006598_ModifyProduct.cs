namespace MyShop.DataAccess.SQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyProduct : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Category", c => c.String());
            AlterColumn("dbo.Products", "Name", c => c.String(maxLength: 25));
            DropColumn("dbo.Products", "Catagory");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Catagory", c => c.String());
            AlterColumn("dbo.Products", "Name", c => c.String(maxLength: 20));
            DropColumn("dbo.Products", "Category");
        }
    }
}
