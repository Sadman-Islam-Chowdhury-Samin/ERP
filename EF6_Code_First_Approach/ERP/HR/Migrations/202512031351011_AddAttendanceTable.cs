namespace HR.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAttendanceTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Attendances",
                c => new
                    {
                        AttendanceID = c.Int(nullable: false, identity: true),
                        EmployeeName = c.String(),
                        AttendanceDate = c.DateTime(nullable: false),
                        IsPresent = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.AttendanceID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Attendances");
        }
    }
}
