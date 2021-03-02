namespace Mockbuster.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeNumberavailableRequired1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "NumberAvailable", c => c.Byte());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "NumberAvailable", c => c.Byte(nullable: false));
        }
    }
}
