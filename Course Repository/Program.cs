using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Repository
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Course course = new Course();

            Console.WriteLine("Enter Course ID");
            course.CourseId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Student ID");

            course.StudId = Console.ReadLine();
            Console.WriteLine("Enter Course Name");
            course.CourseName = Console.ReadLine();
            Console.WriteLine("Enter Duration");
            course.Duration = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Course Fee");
            course.CourseFee = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Instructor Name");
            course.InstructorName = Console.ReadLine();

            CourseRepository courseRepository = new CourseRepository();

            courseRepository.InsertCourse(course);

            //Console.WriteLine("Get Course Details By id");
            //int idToGetCourse = Convert.ToInt32(Console.ReadLine());
            //Course CoursebyId = courseRepository.GetCourseByID(idToGetCourse);
            //Console.WriteLine(CoursebyId.CourseName + "\n" + CoursebyId.Duration + "\n" + CoursebyId.CourseFee + "\n" + CoursebyId.InstructorName);

            //Console.WriteLine("Get Course List");
            //IList<Course> courseList = courseRepository.GetCourseList();
            //foreach (var courseDetail in courseList)
            //{
            //    Console.WriteLine(courseDetail.CourseId + "-" + courseDetail.CourseName + "-" + courseDetail.Duration + "-" + courseDetail.CourseFee + "-" + courseDetail.InstructorName);
            //}

            //Console.WriteLine("Update Course Fee");
            //int idToUpdate = Convert.ToInt32(Console.ReadLine());
            //double feesToUpdate = Convert.ToDouble(Console.ReadLine());
            //Course courseAfterUpdate = courseRepository.UpdateCourseFee(idToUpdate, feesToUpdate);

            //if (courseAfterUpdate.CourseFee == feesToUpdate)
            //{
            //    Console.WriteLine("Updated Successfully");
            //}

            Console.ReadLine();

        }
    }
}
