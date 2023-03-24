namespace Course_Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CourseDBV2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Course Information", "StudId", c => c.String(maxLength: 8));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Course Information", "StudId", c => c.String(maxLength: 3));
        }
    }
}
