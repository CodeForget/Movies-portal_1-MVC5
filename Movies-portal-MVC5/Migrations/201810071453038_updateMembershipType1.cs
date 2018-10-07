namespace Movies_portal_MVC5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateMembershipType1 : DbMigration
    {
        public override void Up()
        {
            Sql("update dbo.MembershipTypes set Name='Pay as You Go' where Id=1 ");
            Sql("update dbo.MembershipTypes set Name='Monthly' where Id=2 ");
            Sql("update dbo.MembershipTypes set Name='Quaterly' where Id=3 ");
            Sql("update dbo.MembershipTypes set Name='Yearly' where Id=4 ");
        }
        
        public override void Down()
        {
        }
    }
}
