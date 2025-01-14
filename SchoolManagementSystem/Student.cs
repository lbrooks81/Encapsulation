using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem
{
    public class Student : Person
    {
        public float GPA {  get; set; }
        public int Id { get; set; }
        private List<Class>? Classes { get; set; }

        public Student(String fname, String lname, String gender, int age) 
            : base(fname, lname, gender, age){}
        public void DisplayClasses()
        {
            // TODO
            foreach(Class c in Classes)
            {
                Console.WriteLine($"{c.Title}\nCourse Code:{c.CourseCode}\n");
            }
        }
    }
}
