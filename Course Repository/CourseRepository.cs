using System;
using System.Collections.Generic;
using System.Linq;

namespace Course_Repository
{
    public class CourseRepository
    {
        CourseContext courseContext = new CourseContext();
        public IList<Course> GetCourseList()
        {
            //Select * from table
            var courseContext = new CourseContext();
            return courseContext.Courses.ToList();
        }

        public Course GetCourseByID(int courseId)
        {
            //Select * from table where id = @id
            var courseContext = new CourseContext();
            return courseContext.Courses.Find(courseId);
            //return courseContext.Courses.Where(data => data.CourseName == Coursename).First();
        }
        public void InsertCourse(Course course)
        {
            var courseContext = new CourseContext();
            courseContext.Courses.Add(course);
            courseContext.SaveChanges();
            Console.WriteLine("Details Added Successfully");
        }
        public Course UpdateCourseFee(int id, double fee)
        {
            var courseContext = new CourseContext();
            Course course = courseContext.Courses.Find(id);
            course.CourseFee = fee;
            courseContext.SaveChanges();
            return course;
        }
    }
}
