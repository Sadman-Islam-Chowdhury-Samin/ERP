namespace HR.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLeaveApplicationTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LeaveApplications",
                c => new
                    {
                        LeaveID = c.Int(nullable: false, identity: true),
                        EmployeeName = c.String(),
                        LeaveDuration = c.String(),
                    })
                .PrimaryKey(t => t.LeaveID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.LeaveApplications");
        }
    }
}
