namespace Task_IEatAsparagus.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migrat1 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Users");
            AlterColumn("dbo.Users", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Users", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Users");
            AlterColumn("dbo.Users", "Id", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Users", "Id");
        }
    }
}
