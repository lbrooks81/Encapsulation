using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem
{
    public class Class
    {
        public String? Title { get; set; }
        public String? Description { get; set; }
        public String? CourseCode { get; set; }
        private List<Student>? Students { get; set; }
        private Faculty Teacher { get; set; }
        
        public Class(String title, String description, String courseCode, List<Student> students, Faculty teacher)
        { 
            Title = title;
            Description = description;
            CourseCode = courseCode;
            Students = students;
            Teacher = teacher;
        }

        public Class(String title, String courseCode, List<Student> students, Faculty teacher)
        {
            Title = title;
            CourseCode = courseCode;
            Students = students;
            Teacher = teacher;
        }
        public void EnrollStudent(Student student)
        {
            // TODO
        }
    }
}
