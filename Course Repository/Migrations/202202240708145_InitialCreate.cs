namespace Course_Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Course Information",
                c => new
                    {
                        Duration = c.Int(nullable: false),
                        CourseName = c.String(name: "Course Name", nullable: false, maxLength: 50),
                        UniqueId = c.Int(name: "Unique Id", nullable: false),
                        StudId = c.String(maxLength: 3),
                        CourseFee = c.Double(nullable: false),
                        InstructorName = c.String(nullable: false, maxLength: 25),
                    })
                .PrimaryKey(t => t.UniqueId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Course Information");
        }
    }
}
