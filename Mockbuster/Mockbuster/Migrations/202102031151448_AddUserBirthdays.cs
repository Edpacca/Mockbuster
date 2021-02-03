namespace Mockbuster.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserBirthdays : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET BirthDate = 1973-04-10 WHERE Id = 1");
            Sql("UPDATE Customers SET BirthDate = 1215-05-11 WHERE Id = 3");
        }
        
        public override void Down()
        {
        }
    }
}
