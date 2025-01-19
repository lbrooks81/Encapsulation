using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem
{
    public class Faculty : Person
    {
        public int Id { get; set; }
        public List<Class>? Classes { get; set; } = [];

        public Faculty(String fname, String lname, String gender, int age) 
            : base(fname, lname, gender, age)
        { }

        public void DisplayInfo()
        {
            base.DisplayInfo();
            foreach (Class c in Classes)
            {
                Console.WriteLine($"{c.Title}\nCourse Code:{c.CourseCode}\n");
            }
        }
    }
}
