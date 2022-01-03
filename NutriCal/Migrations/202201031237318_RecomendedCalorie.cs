namespace NutriCal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RecomendedCalorie : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "RecomendedCalorie", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "RecomendedCalorie");
        }
    }
}
