namespace Movies_portal_MVC5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBithdayToCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Bithday", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Bithday");
        }
    }
}
