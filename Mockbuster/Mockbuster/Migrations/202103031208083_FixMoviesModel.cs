namespace Mockbuster.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixMoviesModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "NumberAvailable", c => c.Byte(nullable: true));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "NumberAvailable", c => c.Byte());
        }
    }
}
