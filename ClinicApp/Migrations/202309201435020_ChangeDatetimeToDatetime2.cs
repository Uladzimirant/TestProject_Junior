namespace ClinicApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeDatetimeToDatetime2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PatientCards", "DateOfBirth", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Requests", "DateOfRequest", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Requests", "DateOfRequest", c => c.DateTime(nullable: false));
            AlterColumn("dbo.PatientCards", "DateOfBirth", c => c.DateTime(nullable: false));
        }
    }
}
