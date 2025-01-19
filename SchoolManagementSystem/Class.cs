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
        private List<Student>? Students { get; set; } = [];
        private Faculty Teacher { get; set; }
        
        public Class(String title, String description, String courseCode, List<Student> students, Faculty teacher)
        { 
            Title = title;
            Description = description;
            CourseCode = courseCode;
            if(students != null) Students = students;
            Teacher = teacher;
        }

        public Class(String title, String courseCode, Faculty teacher)
        {
            Title = title;
            CourseCode = courseCode;
            Teacher = teacher;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"\n{Title}\nCourse Code: {CourseCode}\n");
            if(Description != null) Console.WriteLine($"Course Description: {Description}");
            
            Console.WriteLine("Teacher");
            Teacher.DisplayInfo();
            
            Console.Write(Environment.NewLine);
            Console.WriteLine("Student Roster");
            foreach(Student s in Students!)
            {
                if(s != null) s.DisplayInfo();
            }
        }
        public void EnrollStudents(List<Student> students)
        {
            foreach(Student s in students)
            {
                if (s != null) Students!.Add(s);
                s.Classes!.Add(this);
            }
        }

        public void AssignTeacher(Faculty teacher)
        {
            if (teacher != null) Teacher = teacher;
        }
    }
}
