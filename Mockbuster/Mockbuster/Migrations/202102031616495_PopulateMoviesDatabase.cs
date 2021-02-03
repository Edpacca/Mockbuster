namespace Mockbuster.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMoviesDatabase : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES('Hangover', 'Comedy', 2010-08-10, 2019-03-03, 5)");
            Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES('Die Hard', 'Action', 1995-02-14, 2019-03-03, 15)");
            Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES('The Terminator', 'Action', 1986-06-22, 2019-03-03, 8)");
            Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES('Toy Story', 'Family', 1996-03-19, 2019-03-03, 8)");
            Sql("INSERT INTO Movies (Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES('Titanic', 'Romance', 1981-07-15, 2019-03-03, 2)");
        }
        
        public override void Down()
        {
        }
    }
}
