namespace Course_Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CourseDBV1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Course Information", "InstructorName", c => c.String(maxLength: 25));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Course Information", "InstructorName", c => c.String(nullable: false, maxLength: 25));
        }
    }
}
