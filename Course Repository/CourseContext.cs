using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;


namespace Course_Repository
{
    public class CourseContext : DbContext
    {
        public CourseContext() : base("Name=CourseConnectionString")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<CourseContext, Migrations.Configuration>());
        }
        public virtual DbSet<Course> Courses { get; set; }
        //public virtual DbSet<Mentor> Mentors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.HasDefaultSchema("Course");
            //modelBuilder.Entity<Course>().ToTable("Course Information");
            //modelBuilder.Entity<Course>().HasKey(data => data.CourseId);
            //modelBuilder.Entity<Course>().Property(property => property.CourseName).HasMaxLength(50).HasColumnName("Course Name").HasColumnOrder(5).IsRequired();
            modelBuilder.Entity<Course>().Property(property => property.CourseId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            //modelBuilder.Entity<Course>().Property(property => property.CourseFee).IsRequired();
            //modelBuilder.Entity<Course>().Property(property => property.Duration).IsRequired();
            modelBuilder.Entity<Course>().Property(property => property.InstructorName).IsOptional();
            modelBuilder.Entity<Course>().Property(property => property.StudId).HasMaxLength(8);
            //modelBuilder.Entity<Course>().Property(e => e.MentorId).IsRequired();
            //modelBuilder.Entity<Course>().HasRequired(b => b.Mentor).WithMany(a => a.Courses).HasForeignKey(b => b.MentorId);
        }
    }
}
