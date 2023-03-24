using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Course_Repository
{
    [Table("Course Information")]
    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("Unique Id")]
        public int CourseId { get; set; }
        public string StudId { get; set; }

        [MaxLength(50)]
        [Column("Course Name", Order =5)]
        [Required]
        public string CourseName { get; set; }

        [Required]
        public double CourseFee { get; set; }

        [Column(Order = 2)]
        public int Duration { get; set; }

        [MaxLength(25)]
       //[RegularExpression("^(a-zA-Z)*$")]
        public string InstructorName { get; set; }
        //public Mentor Mentor { get; set; }
        //public int MentorId { get; internal set; }
    }
}
