namespace Mockbuster.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixMoviesModel1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "DateAdded", c => c.DateTime());
            AlterColumn("dbo.Movies", "NumberAvailable", c => c.Byte());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "NumberAvailable", c => c.Byte(nullable: false));
            AlterColumn("dbo.Movies", "DateAdded", c => c.DateTime(nullable: false));
        }
    }
}
