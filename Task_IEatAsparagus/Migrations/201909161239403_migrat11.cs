namespace Task_IEatAsparagus.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migrat11 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Count", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Count");
        }
    }
}
