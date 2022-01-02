namespace NutriCal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class QuantityAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Foods", "Quantity", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Foods", "Quantity");
        }
    }
}
