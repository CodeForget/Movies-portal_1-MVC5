namespace Movies_portal_MVC5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateGenre : DbMigration
    {
        public override void Up()
        {
            Sql("insert into MovieGenres (Id,Name) values(1,'Action')");
            Sql("insert into MovieGenres (Id,Name) values(2,'Adventure')");
            Sql("insert into MovieGenres (Id,Name) values(3,'Animation')");
            Sql("insert into MovieGenres (Id,Name) values(4,'Crime')");
            Sql("insert into MovieGenres (Id,Name) values(5,'Drama')");
            Sql("insert into MovieGenres (Id,Name) values(6,'Epic')");
            Sql("insert into MovieGenres (Id,Name) values(7,'Fantasy')");
            Sql("insert into MovieGenres (Id,Name) values(8,'Horror')");
            Sql("insert into MovieGenres (Id,Name) values(9,'Romance')");
            Sql("insert into MovieGenres (Id,Name) values(10,'Science fiction')");
        }
        
        public override void Down()
        {
        }
    }
}
