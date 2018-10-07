namespace Movies_portal_MVC5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateMembershipType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MembershipTypes", "Name", c => c.String(maxLength: 255));
            
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MembershipTypes", "Name", c => c.String());
        }
    }
}
